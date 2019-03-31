namespace CommandPattern.Handlers
{
    /// <summary>
    /// Handler to add two numbers
    /// </summary>
    public interface IAddTwoNumbersHandler
    {
        /// <summary>
        /// Will add two numbers together and return their result
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>int</returns>
        int AddTwoNumbers(int first, int second);
    }
}