using Serilog.Events;
using Serilog;
using IG.API.SUNAT.FE.Persistence;
using Microsoft.EntityFrameworkCore;
using IG.API.SUNAT.FE.Repository.Util;
using IG.API.SUNAT.FE.Repository;
using IG.API.SUNAT.FE.Services.Profiles;
using IG.API.SUNAT.FE.Services.Util;
using IG.API.SUNAT.FE.Services;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
    .WriteTo.Console(LogEventLevel.Information)
    .WriteTo.File("..\\log.log", rollingInterval: RollingInterval.Day,
         restrictedToMinimumLevel: LogEventLevel.Warning,
         fileSizeLimitBytes: 4 * 1024)
    .CreateLogger();

builder.Logging.AddSerilog(logger);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<IGAPIFEAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddTransient<IFnDb, FnDb>();
builder.Services.AddTransient<IMaeEmpresaRepo, MaeEmpresaRepo>();
builder.Services.AddTransient<ISUNATFEXMLEspacioNombreTagRepo, SUNATFEXMLEspacioNombreTagRepo>();

builder.Services.AddTransient<IApiEndPointRepo, ApiEndPointRepo>();
builder.Services.AddTransient<IOauthAccessTokenRepo, OauthAccessTokenRepo>();
builder.Services.AddTransient<ISUNAT_FE_ComprobanteRepo, SUNAT_FE_ComprobanteRepo>();

builder.Services.AddTransient<IFEServices, FEServices>();
builder.Services.AddTransient<IApiUtil, ApiUtil>();
builder.Services.AddTransient<IEmpresaService, EmpresaService>();


//Profiles
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<SUNAT_FE_ComprobanteProfile>();
});


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

app.Run();
