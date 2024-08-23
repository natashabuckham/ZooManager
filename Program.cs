using Microsoft.EntityFrameworkCore;
using ZooManager;
using Microsoft.OpenApi.Models;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ZooManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ZooManager API",
        Description = "An ASP.NET Core Web API for managing Zoo animals",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});

builder.Services.AddControllers();
builder.Services.AddDbContext<ZooManagerDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("ZooManagerDbContext"));
    options.UseSqlite("Data Source=zoomanager.db");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello, World!");

static void CreateDbIfNotExists(IHost host)
{
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ZooManagerDbContext>();
    context.Database.EnsureCreated();

    if (!context.AnimalTypes.Any())
    {
        var animalTypes = SampleAnimalTypes.GetAnimalTypes();
        context.AnimalTypes.AddRange(animalTypes);
        context.SaveChanges();

        var animals = SampleAnimals.GetAnimals();
        context.Animals.AddRange(animals);
        context.SaveChanges();
    }
}

CreateDbIfNotExists(app);

app.Run();