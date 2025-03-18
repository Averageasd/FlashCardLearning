using FlashCardLearning.Context;
using FlashCardLearning.Repositories;
using FlashCardLearning.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FlashCardAppContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("FlashCardDB"));
    }
);
builder.Services.AddScoped<IFlashCardService, FlashCardService>();
builder.Services.AddScoped<IFlashCardRepository, FlashCardRepository>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.DisplayRequestDuration();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
