using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Muntean_Alexia_Lab2.Data;
using Muntean_Alexia_Lab2.Models;

namespace Muntean_Alexia_Lab2.Pages.Borrowings
{
    public class CreateModel : PageModel
    {
        private readonly Muntean_Alexia_Lab2.Data.Muntean_Alexia_Lab2Context _context;

        public CreateModel(Muntean_Alexia_Lab2.Data.Muntean_Alexia_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; }
        public IActionResult OnGet()
        {
            var bookList = _context.Book
            .Include(b => b.Author)
            .Select(x => new
            {
                x.Id,
                BookFullName = x.Title + " - " + x.Author.AuthorName
            });

            ViewData["BookId"] = new SelectList(bookList, "Id", "BookFullName");
            ViewData["MemberID"] = new SelectList(_context.Member, "ID", "FullName");
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Borrowing.Add(Borrowing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
