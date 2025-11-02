using API.Clients;
using API.Auth.Blazor.Server;
using API.Clients.EntitiesClients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Configurar autenticación
builder.Services.AddSingleton<IAuthService, BlazorServerAuthService>();

// Registrar ApiClients (para @inject)
builder.Services.AddSingleton<PedidoResolucionApiClient>();
builder.Services.AddSingleton<ZonaApiClient>();
builder.Services.AddSingleton<TipoAnomaliaApiClient>();

var app = builder.Build();

// Configurar AuthServiceProvider para ApiClients
var authService = app.Services.GetRequiredService<IAuthService>();
AuthServiceProvider.Register(authService);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();