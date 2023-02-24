// See https://aka.ms/new-console-template for more information

namespace Calculate;

using System;

public class Program
{
    public Program() {}

    public Action<string> Writeline { get; init; } = text => Console.WriteLine(text);
    public Func<string?> Readline { get; init; } = () => Console.ReadLine();

    public static void Main(string[] args)
    {
        var calculator = new Calculator();
        bool exit = false;
        Program program = new();

        do
        {
            program.Writeline("Enter mathematical equation in the form of x + y." +
                              "\nType quit to exit: ");

            var input = program.Readline();
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            if (input is "quit")
            {
                exit = true;
                program.Writeline("Quitting program..");
            }
            else if (calculator.TryCalculate(input, out var result))
            {
                program.Writeline($"The input is {input} and the result is {result}");

            }
            else
            {
                program.Writeline("Invalid Input. Please try again.");
            }
        } while (!exit);
    }
}