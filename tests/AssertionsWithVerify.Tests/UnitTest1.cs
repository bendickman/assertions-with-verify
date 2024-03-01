namespace AssertionsWithVerify.Tests;

public class UnitTest1
{
    [Fact]
    public Task Test()
    {
        var person = ClassBeingTested.FindPerson();
        return Verify(person);
    }
}