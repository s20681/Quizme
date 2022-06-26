using Microsoft.EntityFrameworkCore;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Context;

public class MainContext : DbContext
{
    public DbSet<Answer> Answer { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Image> Image { get; set; }
    public DbSet<Question> Question { get; set; }
    public DbSet<QuestionSet> QuestionSet { get; set; }
    public DbSet<Quiz> Quiz { get; set; }
    public DbSet<User>? User { get; set; }

    public MainContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=dbo.Quizme.db");
    }
}