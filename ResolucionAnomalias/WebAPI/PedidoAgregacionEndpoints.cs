using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class PedidoAgregacionEndpoints
    {
        public static void MapPedidoAgregacionEndpoints(this WebApplication app)
        {
            app.MapGet("/pedidosAgregacion/{id}", (int id) =>
            {
                PedidoAgregacionService pedidoAgregacionService = new PedidoAgregacionService();

                var dto = pedidoAgregacionService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetPedidosAgregacion")
            .Produces<PedidoAgregacionDTO>(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/pedidosAgregacion", () => {
                PedidoAgregacionService pedidoAgregacionService = new PedidoAgregacionService();
                var dto = pedidoAgregacionService.GetAll();
                return Results.Ok(dto);
            })
            .WithName("GetAllPedidosAgregacion")
            .Produces<List<PedidoAgregacionDTO>>(StatusCodes.Status200OK)
            .WithOpenApi()
            .AllowAnonymous();

            app.MapDelete("/pedidosAgregacion/{id}", (int id) =>
            {
                PedidoAgregacionService pedidoAgregacionService = new PedidoAgregacionService();
                bool rta = pedidoAgregacionService.delete(id);
                if (rta)
                {
                    return Results.Ok();
                }
                else
                {
                    return Results.NotFound();
                }
            })
            .WithName("DeletePedidoAgregacion")
            .Produces(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/pedidosAgregacion", (PedidoAgregacionDTO dto) =>
            {
                try
                {
                    PedidoAgregacionService pedidoAgregacionService = new PedidoAgregacionService();
                    PedidoAgregacionDTO pedidoAgregacionDTO = pedidoAgregacionService.Add(dto);
                    return Results.Created($"/pedidoAgregacion/{pedidoAgregacionDTO.Id_pedido_agreg}", pedidoAgregacionDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddPedidoAgregacion")
            .Produces<PedidoAgregacionDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/pedidosAgregacion", (PedidoAgregacionDTO dto) =>
            {
                try
                {
                    PedidoAgregacionService pedidoAgregacionService = new PedidoAgregacionService();
                    var found = pedidoAgregacionService.Update(dto);

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
            .WithName("UpdatePedidoAgregacion")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}