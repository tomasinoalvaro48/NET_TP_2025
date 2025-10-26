using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class ZonaEndpoints
    {
        public static void MapZonaEndpoints(this WebApplication app)
        {
            app.MapGet("/zonas/{id}", async (int id) =>
            {
                ZonaService zonaService = new ZonaService();
                ZonaDTO dto = await zonaService.GetAsync(id);
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


            app.MapGet("/zonas", async () =>
            {
                ZonaService zonaService = new ZonaService();
                var dtos = await zonaService.GetAllAsync();

                return Results.Ok(dtos);
            })
            .WithName("GetAllZonas")
            .Produces<List<ZonaDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();


            // Get Zonas by Localidad
            app.MapGet("/zonas/localidad/{id_loc}", async (int id_loc) =>
            {
                ZonaService zonaService = new ZonaService();
                var dtos = await zonaService.GetByLocalidadAsync(id_loc);

                return Results.Ok(dtos);
            })
            .WithName("GetZonasLoc")
            .Produces<ZonaDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi()
            .AllowAnonymous();


            app.MapPost("/zonas", async (ZonaDTO dto) =>
            {
                try
                {
                    ZonaService zonaService = new ZonaService();
                    ZonaDTO zonaDTO = await zonaService.AddAsync(dto);

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


            app.MapPut("/zonas", async (ZonaDTO dto) =>
            {
                try
                {
                    ZonaService zonaService = new ZonaService();
                    var found = await zonaService.UpdateAsync(dto);
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


            app.MapDelete("/zonas/{id}", async (int id) =>
            {
                ZonaService zonaService = new ZonaService();
                var deleted = await zonaService.DeleteAsync(id);
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