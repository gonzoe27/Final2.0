using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZoeNBellaLibary2._0.Data;
using ZoeNBellaLibary2._0.Models;

namespace ZoeNBellaLibary2._0.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly BooksContext _context;

        public ResultsModel(BooksContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int Book_ID { get; set; }

        [BindProperty(SupportsGet = true)]
        public string UserName { get; set; }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (Book_ID <= 0)
            {
                return RedirectToPage("/Index");
            }

            Book = await _context.Books.FindAsync(Book_ID);

            if (Book == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}