using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculate.ProgramTests;

[TestClass]
public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [TestMethod]
    public void TestDictAreEqual()
    {
        Func<int, int, double> multiplication = Calculator.Multiply;
        Func<int, int, double> division = Calculator.Divide;
        Func<int, int, double> add = Calculator.Add;
        Func<int, int, double> subtraction = Calculator.Subtract;
        
        Assert.AreEqual(multiplication, _calc.MathematicalOperators['*']);
        Assert.AreEqual(division, _calc.MathematicalOperators['/']);
        Assert.AreEqual(add, _calc.MathematicalOperators['+']);
        Assert.AreEqual(subtraction, _calc.MathematicalOperators['-']);
        
    }

    [TestMethod]
    public void Add_Test()
    {
        double addTest = Calculator.Add(6, 2);
        double resTest = 8;
        
        Assert.AreEqual(resTest, addTest);
    }
    
    [TestMethod]
    public void Subtract_Test()
    {
        double subTest = Calculator.Subtract(6, 2);
        double resTest = 4;
        
        Assert.AreEqual(resTest, subTest);
    }
    
    [TestMethod]
    public void Multiply_Test()
    {
        double multiplyTest = Calculator.Multiply(8, 2);
        double resTest = 16;
        
        Assert.AreEqual(resTest, multiplyTest);
    }
    
    [TestMethod]
    public void Divide_Test()
    {
        double divTest = Calculator.Divide(10, 5);
        double resTest = 2;
        
        Assert.AreEqual(resTest, divTest);
    }
    
    
    
}