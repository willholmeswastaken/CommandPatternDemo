using CommandPattern.Commands;

namespace CommandPattern
{
    public class Invoker
    {
        public Invoker()
        {
            
        }

        public Invoker(ICommand command)
        {
            this.Command = command;
        }

        public ICommand Command { get; set; }

        public void ExecuteCommand()
        {
            Command.Validate();

            Command.Execute();
        }
    }
}