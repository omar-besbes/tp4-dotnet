using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using tp4_dotnet.Models;

namespace tp4_dotnet.Data;

public class UniversityContext : DbContext
{
    public DbSet<Student> Student { get; set; }

    private static UniversityContext Context;

    private UniversityContext(DbContextOptions o) : base(o)
    {
    }

    public UniversityContext Instantiate_UniversityContext(IConfiguration _configuration)
    {
        var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();

        optionsBuilder.UseSqlite(_configuration.GetConnectionString("SQLite"));

        if (Context == null) Context = new UniversityContext(optionsBuilder.Options);

        return Context;
    }
}