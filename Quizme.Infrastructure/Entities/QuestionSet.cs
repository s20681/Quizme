namespace Quizme.Infrastructure.Entities;

public class QuestionSet : BaseEntity
{
    public IEnumerable<Question>? Questions { get; set; }

    public int? OwnerId { get; set; }
    public User? Owner { get; set; }
    
    public int? TimeLimit { get; set; }
    public IEnumerable<Quiz>? Quizzes { get; set; }
}