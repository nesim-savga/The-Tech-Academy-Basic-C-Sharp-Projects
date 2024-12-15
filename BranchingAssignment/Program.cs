using System;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight
            Console.Write("Enter the package weight: ");
            if (!float.TryParse(Console.ReadLine(), out float packageWeight) || packageWeight <= 0)
            {
                Console.WriteLine("Invalid weight entered.");
                return;
            }

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt for dimensions
            Console.Write("Enter the package width: ");
            if (!float.TryParse(Console.ReadLine(), out float packageWidth) || packageWidth <= 0)
            {
                Console.WriteLine("Invalid width entered.");
                return;
            }

            Console.Write("Enter the package height: ");
            if (!float.TryParse(Console.ReadLine(), out float packageHeight) || packageHeight <= 0)
            {
                Console.WriteLine("Invalid height entered.");
                return;
            }

            Console.Write("Enter the package length: ");
            if (!float.TryParse(Console.ReadLine(), out float packageLength) || packageLength <= 0)
            {
                Console.WriteLine("Invalid length entered.");
                return;
            }

            // Calculate total dimensions
            float dimensionTotal = packageWidth + packageHeight + packageLength;

            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate and display shipping cost
            float shippingCost = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
            Console.WriteLine($"Your estimated total for shipping this package is: ${shippingCost:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
