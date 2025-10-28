using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class UsuarioEndpoints
    {
        public static void MapUsuarioEndpoints(this WebApplication app)
        {
            app.MapGet("/usuarios/{id}", async (int id) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                UsuarioDTO dto = await usuarioService.GetAsync(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetUsuarios")
            .Produces<UsuarioDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/usuarios", async () =>
            {
                UsuarioService usuarioService = new UsuarioService();

                var dtos = await usuarioService.GetAllAsync();

                return Results.Ok(dtos);
            })
            .WithName("GetAllUsuarios")
            .Produces<List<UsuarioDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapGet("/usuarios/email/{email}", async (string email) => { 
                UsuarioService usuarioService = new UsuarioService();

                UsuarioUpdateDTO dto = await usuarioService.GetByEmailAsync(email);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetUsuarioByEmail")
            .Produces<UsuarioUpdateDTO>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/usuarios", async (UsuarioCreateDTO dto) =>
            {
                try
                {
                    UsuarioService usuarioService = new UsuarioService();

                    UsuarioDTO usuarioDTO = await usuarioService.AddAsync(dto);

                    return Results.Created($"/usuarios/{usuarioDTO.Cod_usu}", usuarioDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddUsuario")
            .Produces<UsuarioDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi()
            .AllowAnonymous();

            app.MapPut("/usuarios", async (UsuarioUpdateDTO dto) =>
            {
                try
                {
                    UsuarioService usuarioService = new UsuarioService();

                    var found = await usuarioService.UpdateAsync(dto);

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
            .WithName("UpdateUsuario")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/usuarios/{id}", async (int id) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                var deleted = await usuarioService.DeleteAsync(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }
                return Results.NoContent();
            })
            .WithName("DeleteUsuario")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/usuarios/criteria", async (string texto) =>
            {
                UsuarioService usuarioService = new UsuarioService();
                try
                {
                    var criteria = new CriteriaDTO { Texto = texto };
                    var usuarios = await usuarioService.GetByCriteriaAsync(criteria);
                    return Results.Ok(usuarios);
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("GetUsuariosByCriteria")
            .WithOpenApi();
        }
    }
}