using CommandPattern.Exceptions;
using CommandPattern.Handlers;

namespace CommandPattern.Commands
{
    public class AddTwoNumbersCommand : ICommand
    {
        private readonly IAddTwoNumbersHandler handler;
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }

        public AddTwoNumbersCommand(IAddTwoNumbersHandler handler)
        {
            this.handler = handler;
        }

        public AddTwoNumbersCommand(IAddTwoNumbersHandler handler, int firstNumber, int secondNumber)
        {
            this.handler = handler;
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }

        public void Validate()
        {
            if (this.FirstNumber <= 0 && this.SecondNumber <= 0)
            {
                throw new InvalidAdditionException(this.FirstNumber, this.SecondNumber);
            }
        }

        public void Execute()
        {
            this.Result = this.handler.AddTwoNumbers(this.FirstNumber, this.SecondNumber);
        }
    }
}