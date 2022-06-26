using Microsoft.EntityFrameworkCore;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Context;

public class MainContext : DbContext
{
    public DbSet<User>? User { get; set; }

    public MainContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=dbo.Quizme.db");
    }
}