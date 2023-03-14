using System;
using System.Security.Cryptography.X509Certificates;

namespace WorkingWithLambdaExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 100);
            }
            // Lambda Expressions
            
            var sum = (int x, int y) => x + y;
           
            var result = (int x, int y) => x * y;
            // Lambda Statements
            // Find the larger number
            var largerValue = (int a, int b) =>
            {
                if (a > b)
                    return b;
                else
                    return b;
            };

            // Using lambda expressions and statements
            for (int x = 0; x < numbers.Length - 1; x++)
            {
                Console.WriteLine($"Numbers you are using: {numbers[x]}  and  {numbers[x + 1]}");
                Console.WriteLine($"The sum is: {sum(numbers[x], numbers[x + 1])}");
                Console.WriteLine($"The difference is: {result(numbers[x], numbers[x + 1])}");
                Console.WriteLine($"The larger value is: {largerValue(numbers[x], numbers[x + 1])}");
                Console.WriteLine();
            }

        }
    }
}
