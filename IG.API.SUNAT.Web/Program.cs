using Blazored.SessionStorage;
using CurrieTechnologies.Razor.SweetAlert2;
using IG.API.SUNAT.FE.Persistence;
using IG.API.SUNAT.FE.Repository;
using IG.API.SUNAT.FE.Repository.Util;
using IG.API.SUNAT.FE.Services;
using IG.API.SUNAT.FE.Services.Profiles;
using IG.API.SUNAT.FE.Services.Util;
using IG.API.SUNAT.Web.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
    .WriteTo.Console(LogEventLevel.Information)
    .WriteTo.File("..\\log.log", rollingInterval: RollingInterval.Day,
         restrictedToMinimumLevel: LogEventLevel.Warning,
         fileSizeLimitBytes: 4 * 1024)
    .CreateLogger();

builder.Logging.AddSerilog(logger);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<IGAPIFEAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#region INYECION_DEPENDECIA
builder.Services.AddTransient<IFnDb, FnDb>();
builder.Services.AddTransient<IMaeEmpresaRepo, MaeEmpresaRepo>();
builder.Services.AddTransient<ISUNATFEXMLEspacioNombreTagRepo, SUNATFEXMLEspacioNombreTagRepo>();

builder.Services.AddTransient<IApiEndPointRepo, ApiEndPointRepo>();
builder.Services.AddTransient<IOauthAccessTokenRepo, OauthAccessTokenRepo>();
builder.Services.AddTransient<ISUNAT_FE_ComprobanteRepo, SUNAT_FE_ComprobanteRepo>();
builder.Services.AddTransient<ISistemaUsuarioRepo, SistemaUsuarioRepo>();
builder.Services.AddTransient<IEmailConfigRepo, EmailConfigRepo>();
builder.Services.AddTransient<ItdHTMLRepo, tdHTMLRepo>();


builder.Services.AddTransient<IApiUtil, ApiUtil>();
builder.Services.AddTransient<IEmailService, EmailService>();


builder.Services.AddTransient<IFEServices, FEServices>();
builder.Services.AddTransient<IEmpresaService, EmpresaService>();
builder.Services.AddTransient<ISistemaUsuarioService, SistemaUsuarioService>();
builder.Services.AddTransient<ISUNAT_FE_ComprobanteService, SUNAT_FE_ComprobanteService>();
builder.Services.AddTransient<IEmailConfigService, EmailConfigService>();
builder.Services.AddTransient<ItdHTMLService, tdHTMLService>();


#endregion INYECION_DEPENDECIA

//Profiles
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<SUNAT_FE_ComprobanteProfile>();

});

builder.Services.AddSweetAlert2();


//Para auth

builder.Services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacion>();
builder.Services.AddScoped<ProveedorAutenticacion>(provider => (ProveedorAutenticacion)provider.GetRequiredService<AuthenticationStateProvider>());
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddAuthenticationCore();

// Registrar Blazored Session Storage
builder.Services.AddBlazoredSessionStorage();

// Register authorization services
builder.Services.AddAuthorizationCore();

var app = builder.Build();

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
