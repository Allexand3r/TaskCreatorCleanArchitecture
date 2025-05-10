using Application;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccses(builder.Configuration);
builder.Services.AddBusinessLogic();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.Migrate();
}


app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();