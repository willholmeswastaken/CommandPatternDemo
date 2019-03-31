using System;

namespace CommandPattern.Exceptions
{
    public class InvalidAdditionException : Exception
    {
        public InvalidAdditionException(int firstNumber, int secondNumber)
        : base($"The numbers {firstNumber} and {secondNumber} cannot be added together, as they produce 0 or a negative number.")
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }

        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }
    }
}