using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLib;

namespace FizzBuzzTests.TestImplementations
{
    /// <summary>
    /// Implementation of IMatchedWordPrinter for testing. stores values for examination and assertion.
    /// </summary>
    public class TestMatchedWordNumberPrinter : IMatchedWordNumberPrinter
    {
        private StringBuilder _sb = new StringBuilder();
        public List<string> CurrentPrintValue { get;  } = new List<string>();

        public void Append(string toAppend)
        {
            _sb.Append(toAppend);
        }

        public void NextLine()
        {
            CurrentPrintValue.Add(_sb.ToString());
            _sb = new StringBuilder();
        }
    }
}
