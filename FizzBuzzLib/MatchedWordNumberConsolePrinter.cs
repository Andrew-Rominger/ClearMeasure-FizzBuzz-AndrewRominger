using System;

namespace FizzBuzzLib
{
    /// <summary>
    /// Simple implementation of IMatchedWordNumberPrinter that prints to the console.
    /// </summary>
    public class MatchedWordNumberConsolePrinter : IMatchedWordNumberPrinter
    {
        /// <inheritdoc />
        public void Append(string toAppend)
        {
            Console.Write(toAppend);
        }

        /// <inheritdoc />
        public void NextLine()
        {
            Console.WriteLine();
        }
    }
}
