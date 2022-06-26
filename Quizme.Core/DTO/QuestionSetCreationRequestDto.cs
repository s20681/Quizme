namespace Quizme.Core.DTO;

public class QuestionSetCreationRequestDto
{
    public int? OwnerId { get; set; }
    public int? TimeLimit { get; set; }

    public QuestionSetCreationRequestDto(int? ownerId, int? timeLimit)
    {
        OwnerId = ownerId;
        TimeLimit = timeLimit;
    }
}