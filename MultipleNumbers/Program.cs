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
            //Cycle for to print the values from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                //Logical conditions to know where to print a word or the numbers.
                if ((i % 3 == 0) && (i % 5 != 0))
                    Console.WriteLine("Conversion");
                else if ((i % 5 == 0) && (i % 3 != 0))
                    Console.WriteLine("Mob");
                else if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine("ConversionMob");
                else
                    Console.WriteLine(i);

            }
            Console.Read();
        }
    }
}
