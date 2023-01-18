using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    /// <summary>
    /// Week class created for find day
    /// </summary>
    public class Week
    {
        /// <summary>
        /// Using switch case to find day fall in week
        /// </summary>
        public static void WeekDays()
        {
            Console.WriteLine("Please enter day number: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());
            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("Day {0} is Sunday", dayNumber);
                    break;
                case 2:
                    Console.WriteLine("Day {0} is Monday", dayNumber);
                    break;
                case 3:
                    Console.WriteLine("Day {0} is Tuesday", dayNumber);
                    break;
                case 4:
                    Console.WriteLine("Day {0} is Wednesday", dayNumber);
                    break;
                case 5:
                    Console.WriteLine("Day {0} is Thursday", dayNumber);
                    break;
                case 6:
                    Console.WriteLine("Day {0} is Friday", dayNumber);
                    break;
                case 7:
                    Console.WriteLine("Day {0} is Saturday", dayNumber);
                    break;
                case 8:
                    Console.WriteLine("Select daynumber from 1 to 7 only");
                    break;
            }
        }
    }
}
