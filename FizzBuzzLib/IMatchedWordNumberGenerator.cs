using System.Collections.Generic;

namespace FizzBuzzLib
{
    /// <summary>
    /// Represents an object that can generate a string using a collection of mapped strings and integers.
    /// </summary>
    public interface IMatchedWordNumberGenerator
    {
        /// <summary>
        /// Read-only map of strings to their corresponding collection of integers to replace.
        /// </summary>
        public IReadOnlyDictionary<string, int[]> WordNumberMap { get; }

        /// <summary>
        /// Generates a string which contains the range of numbers between 2 bounds. The numbers are replaced with strings based on if the value of the number is evenly divisible by any number in that string's mapped value from the WordNumberMap.
        /// </summary>
        /// <param name="upperBound">The inclusive upper bound to generate numbers to.</param>
        /// <param name="lowerBound">The inclusive lower bound to start generating numbers from</param>
        void GenerateMatchedString(int upperBound, int lowerBound = 1);
    }
}
