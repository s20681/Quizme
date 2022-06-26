namespace Quizme.Infrastructure.Entities;

public class Category : BaseEntity
{
    public String Name { get; set; } = String.Empty;
    public String? Description { get; set; }
}