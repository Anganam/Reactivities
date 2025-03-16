using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
<<<<<<< HEAD
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt => 
{

    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));

=======

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt => {
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(opt => {
    opt.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
    });
>>>>>>> 6ce334a6797b4f2ef72097465f399b338f7f0e59
});

var app = builder.Build();

<<<<<<< HEAD
app.MapControllers();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<AppDbContext>();
    await context.Database.MigrateAsync();
    await DbInitializer.SeedData(context);
=======
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

//using meaning , when done with scope method it will be disposed
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
    await Seed.SeedData(context);
>>>>>>> 6ce334a6797b4f2ef72097465f399b338f7f0e59
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
<<<<<<< HEAD
    logger.LogError(ex, "An error occurred during migration.");
    throw;
=======
    logger.LogError(ex, "An error occured during migration");
    
>>>>>>> 6ce334a6797b4f2ef72097465f399b338f7f0e59
}

app.Run();
