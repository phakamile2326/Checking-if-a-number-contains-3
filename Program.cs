using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_if_a_number_contains_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int IntToFind = 3;

            number1 = 7201432;
            number2 = 87501;

            bool containsIntToFind = number1.ToString().Contains(IntToFind.ToString());
            if (containsIntToFind)
            {
                Console.WriteLine("\n");
                Console.WriteLine(number1 + " contains the digit " + IntToFind);
            }
            else
            {
                Console.WriteLine(number1+"does not contain the digit " + IntToFind);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("\n\n");
            containsIntToFind = number2.ToString().Contains(IntToFind.ToString());
            if (containsIntToFind)
            {
                Console.WriteLine("\n");
                Console.WriteLine(number2 + " contains the digit" + IntToFind);

            }
            else 
            {
                Console.WriteLine(number2 + " does not contain the digit " + IntToFind);
            }
            Console.Read();
        }
    }
}
