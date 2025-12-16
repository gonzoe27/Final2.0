using Microsoft.EntityFrameworkCore;
using ZoeNBellaLibary2._0.Models;

namespace ZoeNBellaLibary2._0.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext (DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Book_ID = 001,
                    Book_Name = "Hunger Games",
                    Book_Description = "A novel written by American author Suzanne Collins that follows a cast of characters living in the fictional districts of Panem.",
                    Book_Author = "Suzanne Collins",
                    Bought_Price = 10,
                    ImageFileNmae = "/images/hungergames.jpg",
                    Rating = 10,
                    PostApocalyptic = 10
                },
                new Book
                {
                    Book_ID = 002,
                    Book_Name = "Catching Fire",
                    Book_Description = "The second book in the Hunger Games trilogy by Suzanne Collins, continuing the story of Katniss Everdeen as she navigates the challenges of the 75th Hunger Games and the brewing rebellion against the Capitol.",
                    Book_Author = "Suzanne Collins",
                    Bought_Price = 12,
                    ImageFileNmae = "/images/catchingfire.jpg",
                    Rating = 9,
                    PostApocalyptic = 10
                },
                new Book
                {
                    Book_ID = 003,
                    Book_Name = "Mockingjay",
                    Book_Description = "The final installment in Suzanne Collins' Hunger Games trilogy, where Katniss Everdeen becomes the symbol of rebellion against the oppressive Capitol and fights for freedom in Panem.",
                    Book_Author = "Suzanne Collins",
                    Bought_Price = 15,
                    ImageFileNmae = "/images/mockingjay.jpg",
                    Rating = 8,
                    PostApocalyptic = 10
                },
                new Book
                {
                    Book_ID = 004,
                    Book_Name = "Carmilla",
                    Book_Description = "A Gothic horror novella by Joseph Sheridan Le Fanu, featuring a vampire named Carmilla.",
                    Book_Author = "Joseph Sheridan Le Fanu",
                    Bought_Price = 8,
                    ImageFileNmae = "/images/carmilla.jpg",
                    Rating = 8,
                    PostApocalyptic = 3
                },
                new Book
                {
                    Book_ID = 005,
                    Book_Name = "Masters of Death",
                    Book_Description = "A muder mystery novel by Olivie Blake that follows a real estate agent tasked with selling a creepy mansion.",
                    Book_Author = "Olivie Blake",
                    Bought_Price = 12,
                    ImageFileNmae = "/images/mastersofdeath.jpg",
                    Rating = 2,
                    PostApocalyptic = 2
                },
                new Book
                {
                    Book_ID = 006,
                    Book_Name = "All the bright places",
                    Book_Description = "A novel by Jennifer Niven about a teenage boy who falls in love with a girl who is also dealing with mental health issues.",
                    Book_Author = "Jennifer Niven",
                    Bought_Price = 10,
                    ImageFileNmae = "/images/allthebrightplaces.jpg",
                    Rating = 7,
                    PostApocalyptic = 1
                },
                new Book
                {
                    Book_ID = 007,
                    Book_Name = "The Silence of the Girls",
                    Book_Description = "A retelling of Homer's Iliad from the perspective of Briseis, a queen who becomes a war prize.",
                    Book_Author = "Pat Barker",
                    Bought_Price = 12,
                    ImageFileNmae = "/images/silenceofthegirls.jpg",
                    Rating = 10,
                    PostApocalyptic = 2
                },
                new Book
                {
                    Book_ID = 008,
                    Book_Name = "The Women of Troy",
                    Book_Description = "The sequel to The Silence of the Girls by Pat Barker, that retells the aftermath of the Trojan War from the perspective of women who survived it.",
                    Book_Author = "Pat Barker",
                    Bought_Price = 12,
                    ImageFileNmae = "/images/womenof_Troy.jpg",
                    Rating = 10,
                    PostApocalyptic = 3
                },
                new Book
                {
                    Book_ID = 09,
                    Book_Name = "Strange Houses",
                    Book_Description = "A story following a private investigator who is hired to look into a house layout. Which leads to more questions than answers.",
                    Book_Author = "Uketsu",
                    Bought_Price = 15,
                    ImageFileNmae = "/images/strangehouses.jpg",
                    Rating = 9,
                    PostApocalyptic = 1
                },
                new Book
                {
                    Book_ID = 010,
                    Book_Name = "The sunrise on the Reaping",
                    Book_Description = "The fifth book in the Hunger Games series by Suzanne Collins, set 24 years before the Katniss Everdeen's story. It follows the Hunger Games of Haymitch Abernathy a tribute in the 50th Hunger Games.",
                    Book_Author = "Susanne Collins",
                    Bought_Price = 15,
                    ImageFileNmae = "/images/sunriseonthereaping.jpg",
                    Rating = 9,
                    PostApocalyptic = 8
                }
            );
        }
    }
}



