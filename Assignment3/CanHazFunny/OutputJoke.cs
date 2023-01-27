using System;

namespace CanHazFunny;

public class OutputJoke : IOutputJoke
{
    public void Print(string output)
    {
        Console.WriteLine(output);
    }
}