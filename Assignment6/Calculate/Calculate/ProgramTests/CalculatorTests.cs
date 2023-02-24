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
[TestMethod]
    public void TryCalculateTest_True()
    {
        string equation = "2 + 3";
        int expected = 5;
        
        Assert.IsTrue(_calc.TryCalculate(equation, out double result));
        
        Assert.AreEqual<double>(expected, result);
    }

    [TestMethod]
    public void TryCalculateTestNoSpace_Failed()
    {
        string testCalcEquation = "3+5";
        double expected = 0;
        bool tryCalcBoolean = _calc.TryCalculate(testCalcEquation, out double result);
        Assert.IsFalse(tryCalcBoolean);
        Assert.AreEqual<double>(expected, result);
    }

    [TestMethod]
    public void TryCalculateAdd_Test()
    {
        string testCalcEquation = "6 + 2";
        double expected = 8;
        bool tryCalcBool = _calc.TryCalculate(testCalcEquation, out double result);
        Assert.IsTrue(tryCalcBool);
        Assert.AreEqual<double>(expected,result);
    }
    
    [TestMethod]
    public void TryCalculateSubtract_Test()
    {
        string testCalcEquation = "6 - 2";
        double expected = 4;
        bool tryCalcBool = _calc.TryCalculate(testCalcEquation, out double result);
        Assert.IsTrue(tryCalcBool);
        Assert.AreEqual<double>(expected,result);
    }
    
    [TestMethod]
    public void TryCalculateMultiply_Test()
    {
        string testCalcEquation = "6 * 2";
        double expected = 12;
        bool tryCalcBool = _calc.TryCalculate(testCalcEquation, out double result);
        Assert.IsTrue(tryCalcBool);
        Assert.AreEqual<double>(expected,result);
    }
    
    [TestMethod]
    public void TryCalculateDivide_Test()
    {
        string testCalcEquation = "10 / 2";
        double expected = 5;
        bool tryCalcBool = _calc.TryCalculate(testCalcEquation, out double result);
        Assert.IsTrue(tryCalcBool);
        Assert.AreEqual<double>(expected,result);
    }



}