namespace Quizme.Infrastructure.Entities;

public class QuestionSet : BaseEntity
{
    public String Title { get; set; } = String.Empty;
    public IEnumerable<Question>? Questions { get; set; }

    public int? OwnerId { get; set; }
    public User? Owner { get; set; }
    
    public int? TimeLimit { get; set; }
    public IEnumerable<Quiz>? Quizzes { get; set; }

    public QuestionSet(int? ownerId, int? timeLimit)
    {
        OwnerId = ownerId;
        TimeLimit = timeLimit;
    }
}