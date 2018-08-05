using System;

namespace Salary1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: ");
            Console.WriteLine("");

            Console.WriteLine("Hourly Rate? :  ");
            string ratestr1 = Console.ReadLine();
            double rate1 = Convert.ToInt64(ratestr1);
            Console.WriteLine("Hours worked per week? :  ");
            string hoursstr1 = Console.ReadLine();
            double hours1 = Convert.ToInt64(hoursstr1);
            Console.WriteLine("");

            Console.WriteLine("Person 2: ");
            Console.WriteLine("");

            Console.WriteLine("Hourly Rate? :");
            string ratestr2 = Console.ReadLine();
            double rate2 = Convert.ToInt64(ratestr2);
            Console.WriteLine("Hours worked per week? :");
            string hoursstr2 = Console.ReadLine();
            double hours2 = Convert.ToInt64(hoursstr2);
            Console.WriteLine("");

            double AnnualSalary1 = ((rate1 * hours1) * 52);
            double AnnualSalary2 = ((rate2 * hours2) * 52);

            Console.WriteLine("Annual salary of person 1 : ");
            Console.WriteLine(AnnualSalary1);
            Console.WriteLine("Annual salary of person 2 : ");
            Console.WriteLine(AnnualSalary2);
            Console.WriteLine("");

            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            if (AnnualSalary1 > AnnualSalary2) Console.WriteLine("TRUE");
            else Console.WriteLine("FALSE");

            Console.Read();

        }
    }
}

