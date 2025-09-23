using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class TipoAnomaliaEndpoints
    {
        public static void MapTipoAnomaliaEndpoints(this WebApplication app)
        {
            app.MapGet("/tipoanomalia/{cod_tipo}", (int cod_tipo) =>
            {

                TipoAnomaliaService tipoService = new TipoAnomaliaService();

                TipoAnomaliaDTO dto = tipoService.Get(cod_tipo);

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

            app.MapGet("/tipoanomalia", () =>
            {
                TipoAnomaliaService tipoService = new TipoAnomaliaService();

                var dtos = tipoService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllTipoAnomalia")
            .Produces<List<TipoAnomaliaDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/tipoanomalia", (TipoAnomaliaDTO dto) =>
            {
                try
                {
                    TipoAnomaliaService tipoService = new TipoAnomaliaService();

                    TipoAnomaliaDTO tipoDTO = tipoService.Add(dto);

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

            app.MapPut("/tipoanomalia", (TipoAnomaliaDTO dto) =>
            {
                try
                {
                    TipoAnomaliaService tipoService = new TipoAnomaliaService();

                    var found = tipoService.Update(dto);

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

            app.MapDelete("/tipoanomalia/{cod_tipo}", (int cod_tipo) =>
            {
                TipoAnomaliaService tipoService = new TipoAnomaliaService();

                var deleted = tipoService.Delete(cod_tipo);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteTipoAnomalia")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}