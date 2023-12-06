using ApiProjet.Model;
using Microsoft.EntityFrameworkCore;

public class ProjetContext : DbContext
{
    public DbSet<Document> Documents { get; set; } = null!;
    public DbSet<Member> Members { get; set; } = null!;
    public string DbPath { get; private set; }

    public ProjetContext()
    {
        // Path to SQLite database file
        DbPath = "ApiProjet.db";
    }

    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        //options.LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}
