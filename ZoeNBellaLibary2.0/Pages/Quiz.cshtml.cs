using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZoeNBellaLibary2._0.Data;
using ZoeNBellaLibary2._0.Models;

namespace ZoeNBellaLibary2._0.Pages
{
    public class QuizModel : PageModel
    {
        private readonly BooksContext _context;

        public QuizModel(BooksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int PostApocalyptic { get; set; }

        public void OnGet()
        {           
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var book = await _context.Books.ToListAsync();

            Book bestMatch = null;
            int smallestDifference = int.MaxValue;
            foreach (var b in book)
            {
                int difference = Math.Abs(b.PostApocalyptic - PostApocalyptic);
                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                    bestMatch = b;
                }
            }
            return RedirectToPage("/Results", new { Book_ID = bestMatch.Book_ID, UserName = Name });
        }
    }
}