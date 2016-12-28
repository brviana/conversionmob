using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {

            //User values insertion
            Console.WriteLine("Insert EUROS:");
            double euros = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert TAX:");
            double tax = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //Function is defined
            Func<double, double, double[]> taxfunc = TaxCalculation;

            //Reads the array and prints the results to the console as string
            foreach (var item in taxfunc(euros, tax))
            {
                Console.WriteLine("The tax value is: {0}", item.ToString() + "cents.");
            }
            Console.Read();
        }

        #region ******** FUNCTION TAXCALCULATION ********
        public static double[] TaxCalculation(double euros, double tax)
        {
            //Array created and returns all values from it
            double[] totalTaxCents = { (euros * 100) * (tax / 100) };
            return totalTaxCents;
        }
        #endregion
    }
}
