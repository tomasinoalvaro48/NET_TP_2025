using Application.Services;
using Domain.Model;
using DTOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/denunciantes/{id}", (int id) =>
{
    DenuncianteService denuncianteService = new DenuncianteService();

    DenuncianteDTO dto = denuncianteService.Get(id);

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

        return Results.Created($"/denunciantes/{denuncianteDTO.Id}", denuncianteDTO);
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

app.MapDelete("/denunciantes/{id}", (int id) =>
{
    DenuncianteService denuncianteService = new DenuncianteService();

    var deleted = denuncianteService.Delete(id);

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

app.Run();