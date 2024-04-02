using IG.API.SUNAT.FE.Persistence;
using IG.API.SUNAT.FE.Repository;
using IG.API.SUNAT.FE.Repository.Util;
using IG.API.SUNAT.FE.Services;
using IG.API.SUNAT.FE.Services.Profiles;
using IG.API.SUNAT.FE.Services.Util;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<IGAPIFEAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//builder.Services.AddTransient<IConexion, Conexion>(provider =>
//{
//    var configuration = provider.GetRequiredService<IConfiguration>();
//    var connectionString = configuration.GetConnectionString("DefaultConnection");
//    return new Conexion(connectionString);
//});
//builder.Services.AddTransient<IFn, Fn>();
//builder.Services.AddTransient<ISQLDataRepo,SQLDataRepo>();

//builder.Services.AddTransient<ISQLDataService, SQLDataService>();


builder.Services.AddTransient<IFnDb, FnDb>();
builder.Services.AddTransient<IMaeEmpresaRepo, MaeEmpresaRepo>();
builder.Services.AddTransient<ISUNATFEXMLEspacioNombreTagRepo, SUNATFEXMLEspacioNombreTagRepo>();

builder.Services.AddTransient<IApiEndPointRepo, ApiEndPointRepo>();
builder.Services.AddTransient<IOauthAccessTokenRepo, OauthAccessTokenRepo>();
builder.Services.AddTransient<ISUNAT_FE_ComprobanteRepo, SUNAT_FE_ComprobanteRepo>();

builder.Services.AddTransient<IFEServices, FEServices>();
builder.Services.AddTransient<IApiUtil, ApiUtil>();

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
