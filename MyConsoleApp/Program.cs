using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Declare and initialize variables, then print them
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("Task 1:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Is Admin: {isAdmin}");
            Console.WriteLine();

            // Task 2: Check if a number is even or odd
            Console.WriteLine("Task 2:");
            Console.Write("Enter an integer: ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.WriteLine();

            // Task 3: Print numbers 1 to 10 using a for loop
            Console.WriteLine("Task 3:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Task 4: Calculate the sum of an array and print elements
            Console.WriteLine("Task 4:");
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            Console.WriteLine("Array elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                sum += number;
            }

            Console.WriteLine($"Sum of array elements: {sum}");
            Console.WriteLine();

            // Task 5: Call the Greet method
            Console.WriteLine("Task 5:");
            Greet("Alice");
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
