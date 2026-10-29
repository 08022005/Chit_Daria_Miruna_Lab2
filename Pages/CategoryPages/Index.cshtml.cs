using Chit_Daria_Miruna_Lab2.Models;
using Chit_Daria_Miruna_Lab2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Chit_Daria_Miruna_Lab2.Pages.CategoryPages
{
    public class IndexModel : PageModel
    {
        private readonly Chit_Daria_Miruna_Lab2Context _context;

        public IndexModel(Chit_Daria_Miruna_Lab2Context context)
        {
            _context = context;
        }

        public CategoryIndexData CategoryData { get; set; } = default!;
        public int CategoryID { get; set; }
        public int BookID { get; set; }

        public async Task OnGetAsync(int? id)
        {
            CategoryData = new CategoryIndexData();

            // Încărcăm categoriile împreună cu cărțile asociate și autorii acestora
            CategoryData.Categories = await _context.Category
                .Include(c => c.BookCategories!)
                    .ThenInclude(bc => bc.Book)
                        .ThenInclude(b => b.Authors)
                .OrderBy(c => c.CategoryName)
                .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                    .Single(c => c.ID == id.Value);

                CategoryData.Books = category.BookCategories?
                    .Select(bc => bc.Book) ?? Enumerable.Empty<Book>();
            }
        }
    }
}
