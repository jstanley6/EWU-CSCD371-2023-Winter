using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculate.ProgramTests;
using System;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void TestWriteLine()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        string expected = "expected";

        new Program().Writeline(expected);
        
        Assert.AreEqual(expected, stringWriter.ToString().Trim());
    }
    [TestMethod]
    public void TestReadLine()
    {
        string? test = "testString";
        StringReader stringReader = new(test);
        Console.SetIn(stringReader);

        var input = new Program().Readline();
        
        Assert.AreEqual<string?>(test, input);
    }

    [TestMethod]
    public void TestCalculateWithProgram()
    {
        Calculator calculator = new();
        Program program = new();
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        string? userInput = "10 * 10";

        StringReader stringReader = new(userInput);
        Console.SetIn(stringReader);
        string expected = "The result of the equation 10 * 10 is 100";
        userInput = program.Readline();
        
        Assert.IsTrue(calculator.TryCalculate(userInput!, out double result));
        program.Writeline($"The result of the equation {userInput} is {result}");
        
        Assert.AreEqual(expected, stringWriter.ToString().Trim());


    }
}