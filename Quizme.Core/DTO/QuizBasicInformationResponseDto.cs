namespace Quizme.Core.DTO;

public class QuizBasicInformationResponseDto
{
    public String UserName { get; set; }
    public int Result { get; set; }
    public DateTime TimeStarted { get; set; }
    public DateTime TimeEnded { get; set; }
    public bool IsDone { get; set; }

    public QuizBasicInformationResponseDto(string userName, int result, DateTime timeStarted, DateTime timeEnded, bool isDone)
    {
        UserName = userName;
        Result = result;
        TimeStarted = timeStarted;
        TimeEnded = timeEnded;
        IsDone = isDone;
    }
}