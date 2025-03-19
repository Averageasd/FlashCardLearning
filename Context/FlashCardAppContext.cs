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
            modelBuilder.Entity<FlashCardModel>()
            .Property(e => e.Id)
            .UseIdentityColumn(seed: 1, increment: 1)
            .ValueGeneratedOnAdd();
            

            modelBuilder.Entity<FlashCardModel>()
            .Property(e => e.Type)
            .HasDefaultValue(FlashCardType.Basic);

            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel {Id = 1, Description = "a card", Name = "card 1", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1,1,0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel {Id = 2, Description = "a card", Name = "card 2", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 3, Description = "a card", Name = "card 3", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 4, Description = "a card", Name = "card 4", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel{ Id = 5, Description = "a card", Name = "card 5", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 6, Description = "a card", Name = "card 6", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 7, Description = "a card", Name = "card 7", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 8, Description = "a card", Name = "card 8", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 9, Description = "a card", Name = "card 9", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 10, Description = "a card", Name = "card 10", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 11, Description = "a card", Name = "card 11", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 12, Description = "a card", Name = "card 12", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 13, Description = "a card", Name = "card 13", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 14, Description = "a card", Name = "card 14", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 15, Description = "a card", Name = "card 15", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            ); 
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 16, Description = "a card", Name = "card 16", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 17, Description = "a card", Name = "card 17", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 18, Description = "a card", Name = "card 18", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 19, Description = "a card", Name = "card 19", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
            modelBuilder.Entity<FlashCardModel>().HasData(
                new FlashCardModel { Id = 20, Description = "a card", Name = "card 20", Type = FlashCardType.Basic, CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0) }
            );
        }
    }
}
