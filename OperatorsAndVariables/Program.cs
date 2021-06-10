using System;

namespace VariablesAndOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //TODO Create a program that asks for a number
            Console.WriteLine("Hello and welcome! Pick a number, any number.");
            int inputNumber = int.Parse(Console.ReadLine());

            //TODO Take that number as an input and using a ternary operator respond with if that number is even or odd.
            var isEven = (inputNumber % 2 == 0) ? $"{inputNumber} is Even" : $"{inputNumber} is Odd";
            Console.WriteLine($"{isEven}");
            //TODO Assign the value of the double below to an int variable called "priceRounded". google "w3schools C# type casting"

            double price = 15.99;

        }
    }
}
