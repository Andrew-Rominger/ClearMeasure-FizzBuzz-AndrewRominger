using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FizzBuzzLib
{
    /// <inheritdoc />
    public class GenericMatchedWordNumberGenerator : IMatchedWordNumberGenerator
    {
        private readonly IMatchedWordNumberPrinter _printer;

        /// <inheritdoc />
        public IReadOnlyDictionary<string, int[]> WordNumberMap { get; }

        /// <summary>
        /// Creates an instance of the GenericMatchedWordNumberGenerator type.
        /// </summary>
        /// <param name="wordNumberMap">The string-number map to use when replacing numbers while generating.</param>
        /// <param name="printer">The object to use when printing results.</param>
        public GenericMatchedWordNumberGenerator(IDictionary<string, int[]> wordNumberMap, IMatchedWordNumberPrinter printer)
        {
            _printer = printer;
            WordNumberMap = new ReadOnlyDictionary<string, int[]>(wordNumberMap);
        }

        /// <inheritdoc />
        public void GenerateMatchedString(int upperBound, int lowerBound = 1)
        {
            if (lowerBound > upperBound)
                throw new ArgumentException("Upper bound must be larger than lower bound", nameof(upperBound));
            
            for (var i = lowerBound; i <= upperBound; i++)
            {
                var flag = false;
                foreach (var pair in WordNumberMap)
                {
                    if (pair.Value.Any(j => i % j == 0))
                    {
                        flag = true;
                        _printer.Append(pair.Key);
                    }
                }
                if (!flag)
                {
                    _printer.Append(i.ToString());
                }
                _printer.NextLine();
            }
        }
    }
}
