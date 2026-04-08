using System;

namespace MyConsoleApp
{
    // Define a class named MathOperations
    class MathOperations
    {
        // Define a void method that takes two integers as parameters
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = firstNumber * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of the first number multiplied by 2: " + result);

            // Display the second integer to the screen
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the Math Operations Console App");

            // Instantiate the MathOperations class
            MathOperations myOperations = new MathOperations();

            // Call the method using positional parameters
            myOperations.PerformOperation(5, 10);

            // Call the method using named parameters
            myOperations.PerformOperation(firstNumber: 7, secondNumber: 20);

            // Pause the console so the user can see the results
            Console.ReadLine();
        }
    }
}
