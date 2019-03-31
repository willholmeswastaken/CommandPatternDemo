namespace CommandPattern.Commands
{
    /// <summary>
    /// An interface to specify an execute and validate method for commands.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Method designed to allow for performing any validation on data in the command, before execution.
        /// </summary>
        void Validate();

        /// <summary>
        /// Method to perform the execution of a command.
        /// </summary>
        void Execute();
    }
}