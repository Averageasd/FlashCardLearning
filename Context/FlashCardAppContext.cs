using FlashCardLearning.Model;
using Microsoft.EntityFrameworkCore;

namespace FlashCardLearning.Context
{
    public class FlashCardAppContext : DbContext
    {
        public DbSet<FlashCardModel> FlashCards { get; set; }
        public DbSet<UserModel> Users { get; set; }

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

            var user1 = new UserModel()
            {
                Id = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
                UserName = "user1",
                Password = "password",
            };

            var user2 = new UserModel()
            {
                Id = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
                UserName = "user2",
                Password = "password",
            };
      
            modelBuilder.Entity<UserModel>().HasData(user1);
            modelBuilder.Entity<UserModel>().HasData(user2);

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 1,
                Answer = "answer",
                Description = "a card",
                Name = "card 1",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 2,
                Answer = "answer",
                Description = "a card",
                Name = "card 2",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 3,
                Answer = "answer",
                Description = "a card",
                Name = "card 3",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 4,
                Answer = "answer",
                Description = "a card",
                Name = "card 4",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 5,
                Answer = "answer",
                Description = "a card",
                Name = "card 5",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 6,
                Answer = "answer",
                Description = "a card",
                Name = "card 6",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 7,
                Answer = "answer",
                Description = "a card",
                Name = "card 7",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 8,
                Answer = "answer",
                Description = "a card",
                Name = "card 8",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 9,
                Answer = "answer",
                Description = "a card",
                Name = "card 9",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 10,
                Answer = "answer",
                Description = "a card",
                Name = "card 10",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 11,
                Answer = "answer",
                Description = "a card",
                Name = "card 11",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 12,
                Answer = "answer",
                Description = "a card",
                Name = "card 12",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 13,
                Answer = "answer",
                Description = "a card",
                Name = "card 13",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 14,
                Answer = "answer",
                Description = "a card",
                Name = "card 14",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 15,
                Answer = "answer",
                Description = "a card",
                Name = "card 15",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 16,
                Answer = "answer",
                Description = "a card",
                Name = "card 16",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 17,
                Answer = "answer",
                Description = "a card",
                Name = "card 17",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 18,
                Answer = "answer",
                Description = "a card",
                Name = "card 18",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 19,
                Answer = "answer",
                Description = "a card",
                Name = "card 19",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 20,
                Answer = "answer",
                Description = "a card",
                Name = "card 20",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("B37DBECD-F91C-4542-B063-E3A8DA855AF0"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 21,
                Answer = "answer",
                Description = "a card",
                Name = "card 21",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 22,
                Answer = "answer",
                Description = "a card",
                Name = "card 22",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 23,
                Answer = "answer",
                Description = "a card",
                Name = "card 23",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 24,
                Answer = "answer",
                Description = "a card",
                Name = "card 24",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });
            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 25,
                Answer = "answer",
                Description = "a card",
                Name = "card 25",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 26,
                Answer = "answer",
                Description = "a card",
                Name = "card 26",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 27,
                Answer = "answer",
                Description = "a card",
                Name = "card 27",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 28,
                Answer = "answer",
                Description = "a card",
                Name = "card 28",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 29,
                Answer = "answer",
                Description = "a card",
                Name = "card 29",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 30,
                Answer = "answer",
                Description = "a card",
                Name = "card 30",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 31,
                Answer = "answer",
                Description = "a card",
                Name = "card 31",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });


            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 32,
                Answer = "answer",
                Description = "a card",
                Name = "card 32",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 33,
                Answer = "answer",
                Description = "a card",
                Name = "card 33",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 34,
                Answer = "answer",
                Description = "a card",
                Name = "card 34",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 35,
                Answer = "answer",
                Description = "a card",
                Name = "card 35",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D")
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 36,
                Answer = "answer",
                Description = "a card",
                Name = "card 36",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 37,
                Answer = "answer",
                Description = "a card",
                Name = "card 37",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 38,
                Answer = "answer",
                Description = "a card",
                Name = "card 38",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 39,
                Answer = "answer",
                Description = "a card",
                Name = "card 39",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });

            modelBuilder.Entity<FlashCardModel>().HasData(new FlashCardModel
            {
                Id = 40,
                Answer = "answer",
                Description = "a card",
                Name = "card 40",
                Type = FlashCardType.Basic,
                CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0),
                UserModelId = Guid.Parse("1107714E-1743-49CE-ABE1-490BDDAA2B4D"),
            });
        }
    }
}
