using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //New code added to accept user words
            Console.WriteLine("First word:");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Second word:");
            string secondWord = Console.ReadLine();

            //New code to user select different numbers
            Console.WriteLine("First Number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            //New code added to manage arbitrary ranges
            Console.WriteLine("Range start:");
            int rangeNumberStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Range end:");
            int rangeNumberEnd = int.Parse(Console.ReadLine());

            //Cycle for to print the values from 1 to 100
            for (int i = rangeNumberStart; i <= rangeNumberEnd; i++)
            {
                //Logical conditions to know where to print a word or the numbers.
                if ((i % firstNumber == 0) && (i % secondNumber != 0))
                    Console.WriteLine(firstWord);
                else if ((i % secondNumber == 0) && (i % firstNumber != 0))
                    Console.WriteLine(secondWord);
                else if ((i % firstNumber == 0) && (i % secondNumber == 0))
                    Console.WriteLine(firstWord+secondWord);
                else
                    Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
