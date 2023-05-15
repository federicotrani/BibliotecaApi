using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Autor> Autores { get; set; }
}
