using Application.Services;
using DTOs;


namespace WebAPI
{
    public static class PedidoResolucionEndpoints
    {
        public static void MapPedidoResolucionEndpoints(this WebApplication app)
        {
            app.MapGet("/pedidos_resolucion/{id}", async (int id) =>
            {
                PedidoResolucionService pedidoService = new PedidoResolucionService();

                PedidoResolucionDTO? dto = await pedidoService.GetAsync(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetPedido")
            .Produces<PedidoResolucionDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/pedidos_resolucion", async () =>
            {
                PedidoResolucionService pedidoService = new PedidoResolucionService();

                var dtos = await pedidoService.GetAllAsync();

                return Results.Ok(dtos);
            })
            .WithName("GetAllPedidos")
            .Produces<List<PedidoResolucionDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/pedidos_resolucion", async (PedidoResolucionDTO dto) =>
            {
                try
                {
                    PedidoResolucionService pedidoService = new PedidoResolucionService();

                    PedidoResolucionDTO pedidoDTO = await pedidoService.AddAsync(dto);

                    return Results.Created($"/pedidos_resolucion/{pedidoDTO.Id}", pedidoDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddPedido")
            .Produces<PedidoResolucionDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPatch("/pedidos_resolucion/tomar_pedido", async (PedidoResolucionDTO dto) =>
            {
                try
                {
                    PedidoResolucionService pedidoService = new PedidoResolucionService();

                    var found = await pedidoService.UpdateAsync(dto);

                    if (!found)
                    {
                        return Results.NotFound();
                    }

                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("UpdatePedido")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/pedidos_resolucion/{id}", async (int id) =>
            {
                PedidoResolucionService pedidoService = new PedidoResolucionService();

                var deleted = await pedidoService.DeleteAsync(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeletePedido")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPatch("/pedidos_resolucion/finalizar_pedido/{id}", async (int id) =>             {
                PedidoResolucionService pedidoService = new PedidoResolucionService();
                var updated = await pedidoService.FinalizarPedidoAsync(id);
                if (!updated)
                {
                    return Results.NotFound();
                }
                return Results.NoContent();
            }).
            WithName("FinalizarPedido").
            Produces(StatusCodes.Status204NoContent).
            Produces(StatusCodes.Status404NotFound).
            WithOpenApi();

            app.MapGet("/pedidos_resolucion/pedidos_denunciante/{id}", async (int id) =>
            {
                PedidoResolucionService pedidoService = new PedidoResolucionService();

                var dtos = await pedidoService.GetAllDenunciante(id);

                return Results.Ok(dtos);
            })
            .WithName("GetAllPedidosDenunciante")
            .Produces<List<PedidoResolucionDTO>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();


        }


    }
}
