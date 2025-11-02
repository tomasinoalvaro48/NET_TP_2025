using Application.Services;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using ScottPlot;
using System.Globalization;
using QColors = QuestPDF.Helpers.Colors;

namespace WebAPI
{
    public static class ReporteEndpoints
    {
        public static void MapReporteEndpoints(this WebApplication app)
        {
            app.MapGet("/reportes/pedidos_resolucion_mes_actual", async () =>
            {
                var culture = new CultureInfo("es-AR");
                var now = DateTime.Now;
                var desde = new DateTime(now.Year, now.Month, 1);
                var hasta = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));

                var pedidoService = new PedidoResolucionService();
                var pedidos = await pedidoService.GetAllAsync();

                var pedidosDelMes = pedidos
                    .Where(p => p.Fecha.Date >= desde.Date && p.Fecha.Date <= hasta.Date)
                    .ToList();

                int total = pedidosDelMes.Count;

                bool IsEstado(string? estado, params string[] targets)
                    => targets.Any(t => string.Equals(estado, t, StringComparison.OrdinalIgnoreCase));

                int aceptados = pedidosDelMes.Count(p => IsEstado(p.Estado, "aceptado"));
                int pendientes = pedidosDelMes.Count(p => IsEstado(p.Estado, "solicitado", "pendiente"));
                int resueltos = pedidosDelMes.Count(p => IsEstado(p.Estado, "finalizado", "resuelto"));

                double pctAceptados = total > 0 ? (aceptados * 100.0) / total : 0;
                double pctPendientes = total > 0 ? (pendientes * 100.0) / total : 0;
                double pctResueltos = total > 0 ? (resueltos * 100.0) / total : 0;

                var plt = new ScottPlot.Plot();
                double[] valores = { aceptados, pendientes, resueltos };
                string[] etiquetas = { "Aceptados", "Pendientes", "Resueltos" };

                if (valores.Sum() > 0)
                {
                    var pie = plt.Add.Pie(valores);

                    double totalSlices = valores.Sum();
                    for (int i = 0; i < etiquetas.Length; i++)
                    {
                        double pct = totalSlices > 0 ? (valores[i] / totalSlices) * 100.0 : 0;
                        pie.Slices[i].Label = $"{etiquetas[i]} ({pct:0.#}%)";
                    }

                    pie.DonutFraction = 0.5;
                    plt.Title("Distribución porcentual de pedidos del mes actual");
                }
                else
                {
                    plt.Title("Sin datos para el período seleccionado");
                }

                string chartPath = Path.Combine(Path.GetTempPath(), $"grafico_pedidos_resolucion_{Guid.NewGuid():N}.png");
                plt.SavePng(chartPath, 800, 500);

                byte[] pdfBytes;
                try
                {
                    pdfBytes = Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(30);

                            page.Content().Column(column =>
                            {
                                column.Item().Text($"Reporte de Pedidos de Resolución - {now.ToString("MMMM yyyy", culture)}")
                                    .FontSize(20)
                                    .Bold()
                                    .AlignCenter();

                                column.Item().Text($"Período: {desde:dd/MM/yyyy} - {hasta:dd/MM/yyyy}")
                                    .FontSize(12)
                                    .SemiBold()
                                    .AlignCenter();

                                column.Item().LineHorizontal(1).LineColor(QColors.Grey.Medium);
                                column.Item();

                                column.Item().Text($"Total del mes: {total}")
                                    .FontSize(14).Bold().FontColor(QColors.Blue.Medium);

                                column.Item().Text($"Aceptados: {aceptados} ({pctAceptados:0.#}%)")
                                    .FontSize(12).FontColor(QColors.Green.Medium);

                                column.Item().Text($"Pendientes: {pendientes} ({pctPendientes:0.#}%)")
                                    .FontSize(12).FontColor(QColors.Orange.Medium);

                                column.Item().Text($"Resueltos: {resueltos} ({pctResueltos:0.#}%)")
                                    .FontSize(12).FontColor(QColors.Teal.Medium);

                                column.Item().LineHorizontal(1).LineColor(QColors.Grey.Medium);
                                column.Item();

                                column.Item().Text("Distribución de pedidos:").Bold().FontSize(13);
                                column.Item().AlignCenter().Image(chartPath).FitWidth();
                            });
                        });
                    }).GeneratePdf();
                }
                finally
                {
                    try { if (System.IO.File.Exists(chartPath)) System.IO.File.Delete(chartPath); } catch { }
                }

                return Results.File(pdfBytes, "application/pdf", "ReportePedidosResolucion.pdf");
            })
            .WithName("ReportePedidosResolucionMesActual")
            .Produces(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapGet("/reportes/pedidos_agregacion_categorias", async () =>
            {
                var now = DateTime.Now;
                var service = new PedidoAgregacionService();
                var pedidos = await service.GetAllAsync();

                int total = pedidos.Count();

                int aceptados = pedidos.Count(p => string.Equals(p.Estado_pedido_agreg, "Aceptado", StringComparison.OrdinalIgnoreCase));
                int rechazados = pedidos.Count(p => string.Equals(p.Estado_pedido_agreg, "Rechazado", StringComparison.OrdinalIgnoreCase));
                int pendientes = pedidos.Count(p => string.Equals(p.Estado_pedido_agreg, "Pendiente", StringComparison.OrdinalIgnoreCase));

                int baseCategorias = aceptados + rechazados;
                double pctAceptados = baseCategorias > 0 ? (aceptados * 100.0) / baseCategorias : 0;
                double pctRechazados = baseCategorias > 0 ? (rechazados * 100.0) / baseCategorias : 0;

                var plt = new ScottPlot.Plot();
                string[] etiquetas = { "Aceptados", "Rechazados", "Pendientes" };
                double[] valores = { aceptados, rechazados, pendientes };

                if (valores.Sum() > 0)
                {
                    var pie = plt.Add.Pie(valores);

                    double totalSlices = valores.Sum();
                    for (int i = 0; i < etiquetas.Length; i++)
                    {
                        double pct = totalSlices > 0 ? (valores[i] / totalSlices) * 100.0 : 0;
                        pie.Slices[i].Label = $"{etiquetas[i]} ({pct:0.#}%)";
                    }

                    pie.DonutFraction = 0.5;
                    plt.Title("Pedidos de Agregación - Estados");
                }
                else
                {
                    plt.Title("Sin datos para el período seleccionado");
                }

                string chartPath = Path.Combine(Path.GetTempPath(), $"grafico_pedidos_agregacion_{Guid.NewGuid():N}.png");
                plt.SavePng(chartPath, 800, 500);

                byte[] pdfBytes;
                try
                {
                    pdfBytes = Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(30);

                            page.Content().Column(column =>
                            {
                                column.Item().Text("Reporte de Pedidos de Agregación - Categorías")
                                    .FontSize(20).Bold().AlignCenter();

                                column.Item().Text($"Generado: {now:dd/MM/yyyy HH:mm}")
                                    .FontSize(11).AlignCenter();

                                column.Item().LineHorizontal(1).LineColor(QColors.Grey.Medium);
                                column.Item();

                                column.Item().Text($"Total registros: {total}")
                                    .FontSize(14).Bold().FontColor(QColors.Blue.Medium);

                                column.Item().Text($"Aceptados: {aceptados} ({pctAceptados:0.#}% sobre Aceptados+Rechazados)")
                                    .FontSize(12).FontColor(QColors.Green.Medium);

                                column.Item().Text($"Rechazados: {rechazados} ({pctRechazados:0.#}% sobre Aceptados+Rechazados)")
                                    .FontSize(12).FontColor(QColors.Red.Medium);

                                column.Item().Text($"Pendientes (no incluidos en %): {pendientes}")
                                    .FontSize(12).FontColor(QColors.Orange.Medium);

                                column.Item().LineHorizontal(1).LineColor(QColors.Grey.Medium);
                                column.Item();

                                column.Item().Text("Visualización de estados:").Bold().FontSize(13);
                                column.Item().AlignCenter().Image(chartPath).FitWidth();
                            });
                        });
                    }).GeneratePdf();
                }
                finally
                {
                    try { if (System.IO.File.Exists(chartPath)) System.IO.File.Delete(chartPath); } catch { }
                }

                return Results.File(pdfBytes, "application/pdf", "ReportePedidosAgregacionCategorias.pdf");
            })
            .WithName("ReportePedidosAgregacionCategorias")
            .Produces(StatusCodes.Status200OK)
            .WithOpenApi();
        }
    }
}
