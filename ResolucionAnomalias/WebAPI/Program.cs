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

//--------------------- Denucniante --------------------

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


//--------------------- Localidad --------------------

app.MapGet("/localidades/{id}", (int id) =>
{
    LocalidadService localidadService = new LocalidadService();

    var dto = localidadService.Get(id);

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

app.MapGet("/localidades", () => {
    LocalidadService localidadService = new LocalidadService();
    var dto = localidadService.GetAll();
    return Results.Ok(dto);
} )
.WithName("GetAllLocalidades")
.Produces<List<LocalidadDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapDelete("/localidades/{id}", (int id) =>
{
    LocalidadService localidadService = new LocalidadService();
    bool rta = localidadService.delete(id);
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

app.MapPost("/localidades", (LocalidadDTO dto) =>
{
    try
    {
        LocalidadService localidadService = new LocalidadService();
        LocalidadDTO localidadDTO = localidadService.Add(dto);
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

app.MapPut("/localidades", (LocalidadDTO dto)=>
{
    try
    {
        LocalidadService localidadService = new LocalidadService();
        var found = localidadService.Update(dto);

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



//---------------- Tipo de Anomalia -------------------
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


//--------------------- Run app --------------------

app.Run();