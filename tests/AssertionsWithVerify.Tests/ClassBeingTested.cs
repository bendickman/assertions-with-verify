namespace AssertionsWithVerify.Tests;
public static class ClassBeingTested
{
    public static Person FindPerson() =>
        new()
        {
            Id = 1,
            Forename = "John",
            Surname = "Smith",
        };
}
