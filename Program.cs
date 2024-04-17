using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result = 0;
            string answer;

            Console.WriteLine("Hi, welcome to the Calculator program!");

            Console.WriteLine("Please enter a number.");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("What type of operation do you need?");
            Console.WriteLine("Press a for addition, s for subtraction, m for multiplication and d for division");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cant divide by 0!");
                    return; // Exit the program if division by zero is attempted
                }
            }
            else
            {
                Console.WriteLine("You did not press a correct key");
                return; // Exit the program if an invalid operation is entered
            }

            Console.WriteLine($"The result is {result}");
            Console.WriteLine("Thank you for using the Calculator program");
            Console.ReadKey();
        }
    }
}
