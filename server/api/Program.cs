using service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<ProductService>();

builder.Services.AddControllers();

builder.Services.AddOpenApiDocument();

var app = builder.Build();


    app.UseOpenApi();
    app.UseSwaggerUi();

app.MapControllers();

app.UseCors(config =>
{
    config.AllowAnyHeader();
    config.AllowAnyMethod();
    config.AllowAnyOrigin();
});

app.Run();