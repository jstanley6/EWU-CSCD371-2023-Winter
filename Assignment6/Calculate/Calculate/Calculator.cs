namespace Calculate;

public class Calculator
{
    
    public IReadOnlyDictionary<char, Func<int, int, double>> MathematicalOperators { get; }
    private static readonly char[] Operators = {'+', '-', '*', '/'};
    public Calculator()
    {
        MathematicalOperators = new Dictionary<char, Func<int, int, double>>
        {
            {Operators[0], Add},
            {Operators[1], Subtract},
            {Operators[2], Multiply},
            {Operators[3], Divide}
        };
    }

  
 

    public static double Add(int a, int b)
        => (double)a + b;

    public static double Subtract(int a, int b)
        => (double)a - b;

    public static double Multiply(int a, int b)
        => (double)a * b;

    public static double Divide(int a, int b)
        => (double)a / b;

    public bool TryCalculate(string calculation, out double result)
    {
        var split = calculation.Split(" ");
        int a;
        int b;

        if (split.Length != 3 ||
            !int.TryParse(split[0], out a) || !int.TryParse(split[2], out b) ||
            split[1].Length != 1 || Operators.All(o => o != split[1].ToCharArray()[0]))
        {
            result = 0;
            return false;
        }

        result = MathematicalOperators[split[1].ToCharArray()[0]](a, b);
        return true;
    }
}