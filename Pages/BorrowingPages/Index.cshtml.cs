using Chit_Daria_Miruna_Lab2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chit_Daria_Miruna_Lab2.Models;

namespace Chit_Daria_Miruna_Lab2.Pages.BorrowingPages;

public class IndexModel : PageModel
{
    private readonly Chit_Daria_Miruna_Lab2Context _context;

    public IndexModel(Chit_Daria_Miruna_Lab2Context context)
    {
        _context = context;
    }

    public IList<Borrowing> Borrowing { get; set; } = default!;

    public async Task OnGetAsync()
    {
        if (_context.Borrowing != null)
        {
            Borrowing = await _context.Borrowing
         .Include(b => b.Book)
 .ThenInclude(b => b.Authors)
 .Include(b => b.Member).ToListAsync();
        }
    }

}





