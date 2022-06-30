namespace Quizme.Infrastructure.Entities;

public class User : BaseEntity
{
    public String Name { get; set; }
    public String Email { get; set; }

    public String Password { get; set; }
    // public IEnumerable<Quiz>? Quizzes { get; set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }
}