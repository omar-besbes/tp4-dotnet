using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using tp4_dotnet.Models;

namespace tp4_dotnet.Data;

public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    private static UniversityContext? _context;

    private UniversityContext(DbContextOptions o) : base(o)
    {
    }

    public static UniversityContext? Instantiate_UniversityContext(IConfiguration configuration)
    {
        if (_context == null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            optionsBuilder.UseSqlite(configuration.GetConnectionString("SQLite"));
            _context = new UniversityContext(optionsBuilder.Options);
        }

        return _context;
    }
}