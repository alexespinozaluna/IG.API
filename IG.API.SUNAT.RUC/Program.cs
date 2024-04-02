using IG.API.SUNAT.RUC.Security;
using IG.API.SUNAT.RUC.Service;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// ...otros servicios
builder.Services.AddScoped<ContribuyenteService>();
builder.Services.AddControllers(options =>
{

});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//// Agregar la inyección de dependencias para el servicio LoginService
//builder.Services.AddScoped<Conexion>(provider =>
//{
//    var configuration = provider.GetRequiredService<IConfiguration>();
//    var connectionString = configuration.GetConnectionString("DefaultConnection");
//    return new Conexion(connectionString);
//});

//BasicAuthentication Personalizado
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthHandler>("BasicAuthentication", null);

//builder.Services.AddScoped<IAuthorizationFilter, CustomAuthorizationFilter>();
var app = builder.Build();

////Filtro de Auntentificacion
//app.UseExceptionHandler(buil =>
//{
//    buil.Run(async context =>
//    {
//        context.Response.StatusCode = 401;
//        context.Response.ContentType = "application/json";

//        await context.Response.WriteAsJsonAsync(new { error = "Unauthorized access 123" });
//    });
//});


// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Auth
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
