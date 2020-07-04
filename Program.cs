using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_ProgressiveTaxation
{
    class Program
    {
        static void Main(string[] args)
        {
            Brackets taxBrackets = new Brackets();
            string userInput;
            float income;

            Console.WriteLine("Taxation calculator per brackets.");
            Console.WriteLine("Default brackets used in the code");
            Console.WriteLine(" 10,000       ||    0.00 (0%)");
            Console.WriteLine(" 30,000       ||    0.10 (10%)");
            Console.WriteLine("100,000       ||    0.25 (25%)");
            Console.WriteLine("Over 100,000  ||    0.40 (40%)");
            Console.Write("Enter income to process and calculate tax due: ");

            userInput = Console.ReadLine();

            if (float.TryParse(userInput, out income))
            {
                Console.WriteLine();
                Console.WriteLine("Processing {0}", userInput);
                Console.WriteLine();
                Console.WriteLine("The amount of tax due based on income is -> {0}", taxBrackets.TaxCalculation(income));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid user input! restart application.");
            }

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
