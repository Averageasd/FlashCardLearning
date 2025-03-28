﻿// <auto-generated />
using System;
using FlashCardLearning.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlashCardLearning.Migrations
{
    [DbContext(typeof(FlashCardAppContext))]
    partial class FlashCardAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FlashCardLearning.Model.FlashCardModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Basic");

                    b.Property<Guid?>("UserModelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("FlashCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 1",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 2,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 2",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 3,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 3",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 4,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 4",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 5,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 5",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 6,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 6",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 7,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 7",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 8,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 8",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 9,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 9",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 10,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 10",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 11,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 11",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 12,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 12",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 13,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 13",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 14,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 14",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 15,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 15",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 16,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 16",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 17,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 17",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 18,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 18",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 19,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 19",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 20,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 20",
                            Type = "Basic",
                            UserModelId = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0")
                        },
                        new
                        {
                            Id = 21,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 21",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 22,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 22",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 23,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 23",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 24,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 24",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 25,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 25",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 26,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 26",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 27,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 27",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 28,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 28",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 29,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 29",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 30,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 30",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 31,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 31",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 32,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 32",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 33,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 33",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 34,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 34",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 35,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 35",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 36,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 36",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 37,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 37",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 38,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 38",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 39,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 39",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        },
                        new
                        {
                            Id = 40,
                            Answer = "answer",
                            CreatedDate = new DateTime(2025, 3, 18, 1, 1, 0, 0, DateTimeKind.Unspecified),
                            Description = "a card",
                            Name = "card 40",
                            Type = "Basic",
                            UserModelId = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d")
                        });
                });

            modelBuilder.Entity("FlashCardLearning.Model.UserModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b37dbecd-f91c-4542-b063-e3a8da855af0"),
                            Password = "password",
                            UserName = "user1"
                        },
                        new
                        {
                            Id = new Guid("1107714e-1743-49ce-abe1-490bddaa2b4d"),
                            Password = "password",
                            UserName = "user2"
                        });
                });

            modelBuilder.Entity("FlashCardLearning.Model.FlashCardModel", b =>
                {
                    b.HasOne("FlashCardLearning.Model.UserModel", "UserModel")
                        .WithMany("FlashCardModels")
                        .HasForeignKey("UserModelId");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("FlashCardLearning.Model.UserModel", b =>
                {
                    b.Navigation("FlashCardModels");
                });
#pragma warning restore 612, 618
        }
    }
}
