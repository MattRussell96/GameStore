using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data
{
    public class GameStoreDbContext : DbContext
    {
        public GameStoreDbContext(DbContextOptions<GameStoreDbContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			//Products
			//Games Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "Call Of Duty : Modern Warfare 2",
				Description = "First Person Shooter developed by Activision.",
				ImageURL = "",
				Price = 59.99M,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "Phasmophobia",
				Description = "Single or multiplayer ghost hunting game that'll scare the pants off of you.",
				ImageURL = "",
				Price = 29.99M,
				Qty = 45,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "The Legend Of Zelda : Breath Of The Wild",
				Description = "A breathtaking open world zelda adventure you have never experienced before.",
				ImageURL = "",
				Price = 19.99M,
				Qty = 30,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Dead Space 2",
				Description = "Survival horror set in space where no one can hear your screams.",
				ImageURL = "",
				Price = 29.99M,
				Qty = 60,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = "Elden Ring",
				Description = "From software's latest and greates epic to challenge the wits and patients of all players.",
				ImageURL = "",
				Price = 59.99M,
				Qty = 85,
				CategoryId = 1

			});
			//Consoles Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "Xbox Series X",
				Description = "The latest console from Microsoft.",
				ImageURL = "",
				Price = 499.99M,
				Qty = 120,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "Play Station 5",
				Description = "The latest console from Sony.",
				ImageURL = "",
				Price = 499.99M,
				Qty = 200,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "Nintendo Switch",
				Description = "The latest console from Nintendo",
				ImageURL = "",
				Price = 299.99M,
				Qty = 200,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 9,
				Name = "Nintendo 64",
				Description = "Classic console provided by Nintendo.",
				ImageURL = "",
				Price = 99.99M,
				Qty = 20,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 10,
				Name = "Sega Dreamcast",
				Description = "Reveloutionary product for its time provided by SEGA.",
				ImageURL = "",
				Price = 99.99M,
				Qty = 15,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 11,
				Name = "Nintendo Gameboy Advanced",
				Description = "Provided by Nintendo",
				ImageURL = "",
				Price = 49.99M,
				Qty = 60,
				CategoryId = 3
			});
			//Collectibles Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 12,
				Name = "Izuku Midoria Figure",
				Description = "Izuku Midoria from the popular anime 'My Hero Academia'.",
				ImageURL = "",
				Price = 49.99M,
				Qty = 212,
				CategoryId = 2
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 13,
				Name = "Dragonball Z Heat Activated Mug",
				Description = "Pour your coffee in and watch the Z fighters come to life.",
				ImageURL = "",
				Price = 19.99M,
				Qty = 112,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 14,
				Name = "Naruto Uzumaki w/ Kurama Figure",
				Description = "Naruto Uzumaki from the popular anime 'Naruto : Shippuden' with the nine tailed fox.",
				ImageURL = "",
				Price = 49.99M,
				Qty = 90,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 15,
				Name = "Asta Jumbo Fig Pin",
				Description = "Jumbo fig pin from Funko of Asta and the demon destroyer sword from the popular anime 'Black Clover'",
				ImageURL = "",
				Price = 12.99M,
				Qty = 95,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 16,
				Name = "Himiko Toga Figure",
				Description = "Figure of Himiko Toga from the popular anime 'My Hero Academia'.",
				ImageURL = "",
				Price = 24.99M,
				Qty = 100,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 17,
				Name = "Charmander Hat",
				Description = "Wear this wonderful hat that sparks imagination as you adventure with the best starter pokemon from popular anime 'Pokemon'.",
				ImageURL = "",
				Price = 19.99M,
				Qty = 73,
				CategoryId = 2
			});
			//Accessories Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 18,
				Name = "Power Adapter (Xbox Series X)",
				Description = "Replacement power source for the Xbox Series X.",
				ImageURL = "",
				Price = 19.99M,
				Qty = 50,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 19,
				Name = "Power Adapter (Playstation 5)",
				Description = "Replacement power source for the Playstation 5.",
				ImageURL = "",
				Price = 19.99M,
				Qty = 60,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 20,
				Name = "Pro Controller (series 2) Xbox Series X",
				Description = "Take the Competition to the opponents with this elite controller.",
				ImageURL = "",
				Price = 149.99M,
				Qty = 70,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 21,
				Name = "Joy Cons (red and blue) Nintendo Switch",
				Description = "Set of two joy cons for the Nintendo Switch.",
				ImageURL = "",
				Price = 79.99M,
				Qty = 120,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 22,
				Name = "Nintendo Switch Carrying Case (Legend Of Zelda)",
				Description = "Fall into the world of zelda with this carrying case for your switch.",
				ImageURL = "",
				Price = 34.99M,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 23,
				Name = "Steele Series Arctis 9X",
				Description = "Put yourself in the game with these headphone to hear the competition better than ever.",
				ImageURL = "",
				Price = 149.99M,
				Qty = 150,
				CategoryId = 4
			});

			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Bob"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Sarah"

			});

			//Create Shopping Cart for Users
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 1,
				UserId = 1

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 2,
				UserId = 2

			});
			//Add Product Categories
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Games"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Collectibles"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 3,
				Name = "Consoles"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 4,
				Name = "Accessories"
			});
		}

		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<User> Users { get; set; }
    }
}
