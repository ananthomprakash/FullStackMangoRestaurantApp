using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

//Add config file
//builder.Configuration.AddJsonFile("ocelot.json");

// Add services to the container.
builder.Services.AddOcelot();

var app = builder.Build();

app.UseOcelot().Wait();

app.Run();
