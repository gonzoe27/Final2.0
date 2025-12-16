using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZoeNBellaLibary2._0.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Book_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Book_Name = table.Column<string>(type: "TEXT", nullable: false),
                    Book_Description = table.Column<string>(type: "TEXT", nullable: false),
                    Book_Author = table.Column<string>(type: "TEXT", nullable: false),
                    Bought_Price = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageFileNmae = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Book_ID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Book_ID", "Book_Author", "Book_Description", "Book_Name", "Bought_Price", "ImageFileNmae", "Rating" },
                values: new object[,]
                {
                    { 1, "Suzanne Collins", "A novel written by American author Suzanne Collins that follows a cast of characters living in the fictional districts of Panem.", "Hunger Games", 10, "/images/hungergames.jpg", 10 },
                    { 2, "Suzanne Collins", "The second book in the Hunger Games trilogy by Suzanne Collins, continuing the story of Katniss Everdeen as she navigates the challenges of the 75th Hunger Games and the brewing rebellion against the Capitol.", "Catching Fire", 12, "/images/catchingfire.jpg", 9 },
                    { 3, "Suzanne Collins", "The final installment in Suzanne Collins' Hunger Games trilogy, where Katniss Everdeen becomes the symbol of rebellion against the oppressive Capitol and fights for freedom in Panem.", "Mockingjay", 15, "/images/mockingjay.jpg", 8 },
                    { 4, "Joseph Sheridan Le Fanu", "A Gothic horror novella by Joseph Sheridan Le Fanu, featuring a vampire named Carmilla.", "Carmilla", 8, "/images/carmilla.jpg", 8 },
                    { 5, "Olivie Blake", "A muder mystery novel by Olivie Blake that follows a real estate agent tasked with selling a creepy mansion.", "Masters of Death", 12, "/images/mastersofdeath.jpg", 2 },
                    { 6, "Jennifer Niven", "A novel by Jennifer Niven about a teenage boy who falls in love with a girl who is also dealing with mental health issues.", "All the bright places", 10, "/images/allthebrightplaces.jpg", 7 },
                    { 7, "Pat Barker", "A retelling of Homer's Iliad from the perspective of Briseis, a queen who becomes a war prize.", "The Silence of the Girls", 12, "/images/silenceofthegirls.jpg", 10 },
                    { 8, "Pat Barker", "The sequel to The Silence of the Girls by Pat Barker, that retells the aftermath of the Trojan War from the perspective of women who survived it.", "The Women of Troy", 12, "/images/womenof_Troy.jpg", 10 },
                    { 9, "Uketsu", "A story following a private investigator who is hired to look into a house layout. Which leads to more questions than answers.", "Strange Houses", 15, "/images/strangehouses.jpg", 9 },
                    { 10, "Susanne Collins", "The fifth book in the Hunger Games series by Suzanne Collins, set 24 years before the Katniss Everdeen's story. It follows the Hunger Games of Haymitch Abernathy a tribute in the 50th Hunger Games.", "The sunrise on the Reaping", 15, "/images/sunriseonthereaping.jpg", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
