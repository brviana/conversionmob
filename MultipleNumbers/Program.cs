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

            //Cycle for to print the values from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                //Logical conditions to know where to print a word or the numbers.
                if ((i % 3 == 0) && (i % 5 != 0))
                    Console.WriteLine(firstWord);
                else if ((i % 5 == 0) && (i % 3 != 0))
                    Console.WriteLine(secondWord);
                else if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine(firstWord+secondWord);
                else
                    Console.WriteLine(i);

            }
            Console.Read();
        }
    }
}
