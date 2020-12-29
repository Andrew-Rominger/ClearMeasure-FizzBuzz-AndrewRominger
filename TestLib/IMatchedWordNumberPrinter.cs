namespace FizzBuzzLib
{
    /// <summary>
    /// Represents an object that can handle printing of the output from a matched number generator.
    /// </summary>
    public interface IMatchedWordNumberPrinter
    {
        /// <summary>
        /// Appends a string onto the current line.
        /// </summary>
        /// <param name="toAppend">The string to append.</param>
        void Append(string toAppend);

        /// <summary>
        /// Finishes writing the current line and starts a new one.
        /// </summary>
        void NextLine();
    }
}
