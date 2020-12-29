using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    /// <summary>
    /// Matched word number generator that uses the standard "FizzBuzz" configuration.
    /// </summary>
    public class FizzBuzzGenerator : GenericMatchedWordNumberGenerator
    {
        /// <summary>
        /// Creates an instance of the FizzBuzzGenerator type.
        /// </summary>
        public FizzBuzzGenerator(IMatchedWordNumberPrinter printer) : base(new Dictionary<string, int[]> {{"Fizz", new []{3}}, {"Buzz", new []{5}}}, printer)
        {
        }
    }
}
