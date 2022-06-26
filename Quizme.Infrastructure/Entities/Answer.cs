namespace Quizme.Infrastructure.Entities;

public class Answer : BaseEntity
{
    public String Content { get; set; } = String.Empty;
    public bool IsValid { get; set; }

    public int? QuestionId { get; set; }
    public Question? Question { get; set; }
}