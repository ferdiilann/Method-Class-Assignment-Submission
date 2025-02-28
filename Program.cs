using System;

namespace MathOperationApp
{
    /// <summary>
    /// This class contains a method that performs a math operation on one integer
    /// and displays another integer to the console
    /// </summary>
    public class MathOperations
    {
        /// <summary>
        /// This method performs a math operation (squaring) on the first parameter
        /// and displays the second parameter to the console
        /// </summary>
        /// <param name="firstNumber">The number to be squared</param>
        /// <param name="secondNumber">The number to be displayed</param>
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Calculate the square of the first number
            int result = firstNumber * firstNumber;
            
            // Display the result of the calculation
            Console.WriteLine($"The square of {firstNumber} is: {result}");
            
            // Display the second number as requested
            Console.WriteLine($"The second number is: {secondNumber}");
        }
    }

    /// <summary>
    /// The main class containing the entry point of the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the Math Operations Application!");
            Console.WriteLine("-------------------------------------------");
            
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();
            
            // Call the ProcessNumbers method passing in two numbers (positional parameters)
            Console.WriteLine("\nCalling method with positional parameters:");
            mathOps.ProcessNumbers(5, 10);
            
            // Call the ProcessNumbers method specifying the parameters by name (named parameters)
            Console.WriteLine("\nCalling method with named parameters:");
            mathOps.ProcessNumbers(firstNumber: 7, secondNumber: 14);
            
            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
