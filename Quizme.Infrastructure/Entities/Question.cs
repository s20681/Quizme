using System.Runtime;
using System.Security.Principal;

namespace Quizme.Infrastructure.Entities;

public class Question : BaseEntity
{
    public String? Text { get; set; }
    
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    public int? ImageId { get; set; }
    public Image? Image { get; set; }
    
    public IEnumerable<Answer>? Answers { get; set; }
    
    public int? QuestionSetId { get; set; }
    public QuestionSet? QuestionSet { get; set; }
}