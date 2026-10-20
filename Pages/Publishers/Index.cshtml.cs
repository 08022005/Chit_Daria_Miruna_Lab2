using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chit_Daria_Miruna_Lab2;
using Chit_Daria_Miruna_Lab2.Models;

namespace Chit_Daria_Miruna_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Chit_Daria_Miruna_Lab2Context _context;

        public IndexModel(Chit_Daria_Miruna_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Set<Publisher>().ToListAsync();
        }
    }
}