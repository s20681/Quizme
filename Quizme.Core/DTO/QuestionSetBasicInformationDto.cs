namespace Quizme.Core.DTO;

public class QuestionSetBasicInformationDto
{
    public int? TimeLimit { get; set; }
    public int? QuestionSize { get; set; }
    
    public int OwnerId { get; set; }

    public QuestionSetBasicInformationDto(int? timeLimit, int? questionSize, int ownerId)
    {
        TimeLimit = timeLimit;
        QuestionSize = questionSize;
        OwnerId = ownerId;
    }
}