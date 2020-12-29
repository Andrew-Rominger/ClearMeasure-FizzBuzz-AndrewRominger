using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzLib;

namespace TestApp
{
    class Program
    {
        private static IMatchedWordNumberPrinter _printer;

        static void Main(string[] args)
        {
            _printer = new MatchedWordNumberConsolePrinter();
            while (PrintMenu() == 1)
            {
            }
        }

        private static int PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Regular FizzBuzz");
            Console.WriteLine("2. Generic Matched Word");
            Console.WriteLine("3. Quit");
            Console.Write("Select: ");

            var result = Console.ReadLine();
            try
            {
                var resultValue = Convert.ToInt32(result);
                switch (resultValue)
                {
                    case 1:
                        SimpleFizzBuzz();
                        return 1;
                    case 2: 
                        GenericMatchedNumber();
                        return 1;
                    case 3:
                        return -1;
                    default:
                        Console.WriteLine("Invalid Entry. Try again.");
                        return -1;
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Failed to parse '{result}' into an int. Try again.");
                return -1;
            }
        }

        public static void SimpleFizzBuzz()
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator(_printer);
            fizzBuzzGenerator.GenerateMatchedString(100);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        public static void GenericMatchedNumber()
        {
            // Will print "Foo" if a number is divisible by 4 or 5, will print "Bar" if a number is divisible by 7
            var testGenerator = new GenericMatchedWordNumberGenerator(new Dictionary<string, int[]>
            {
                {"Foo", new []{4,5}},
                {"Bar", new []{7}}
            }, _printer);
            testGenerator.GenerateMatchedString(700);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
