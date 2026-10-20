using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chit_Daria_Miruna_Lab2.Models;

namespace Chit_Daria_Miruna_Lab2.Pages.BookPages;

public class IndexModel : PageModel
{
    private readonly Chit_Daria_Miruna_Lab2Context _context;

    public IndexModel(Chit_Daria_Miruna_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Book = await _context.Book
            .Include(b => b.Publisher)
            .Include(b => b.Authors)
            .ToListAsync();

    }
}
