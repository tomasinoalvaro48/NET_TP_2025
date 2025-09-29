using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class ZonaEndpoints
    {
        public static void MapZonaEndpoints(this WebApplication app)
        {
            app.MapGet("/zonas/{id}", (int id) =>
            {
                ZonaService zonaService = new ZonaService();

                ZonaDTO dto = zonaService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetZonas")
            .Produces<ZonaDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/zonas", () =>
            {
                ZonaService zonaService = new ZonaService();

                var dtos = zonaService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllZonas")
            .Produces<List<ZonaDTO>>(StatusCodes.Status200OK)
            .WithOpenApi()
            .AllowAnonymous();

            app.MapPost("/zonas", (ZonaDTO dto) =>
            {
                try
                {
                    ZonaService zonaService = new ZonaService();

                    ZonaDTO zonaDTO = zonaService.Add(dto);

                    return Results.Created($"/zonas/{zonaDTO.Id}", zonaDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddZona")
            .Produces<ZonaDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/zonas", (ZonaDTO dto) =>
            {
                try
                {
                    ZonaService zonaService = new ZonaService();

                    var found = zonaService.Update(dto);

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
            .WithName("UpdateZona")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/zonas/{id}", (int id) =>
            {
                ZonaService zonaService = new ZonaService();

                var deleted = zonaService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }
                return Results.NoContent();
            })
            .WithName("DeleteZona")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}