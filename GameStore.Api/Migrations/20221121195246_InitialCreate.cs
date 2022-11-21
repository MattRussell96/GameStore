using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStore.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Games" },
                    { 2, "Collectibles" },
                    { 3, "Consoles" },
                    { 4, "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "First Person Shooter developed by Activision.", "", "Call Of Duty : Modern Warfare 2", 59.99m, 100 },
                    { 2, 1, "Single or multiplayer ghost hunting game that'll scare the pants off of you.", "", "Phasmophobia", 29.99m, 45 },
                    { 3, 1, "A breathtaking open world zelda adventure you have never experienced before.", "", "The Legend Of Zelda : Breath Of The Wild", 19.99m, 30 },
                    { 4, 1, "Survival horror set in space where no one can hear your screams.", "", "Dead Space 2", 29.99m, 60 },
                    { 5, 1, "From software's latest and greates epic to challenge the wits and patients of all players.", "", "Elden Ring", 59.99m, 85 },
                    { 6, 3, "The latest console from Microsoft.", "", "Xbox Series X", 499.99m, 120 },
                    { 7, 3, "The latest console from Sony.", "", "Play Station 5", 499.99m, 200 },
                    { 8, 3, "The latest console from Nintendo", "", "Nintendo Switch", 299.99m, 200 },
                    { 9, 3, "Classic console provided by Nintendo.", "", "Nintendo 64", 99.99m, 20 },
                    { 10, 3, "Reveloutionary product for its time provided by SEGA.", "", "Sega Dreamcast", 99.99m, 15 },
                    { 11, 3, "Provided by Nintendo", "", "Nintendo Gameboy Advanced", 49.99m, 60 },
                    { 12, 2, "Izuku Midoria from the popular anime 'My Hero Academia'.", "", "Izuku Midoria Figure", 49.99m, 212 },
                    { 13, 2, "Pour your coffee in and watch the Z fighters come to life.", "", "Dragonball Z Heat Activated Mug", 19.99m, 112 },
                    { 14, 2, "Naruto Uzumaki from the popular anime 'Naruto : Shippuden' with the nine tailed fox.", "", "Naruto Uzumaki w/ Kurama Figure", 49.99m, 90 },
                    { 15, 2, "Jumbo fig pin from Funko of Asta and the demon destroyer sword from the popular anime 'Black Clover'", "", "Asta Jumbo Fig Pin", 12.99m, 95 },
                    { 16, 2, "Figure of Himiko Toga from the popular anime 'My Hero Academia'.", "", "Himiko Toga Figure", 24.99m, 100 },
                    { 17, 2, "Wear this wonderful hat that sparks imagination as you adventure with the best starter pokemon from popular anime 'Pokemon'.", "", "Charmander Hat", 19.99m, 73 },
                    { 18, 4, "Replacement power source for the Xbox Series X.", "", "Power Adapter (Xbox Series X)", 19.99m, 50 },
                    { 19, 4, "Replacement power source for the Playstation 5.", "", "Power Adapter (Playstation 5)", 19.99m, 60 },
                    { 20, 4, "Take the Competition to the opponents with this elite controller.", "", "Pro Controller (series 2) Xbox Series X", 149.99m, 70 },
                    { 21, 4, "Set of two joy cons for the Nintendo Switch.", "", "Joy Cons (red and blue) Nintendo Switch", 79.99m, 120 },
                    { 22, 4, "Fall into the world of zelda with this carrying case for your switch.", "", "Nintendo Switch Carrying Case (Legend Of Zelda)", 34.99m, 100 },
                    { 23, 4, "Put yourself in the game with these headphone to hear the competition better than ever.", "", "Steele Series Arctis 9X", 149.99m, 150 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Bob" },
                    { 2, "Sarah" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
