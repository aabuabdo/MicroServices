using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Microsoft.OpenApi.Models;



var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddSwaggerForOcelot(configuration: builder.Configuration);

// Add API explorer for Swagger
builder.Services.AddEndpointsApiExplorer();

// Build the application
var app = builder.Build();

// Use middleware
app.UseSwaggerForOcelotUI(opt =>
{
    opt.PathToSwaggerGenerator = "/swagger/docs";
});

// Run Ocelot middleware
await app.UseOcelot();

// Run the application
app.Run();