using DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Transient service: New instance created each time it's requested.
builder.Services.AddTransient<INumGenerator, NumGenerator>();

// Scoped service: Same instance within a single HTTP request.
//builder.Services.AddScoped<INumGenerator, NumGenerator>();

// Singleton service: A single instance shared throughout the application.
//builder.Services.AddSingleton<INumGenerator, NumGenerator>();

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
