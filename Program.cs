using FlashCardLearning.Context;
using FlashCardLearning.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FlashCardAppContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("FlashCardDB"));
    }
);

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

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<FlashCardAppContext>();
    await dbContext.Database.EnsureDeletedAsync();
    await dbContext.Database.EnsureCreatedAsync();
    FlashCard[] initialCards = new FlashCard[10000];
    for (int i = 0; i < initialCards.Length; i++)
    {
        initialCards[i] = new FlashCard()
        {
            Id = Guid.NewGuid(),
            Description = $"description for card {i}",
            Name = $"card {i}",
            type = FlashCardType.TextOnly
        };
    }
    await dbContext.AddRangeAsync(initialCards);
    await dbContext.SaveChangesAsync(); 

    
}

app.Run();
