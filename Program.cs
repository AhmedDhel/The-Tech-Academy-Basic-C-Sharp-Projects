using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message for the shipping company
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");

            // Convert the user input from string to integer
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                // Display error message if weight exceeds 50
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

                // End the program
                return;
            }

            // Ask the user for the package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check if the total dimensions exceed 50
            if (width + height + length > 50)
            {
                // Display error message if dimensions are too large
                Console.WriteLine("Package too big to be shipped via Package Express.");

                // End the program
                return;
            }

            // Calculate the shipping quote
            // Multiply width, height, and length together, then multiply by weight
            // Finally divide by 100 to get the shipping price
            decimal quote = (width * height * length * weight) / 100m;

            // Display the shipping cost formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // Thank the user
            Console.WriteLine("Thank you!");

            // Pause the console so the user can read the result
            Console.ReadLine();
        }
    }
}