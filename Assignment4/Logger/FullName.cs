using System;

namespace Logger;

//Provide a comment on the full name record on why you selected to define a value or a reference type
//A struct is a value type comparison. It needs to be a value type because a reference type will only modify the
//memory location and we need to make sure the object is modified.

//Provide a comment on the full name record on why or why not the type is immutable.
//The full name record should be immutable because we don't want the object to accidentally be altered and
//immutable objects never change so therefore can't be altered.

public record struct FullName(string FirstName, string LastName, string? MiddleName = null)
{

    public string FirstName { get; } = FirstName ?? throw new ArgumentNullException(nameof(FirstName));
    public string LastName { get; } = LastName ?? throw new ArgumentNullException(nameof(LastName));
    public string? MiddleName { get; } = MiddleName;

    public string Name => $"{FirstName} {MiddleName} {LastName}";
}