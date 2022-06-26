namespace Quizme.Infrastructure.Entities;

public class User : BaseEntity
{
    public String Name { get; set; } = String.Empty;
    public String Email { get; set; } = String.Empty;
    
    // public IEnumerable<Quiz>? Quizzes { get; set; }
}