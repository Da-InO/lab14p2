using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

// ✅ Habilita archivos estáticos desde wwwroot/
app.UseStaticFiles();

app.MapControllers();

app.Run();