using Microsoft.EntityFrameworkCore;
using DSW1_T1_AscencioFloresJamir.Data;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// 1. Cargar variables del .env
Env.Load();

// 2. Construir cadena de conexión desde variables de entorno
var connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                       $"Port={Environment.GetEnvironmentVariable("DB_PORT")};" +
                       $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                       $"User={Environment.GetEnvironmentVariable("DB_USER")};" +
                       $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};";

// 3. Configurar MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// 4. Inyectar el Repositorio
builder.Services.AddScoped<CursosRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.MapControllers();
app.Run();