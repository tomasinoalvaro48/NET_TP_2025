using WebAPI;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddHttpLogging(o => { });

// Add JWT Authentication
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings["SecretKey"];
var issuer = jwtSettings["Issuer"];
var audience = jwtSettings["Audience"];

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = issuer,
            ValidateAudience = true,
            ValidAudience = audience,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!)),
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddAuthorization(options =>
{
    /*options.AddPolicy("LocalidadesLeer", policy => policy.RequireClaim("permission", "localidades.leer"));
    options.AddPolicy("LocalidadesAgregar", policy => policy.RequireClaim("permission", "localidades.agregar"));
    options.AddPolicy("LocalidadesActualizar", policy => policy.RequireClaim("permission", "localidades.actualizar"));
    options.AddPolicy("LocalidadesEliminar", policy => policy.RequireClaim("permission", "localidades.eliminar"));*/

    options.FallbackPolicy = options.DefaultPolicy;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();

app.MapAuthEndpoints();
app.MapTipoAnomaliaEndpoints();
app.MapLocalidadEndpoints();
app.MapZonaEndpoints();
app.MapUsuarioEndpoints();
app.MapPedidoResolucionEndpoints();
app.MapPedidoAgregacionEndpoints();

//--------------------- Run app --------------------

app.Run();