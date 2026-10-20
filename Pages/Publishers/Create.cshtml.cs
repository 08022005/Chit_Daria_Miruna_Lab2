using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Chit_Daria_Miruna_Lab2;
using Chit_Daria_Miruna_Lab2.Models;

namespace Chit_Daria_Miruna_Lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Chit_Daria_Miruna_Lab2Context _context;

        public CreateModel(Chit_Daria_Miruna_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Set<Publisher>().Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}