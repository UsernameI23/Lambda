using System;
using System.Security.Cryptography.X509Certificates;

namespace WorkingWithLambdaExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            // Lambda Expressions
            
            var sum = (int x, int y) => x + y;
           
            var result = (int x, int y) => x * y;
            
            var smallerValue = (int a, int b) =>
            {
                if (a > b)
                    return a;
                else
                    return b;
            };

            
                
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The product is: {result}");
                Console.WriteLine($"The smaller value is: {smallerValue}");
                Console.WriteLine();
            

        }
    }
}
