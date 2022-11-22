﻿// <auto-generated />
using GameStore.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameStore.Api.Migrations
{
    [DbContext(typeof(GameStoreDbContext))]
    partial class GameStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameStore.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("GameStore.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("GameStore.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "First Person Shooter developed by Activision.",
                            ImageURL = "",
                            Name = "Call Of Duty : Modern Warfare 2",
                            Price = 59.99m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Single or multiplayer ghost hunting game that'll scare the pants off of you.",
                            ImageURL = "",
                            Name = "Phasmophobia",
                            Price = 29.99m,
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A breathtaking open world zelda adventure you have never experienced before.",
                            ImageURL = "",
                            Name = "The Legend Of Zelda : Breath Of The Wild",
                            Price = 19.99m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Survival horror set in space where no one can hear your screams.",
                            ImageURL = "",
                            Name = "Dead Space 2",
                            Price = 29.99m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "From software's latest and greates epic to challenge the wits and patients of all players.",
                            ImageURL = "",
                            Name = "Elden Ring",
                            Price = 59.99m,
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "The latest console from Microsoft.",
                            ImageURL = "",
                            Name = "Xbox Series X",
                            Price = 499.99m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "The latest console from Sony.",
                            ImageURL = "",
                            Name = "Play Station 5",
                            Price = 499.99m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "The latest console from Nintendo",
                            ImageURL = "",
                            Name = "Nintendo Switch",
                            Price = 299.99m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Classic console provided by Nintendo.",
                            ImageURL = "",
                            Name = "Nintendo 64",
                            Price = 99.99m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Reveloutionary product for its time provided by SEGA.",
                            ImageURL = "",
                            Name = "Sega Dreamcast",
                            Price = 99.99m,
                            Qty = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Provided by Nintendo",
                            ImageURL = "",
                            Name = "Nintendo Gameboy Advanced",
                            Price = 49.99m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Izuku Midoria from the popular anime 'My Hero Academia'.",
                            ImageURL = "",
                            Name = "Izuku Midoria Figure",
                            Price = 49.99m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Pour your coffee in and watch the Z fighters come to life.",
                            ImageURL = "",
                            Name = "Dragonball Z Heat Activated Mug",
                            Price = 19.99m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Naruto Uzumaki from the popular anime 'Naruto : Shippuden' with the nine tailed fox.",
                            ImageURL = "",
                            Name = "Naruto Uzumaki w/ Kurama Figure",
                            Price = 49.99m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Jumbo fig pin from Funko of Asta and the demon destroyer sword from the popular anime 'Black Clover'",
                            ImageURL = "",
                            Name = "Asta Jumbo Fig Pin",
                            Price = 12.99m,
                            Qty = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "Figure of Himiko Toga from the popular anime 'My Hero Academia'.",
                            ImageURL = "",
                            Name = "Himiko Toga Figure",
                            Price = 24.99m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Wear this wonderful hat that sparks imagination as you adventure with the best starter pokemon from popular anime 'Pokemon'.",
                            ImageURL = "",
                            Name = "Charmander Hat",
                            Price = 19.99m,
                            Qty = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Replacement power source for the Xbox Series X.",
                            ImageURL = "",
                            Name = "Power Adapter (Xbox Series X)",
                            Price = 19.99m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Replacement power source for the Playstation 5.",
                            ImageURL = "",
                            Name = "Power Adapter (Playstation 5)",
                            Price = 19.99m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Take the Competition to the opponents with this elite controller.",
                            ImageURL = "",
                            Name = "Pro Controller (series 2) Xbox Series X",
                            Price = 149.99m,
                            Qty = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Set of two joy cons for the Nintendo Switch.",
                            ImageURL = "",
                            Name = "Joy Cons (red and blue) Nintendo Switch",
                            Price = 79.99m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Fall into the world of zelda with this carrying case for your switch.",
                            ImageURL = "",
                            Name = "Nintendo Switch Carrying Case (Legend Of Zelda)",
                            Price = 34.99m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Put yourself in the game with these headphone to hear the competition better than ever.",
                            ImageURL = "",
                            Name = "Steele Series Arctis 9X",
                            Price = 149.99m,
                            Qty = 150
                        });
                });

            modelBuilder.Entity("GameStore.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Games"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Collectibles"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Consoles"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Accessories"
                        });
                });

            modelBuilder.Entity("GameStore.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Sarah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}