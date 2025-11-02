using Application.Services;
using Data;
using DTOs;

namespace WebAPI
{
    public static class TipoAnomaliaEndpoints
    {
        public static void MapTipoAnomaliaEndpoints(this WebApplication app)
        {
            app.MapGet("/tipoanomalia/{cod_tipo}", async (int cod_tipo) =>
            {
                TipoAnomaliaService tipoService = new TipoAnomaliaService();

                TipoAnomaliaDTO dto = await tipoService.GetAsync(cod_tipo);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetTipoAnomalia")
            .Produces<TipoAnomaliaDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/tipoanomalia", async () =>
            {
                TipoAnomaliaService tipoService = new TipoAnomaliaService();

                var dtos = await tipoService.GetAllAsync();

                return Results.Ok(dtos);
            })
            .WithName("GetAllTipoAnomalia")
            .Produces<List<TipoAnomaliaDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/tipoanomalia", async (TipoAnomaliaDTO dto) =>
            {
                try
                {
                    TipoAnomaliaService tipoService = new TipoAnomaliaService();

                    TipoAnomaliaDTO tipoDTO = await tipoService.AddAsync(dto);

                    return Results.Created($"/tipoanomalia/{tipoDTO.Cod_anom}", tipoDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddTipoAnomalia")
            .Produces<TipoAnomaliaDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/tipoanomalia", async (TipoAnomaliaDTO dto) =>
            {
                try
                {
                    TipoAnomaliaService tipoService = new TipoAnomaliaService();

                    var found = await tipoService.UpdateAsync(dto);

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
            .WithName("UpdateTipoAnomalia")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/tipoanomalia/{cod_tipo}", async (int cod_tipo) =>
            {
                try
                {
                    TipoAnomaliaService tipoService = new TipoAnomaliaService();

                    var repo = new PedidoAgregacionRepository();
                    bool estaRelacionado = await repo.ExisteTipoAnomaliaEnPedidos(cod_tipo);

                    if (estaRelacionado)
                    {
                        return Results.BadRequest(new
                        {
                            message = "No se puede eliminar el Tipo de Anomalía porque está asignado a uno o más pedidos."
                        });
                    }

                    var deleted = await tipoService.DeleteAsync(cod_tipo);

                    if (!deleted)
                    {
                        return Results.NotFound();
                    }

                    return Results.NoContent();
                }
                catch (Exception ex)
                {
                    return Results.Problem($"Error al eliminar: {ex.Message}");
                }
            })
            .WithName("DeleteTipoAnomalia")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}