using Microsoft.EntityFrameworkCore;
namespace Chit_Daria_Miruna_Lab2.Data;

public class Chit_Daria_Miruna_Lab2Context(DbContextOptions<Chit_Daria_Miruna_Lab2Context> options) : DbContext(options)
{
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Authors> Authors { get; set; } = default!;
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Category> Category { get; set; } = default!;
    public DbSet<Chit_Daria_Miruna_Lab2.Models.BookCategory> BookCategory { get; set; } = default!;
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Member> Member { get; set; } = default!;
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;

}
