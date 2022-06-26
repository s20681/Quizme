namespace Quizme.Infrastructure.Entities;

public class Quiz : BaseEntity
{
    public int Type { get; set; }
    public int Result { get; set; }
    public DateTime TimeStarted { get; set; }
    public DateTime TimeEnded { get; set; }
    public bool IsDone { get; set; }
    
    public int RespondentId { get; set; }
    public User Respondent { get; set; } //person taking exam

    public IEnumerable<Question> Questions { get; set; } //random set of questions
    
    //invalid answers list
    //valid answers list
    //max points able to get
}