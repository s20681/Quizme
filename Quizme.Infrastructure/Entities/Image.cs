namespace Quizme.Infrastructure.Entities;

public class Image : BaseEntity
{
    public Byte[] Data { get; set; } = new byte[] { };

    // public int QuestionId { get; set; }
    // public Question Question { get; set; }
}