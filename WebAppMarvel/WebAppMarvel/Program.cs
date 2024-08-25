
using WebAppMarvel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var Startup = new Startup(builder.Configuration);

Startup.ConfigurationServices(builder.Services);



var app = builder.Build();

// Configure the HTTP request pipeline.

Startup.Configure(app, app.Environment);

app.Run();
