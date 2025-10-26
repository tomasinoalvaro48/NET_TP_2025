using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class LocalidadEndpoints
    {
        public static void MapLocalidadEndpoints(this WebApplication app)
        {
            app.MapGet("/localidades/{id}", async (int id) =>
            {
                LocalidadService localidadService = new LocalidadService();

                var dto = await localidadService.GetAsync(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetLocalidades")
            .Produces<LocalidadDTO>(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/localidades", async () => {
                LocalidadService localidadService = new LocalidadService();
                var dto = await localidadService.GetAllAsync();
                return Results.Ok(dto);
            })
            .WithName("GetAllLocalidades")
            .Produces<List<LocalidadDTO>>(StatusCodes.Status200OK)
            .WithOpenApi()
            .AllowAnonymous();

            app.MapDelete("/localidades/{id}", async (int id) =>
            {
                LocalidadService localidadService = new LocalidadService();
                bool rta = await localidadService.DeleteAsync(id);
                if (rta)
                {
                    return Results.Ok();
                }
                else
                {
                    return Results.NotFound();
                }
            })
            .WithName("DeleteLocalidad")
            .Produces(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/localidades", async (LocalidadDTO dto) =>
            {
                try
                {
                    LocalidadService localidadService = new LocalidadService();
                    LocalidadDTO localidadDTO = await localidadService.AddAsync(dto);
                    return Results.Created($"/localidad/{localidadDTO.ID}", localidadDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddLocalidad")
            .Produces<LocalidadDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/localidades", async (LocalidadDTO dto) =>
            {
                try
                {
                    LocalidadService localidadService = new LocalidadService();
                    var found = await localidadService.UpdateAsync(dto);

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
            .WithName("UpdateLocalidad")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}