using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class DenuncianteEndpoints
    {
        public static void MapDenuncianteEndpoints(this WebApplication app)
        {
            app.MapGet("/denunciantes/{cod_den}", (int cod_den) =>
            {
                DenuncianteService denuncianteService = new DenuncianteService();

                DenuncianteDTO dto = denuncianteService.Get(cod_den);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetDenunciante")
            .Produces<DenuncianteDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/denunciantes", () =>
            {
                DenuncianteService denuncianteService = new DenuncianteService();

                var dtos = denuncianteService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllDenunciantes")
            .Produces<List<DenuncianteDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/denunciantes", (DenuncianteDTO dto) =>
            {
                try
                {
                    DenuncianteService denuncianteService = new DenuncianteService();

                    DenuncianteDTO denuncianteDTO = denuncianteService.Add(dto);

                    return Results.Created($"/denunciantes/{denuncianteDTO.Cod_den}", denuncianteDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddDenunciante")
            .Produces<DenuncianteDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/denunciantes", (DenuncianteDTO dto) =>
            {
                try
                {
                    DenuncianteService denuncianteService = new DenuncianteService();

                    var found = denuncianteService.Update(dto);

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
            .WithName("UpdateDenunciante")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/denunciantes/{cod_den}", (int cod_den) =>
            {
                DenuncianteService denuncianteService = new DenuncianteService();

                var deleted = denuncianteService.Delete(cod_den);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteDenunciante")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}