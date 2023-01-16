using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    public class LeapYear
    {
        static int year;
        public static void FindLeapYear()
        {
            Console.WriteLine("Enter four digit year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
        }
    }
}
