using System;

namespace MethodApp
{
    public class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a simple math operation on the first integer. Add 5 to the number.
            double result = num1 + 5;

            // Display the result of the math operation
            Console.WriteLine("Add 5 to the number");
            Console.WriteLine("The result of the math operation on the first number is: " + result);

            // Display the second integer
            Console.WriteLine("The second number is: " + num2);
        }
    }
}
