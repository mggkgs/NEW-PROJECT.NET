 using System;

namespace PackageExpress
{ class Program
    {
        static void Main(string[] args)
 {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
 // Get the package weight from the user
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the weight is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Get the package dimensions from the user
                Console.Write("Please enter the package width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the package height: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the package length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                // Calculate the total dimensions
                double totalDimensions = width + height + length;

                // Check if the dimensions are too big
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Calculate the quote
                    double quote = (width * height * length * weight) / 100;

                    // Display the quote
                    Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
                    Console.WriteLine("Thank you!");
            