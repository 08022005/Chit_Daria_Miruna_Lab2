using Microsoft.EntityFrameworkCore;

public class Chit_Daria_Miruna_Lab2Context(DbContextOptions<Chit_Daria_Miruna_Lab2Context> options) : DbContext(options)
{
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Chit_Daria_Miruna_Lab2.Models.Authors> Authors { get; set; } = default!;

}
