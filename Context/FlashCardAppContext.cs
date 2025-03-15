using FlashCardLearning.Model;
using Microsoft.EntityFrameworkCore;

namespace FlashCardLearning.Context
{
    public class FlashCardAppContext : DbContext
    {
        public DbSet<FlashCard> FlashCards { get; set; }

        public FlashCardAppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlashCard>().ToTable("FlashCard");
            FlashCard[] initialCards = new FlashCard[1000];
            for (int i = 0; i < initialCards.Length; i++)
            {
                initialCards[i] = new FlashCard()
                {
                    Id = Guid.NewGuid(),
                    Description = "a card",
                    Name = "card 1",
                    type = FlashCardType.TextOnly
                };
            }
            modelBuilder.Entity<FlashCard>().HasData(initialCards);
            //modelBuilder.Entity<FlashCard>().HasData(
            //    new FlashCard { Id = new Guid("A8E5D29A-6D67-4C76-8CC7-C444F3E6F5B8"), Description = "a card", Name = "card 1", type = FlashCardType.TextOnly}
            //);
            //modelBuilder.Entity<FlashCard>().HasData(
            //    new FlashCard { Id = new Guid("E363572B-B54B-433D-A001-2E1252C81852"), Description = "a card", Name = "card 2", type = FlashCardType.TextOnly }
            //);
        }
    }
}
