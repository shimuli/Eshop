
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// AddTranscient - This service will be created each time it is requested
// AddScoped - This service will be created once per request
// AddSingleton - This service will be created once and shared across all requests

// Registering modules
builder.Services.AddCatelogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCatelogModule()
   .UseBasketModule()
   .UseOrderingModule();


app.Run();