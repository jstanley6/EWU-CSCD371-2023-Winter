namespace Calculate;

public class Calculator
{
    private delegate int OperationDelegate(int a, int b);
    
        private static readonly char[] Operators = new[] {'+', '-', '*', '/'};
    
        private static readonly IReadOnlyDictionary<char, Func<int, int, int>> MathematicalOperations = new Dictionary<char, Func<int, int, int>>
        {
            {Operators[0], Add},
            {Operators[1], Subtract},
            {Operators[2], Multiply},
            {Operators[3], Divide}
        };
    
        private static int Add(int a, int b)
            => a + b;
    
        private static int Subtract(int a, int b)
            => a - b;
    
        private static int Multiply(int a, int b)
            => a * b;
    
        private static int Divide(int a, int b)
            => a / b;
    
        public static bool TryCalculate(string calculation, out int result)
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
    
            var symbol = split[1].ToCharArray()[0];
            result = MathematicalOperations[symbol](a, b);

            return true;
        }
    


}
