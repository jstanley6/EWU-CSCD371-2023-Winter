namespace Logger;

public record Book : IEntity
{
    public Guid Id { get; init; }
    public string BookName { get; init; } = string.Empty;
    public FullName Author { get; init; }
    public string Isbn { get; init; } = string.Empty;
    public string Name => $"Book {BookName} \n Author: {Author.Name} \n ISBN: {Isbn}";
}

public record Student : Person
{
   public StudentClassification StudentYear { get; init; }
}

public record Employee : Person
{
    public string Employer { get; init; } = string.Empty;
}