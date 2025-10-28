using Application.Services;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Globalization;

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

                // Filtrar pedidos del mes actual (incluyendo límites)
                var pedidosDelMes = pedidos
                    .Where(p => p.Fecha.Date >= desde.Date && p.Fecha.Date <= hasta.Date)
                    .ToList();

                int total = pedidosDelMes.Count;

                // Normalizar estados típicos: solicitado (pendiente), aceptado, finalizado (resuelto)
                bool IsEstado(string? estado, params string[] targets)
                    => targets.Any(t => string.Equals(estado, t, StringComparison.OrdinalIgnoreCase));

                int aceptados = pedidosDelMes.Count(p => IsEstado(p.Estado, "aceptado"));
                int pendientes = pedidosDelMes.Count(p => IsEstado(p.Estado, "solicitado", "pendiente"));
                int resueltos = pedidosDelMes.Count(p => IsEstado(p.Estado, "finalizado", "resuelto"));

                double pctAceptados = total > 0 ? (aceptados * 100.0) / total : 0;
                double pctPendientes = total > 0 ? (pendientes * 100.0) / total : 0;
                double pctResueltos = total > 0 ? (resueltos * 100.0) / total : 0;

                var pdfBytes = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(30);

                        page.Content().Column(column =>
                        {
                            // Título
                            column.Item().Text($"Reporte de Pedidos de Resolución - {now.ToString("MMMM yyyy", culture)}")
                                .FontSize(20)
                                .Bold()
                                .AlignCenter();

                            column.Item().Text($"Periodo: {desde:dd/MM/yyyy} - {hasta:dd/MM/yyyy}")
                                .FontSize(12)
                                .SemiBold()
                                .AlignCenter();

                            column.Item().LineHorizontal(1).LineColor(Colors.Grey.Medium);
                            column.Item();

                            // Totales (solo texto)
                            column.Item().Text($"Total del mes: {total}")
                                .FontSize(14).Bold().FontColor(Colors.Blue.Medium);

                            column.Item().Text($"Aceptados: {aceptados} ({pctAceptados:0.#}%)")
                                .FontSize(12).FontColor(Colors.Green.Medium);

                            column.Item().Text($"Pendientes: {pendientes} ({pctPendientes:0.#}%)")
                                .FontSize(12).FontColor(Colors.Orange.Medium);

                            column.Item().Text($"Resueltos: {resueltos} ({pctResueltos:0.#}%)")
                                .FontSize(12).FontColor(Colors.Teal.Medium);

                            // Gráfico y leyenda COMENTADOS
                            /*
                            column.Item().Spacing(15);
                            column.Item().Text("Distribución por Estado (%)").FontSize(13).Bold();

                            column.Item().Canvas((canvas, size) =>
                            {
                                // ... (código del gráfico)
                            })
                            .Height(260);

                            column.Item().Row(row =>
                            {
                                // ... (leyenda)
                            });
                            */
                        });
                    });
                }).GeneratePdf();

                return Results.File(pdfBytes, "application/pdf", "ReportePedidosResolucion.pdf");
            })
            .WithName("ReportePedidosResolucionMesActual")
            .Produces(StatusCodes.Status200OK)
            .WithOpenApi();

            // Reporte de Pedidos de Agregación (2 categorías: Aceptados y Rechazados, Pendientes informativos)
            app.MapGet("/reportes/pedidos_agregacion_categorias", async () =>
            {
                var now = DateTime.Now;

                var service = new PedidoAgregacionService();
                var pedidos = await service.GetAllAsync();

                int total = pedidos.Count();

                int aceptados = pedidos.Count(p => string.Equals(p.Estado_pedido_agreg, "Aceptado", StringComparison.OrdinalIgnoreCase));
                int rechazados = pedidos.Count(p => string.Equals(p.Estado_pedido_agreg, "Rechazado", StringComparison.OrdinalIgnoreCase));
                int pendientes = pedidos.Count(p => string.Equals(p.Estado_pedido_agreg, "Pendiente", StringComparison.OrdinalIgnoreCase));

                int baseCategorias = aceptados + rechazados; // Para porcentajes de las 2 categorías
                double pctAceptados = baseCategorias > 0 ? (aceptados * 100.0) / baseCategorias : 0;
                double pctRechazados = baseCategorias > 0 ? (rechazados * 100.0) / baseCategorias : 0;

                var pdfBytes = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(30);

                        page.Content().Column(column =>
                        {
                            // Título
                            column.Item().Text("Reporte de Pedidos de Agregación - Categorías")
                                .FontSize(20).Bold().AlignCenter();

                            column.Item().Text($"Generado: {now:dd/MM/yyyy HH:mm}")
                                .FontSize(11).AlignCenter();

                            column.Item().LineHorizontal(1).LineColor(Colors.Grey.Medium);
                            column.Item();

                            // Totales generales
                            column.Item().Text($"Total registros: {total}")
                                .FontSize(14).Bold().FontColor(Colors.Blue.Medium);

                            // 2 categorías (porcentajes sobre Aceptados+Rechazados)
                            column.Item().Text($"Aceptados: {aceptados} ({pctAceptados:0.#}% sobre Aceptados+Rechazados)")
                                .FontSize(12).FontColor(Colors.Green.Medium);

                            column.Item().Text($"Rechazados: {rechazados} ({pctRechazados:0.#}% sobre Aceptados+Rechazados)")
                                .FontSize(12).FontColor(Colors.Red.Medium);

                            // Pendientes (informativo, no incluidos en %)
                            column.Item().Text($"Pendientes (no incluidos en %): {pendientes}")
                                .FontSize(12).FontColor(Colors.Orange.Medium);
                        });
                    });
                }).GeneratePdf();

                return Results.File(pdfBytes, "application/pdf", "ReportePedidosAgregacionCategorias.pdf");
            })
            .WithName("ReportePedidosAgregacionCategorias")
            .Produces(StatusCodes.Status200OK)
            .WithOpenApi();
        }
    }
}