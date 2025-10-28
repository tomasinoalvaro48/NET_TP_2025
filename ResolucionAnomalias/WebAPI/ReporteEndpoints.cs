using Application.Services;
using DTOs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace WebAPI
{
    public static class ReporteEndpoints
    {
        public static void MapReporteEndpoints(this WebApplication app)
        {
            app.MapGet("/reportes/pedidos_resolucion_mes_actual", async () =>
            {
                PedidoResolucionService pedidoService = new PedidoResolucionService();
                var pedidos = await pedidoService.GetAllAsync();

                var pedidosDelMes = pedidos
                    .Where(p => p.Fecha.Month == DateTime.Now.Month && p.Fecha.Year == DateTime.Now.Year)
                    .ToList();

                var pdfBytes = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(20);

                        page.Content().Column(column =>
                        {
                            column.Item().Text($"Reporte de Pedidos de Resolución - {DateTime.Now:MMMM yyyy}")
                                .FontSize(20)
                                .Bold()
                                .AlignCenter();

                            column.Item().Text($"Cantidad de pedidos realizados: {pedidosDelMes.Count}")
                                .FontSize(16)
                                .Bold();

                            // Opcional: gráfica simple de barras
                            /*
                            column.Item().Canvas((canvas, size) =>
                            {
                                var width = size.Width;
                                var height = 200f;

                                var count = pedidosDelMes.Count;
                                var max = count > 0 ? count : 1;
                                var barHeight = height * count / max;

                                canvas.DrawRect(50, height - barHeight, 50, barHeight, Colors.Blue.Medium);
                            }).Height(200);
                            */
                        });
                    });
                }).GeneratePdf();

                return Results.File(pdfBytes, "application/pdf", "ReportePedidosResolucion.pdf");
            })
            .WithName("ReportePedidosResolucionMesActual")
            .Produces(StatusCodes.Status200OK)
            .WithOpenApi();
        }
    }
}