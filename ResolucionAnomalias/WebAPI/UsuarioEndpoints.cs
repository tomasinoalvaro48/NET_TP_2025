﻿using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class UsuarioEndpoints
    {
        public static void MapUsuarioEndpoints(this WebApplication app)
        {
            app.MapGet("/usuarios/{id}", (int id) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                UsuarioDTO dto = usuarioService.Get(id);

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

            app.MapGet("/usuarios", () =>
            {
                UsuarioService usuarioService = new UsuarioService();

                var dtos = usuarioService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllUsuarios")
            .Produces<List<UsuarioDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/usuarios", (UsuarioDTO dto) =>
            {
                try
                {
                    UsuarioService usuarioService = new UsuarioService();

                    UsuarioDTO usuarioDTO = usuarioService.Add(dto);

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

            app.MapPut("/usuarios", (UsuarioDTO dto) =>
            {
                try
                {
                    UsuarioService usuarioService = new UsuarioService();

                    var found = usuarioService.Update(dto);

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

            app.MapDelete("/usuarios/{id}", (int id) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                var deleted = usuarioService.Delete(id);

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

            app.MapGet("/usuarios/criteria", (string texto) =>
            {
                UsuarioService usuarioService = new UsuarioService();
                try
                {
                    var criteria = new CriteriaDTO { Texto = texto };
                    var usuarios = usuarioService.GetByCriteria(criteria);
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