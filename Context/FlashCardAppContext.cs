using FlashCardLearning.Model;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace FlashCardLearning.Context
{
    public class FlashCardAppContext : DbContext
    {
        public DbSet<FlashCardModel> FlashCards { get; set; }

        public FlashCardAppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FlashCardModel>()
            .Property(e => e.Id)
            .UseIdentityColumn(seed: 1, increment: 1)
            .ValueGeneratedOnAdd();
            

            modelBuilder.Entity<FlashCardModel>()
            .Property(e => e.Type)
            .HasDefaultValue(FlashCardType.Basic);

            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel {Id = 1, Answer = "answer", Description = "a card", Name = "card 1", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1,1,0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel {Id = 2, Answer = "answer", Description = "a card", Name = "card 2", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 3, Answer = "answer", Description = "a card", Name = "card 3", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 4, Answer = "answer", Description = "a card", Name = "card 4", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel{ Id = 5, Answer = "answer", Description = "a card", Name = "card 5", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 6, Answer = "answer", Description = "a card", Name = "card 6", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 7, Answer = "answer", Description = "a card", Name = "card 7", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 8, Answer = "answer", Description = "a card", Name = "card 8", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 9, Answer = "answer", Description = "a card", Name = "card 9", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 10, Answer = "answer", Description = "a card", Name = "card 10", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 11, Answer = "answer", Description = "a card", Name = "card 11", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 12, Answer = "answer", Description = "a card", Name = "card 12", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 13, Answer = "answer", Description = "a card", Name = "card 13", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 14, Answer = "answer", Description = "a card", Name = "card 14", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 15, Answer = "answer", Description = "a card", Name = "card 15", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            ); 
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 16, Answer = "answer", Description = "a card", Name = "card 16", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 17, Answer = "answer", Description = "a card", Name = "card 17", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 18, Answer = "answer", Description = "a card", Name = "card 18", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 19, Answer = "answer", Description = "a card", Name = "card 19", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 20, Answer = "answer", Description = "a card", Name = "card 20", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
        }
    }
}
