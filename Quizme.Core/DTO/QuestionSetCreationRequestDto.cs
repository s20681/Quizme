namespace Quizme.Core.DTO;

public class QuestionSetCreationRequestDto
{
    public String Title { get; set; } 
    public int? TimeLimit { get; set; }
    public int? OwnerId { get; set; }
    
    public QuestionSetCreationRequestDto(string title, int? timeLimit, int? ownerId)
    {
        Title = title;
        TimeLimit = timeLimit;
        OwnerId = ownerId;
    }
}