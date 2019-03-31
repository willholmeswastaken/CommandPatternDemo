
using System;
using CommandPattern.Commands;
using CommandPattern.Handlers;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                // Obtain our numbers to pass to our command.
                Console.WriteLine("Welcome to the number adder 5000, please start by entering your first number.");
                int firstNumber = GetNumber();

                Console.WriteLine("Thank you, now add your next number.");

                int secondNumber = GetNumber();
                Console.WriteLine("Thank you, working out your result...");

                // setup our handler, and create our command with the relevant data passed in.
                IAddTwoNumbersHandler handler = new AddTwoNumbersHandler();
                AddTwoNumbersCommand command = new AddTwoNumbersCommand(handler, firstNumber, secondNumber);

                // create our invoker and perform our command.
                Invoker invoker = new Invoker(command);
                invoker.ExecuteCommand();
                Console.WriteLine($"Your result is {command.Result}!");

                // ask if the user wants to go again...
                Console.WriteLine("Want to carry on? Type y or n to quit.");
                string carryOn = Console.ReadLine();
                keepGoing = string.IsNullOrWhiteSpace(carryOn) || carryOn.ToLower() == "y";
            }
        }

        static int GetNumber()
        {
            string getFirstNumber = Console.ReadLine();
            return !int.TryParse(getFirstNumber, out int firstNumber)
                ? GetNumber()
                : firstNumber;
        }
    }
}
