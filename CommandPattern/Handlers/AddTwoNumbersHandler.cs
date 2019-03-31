namespace CommandPattern.Handlers
{
    public class AddTwoNumbersHandler : IAddTwoNumbersHandler
    {
        public int AddTwoNumbers(int first, int second)
        {
            return first + second;
        }
    }
}