using System;

namespace CanHazFunny;

public class OutputJoke : IOutputJoke
{
    public void TellJoke(string joke)
    {
        Console.WriteLine(joke);
    }
}