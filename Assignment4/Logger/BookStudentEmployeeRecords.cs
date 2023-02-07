using System;

namespace Logger;

public record Book : IEntity
{
    public Guid Id { get; init; }
    public string BookName { get; init; } = string.Empty;
    public FullName Author { get; init; }
    public string Isbn { get; init; } = string.Empty;
    public string Name => $"Book {BookName} \n Author: {Author.Name} \n ISBN: {Isbn}";
}

//Provide a comment on each interface
//**member** in each entity explaining why you implemented it implicitly or explicitly.

//Implemented all three Implicitly for precision and to avoid conflict 
//of members having the same properties
public record Student : Person
{
   public StudentClassification StudentYear { get; init; }
}

public record Employee : Person
{
    public string Employer { get; init; } = string.Empty;
}