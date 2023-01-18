using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    /// <summary>
    /// PerfectNumber class created to check given number is Perfect number or not
    /// </summary>
    public class PerfectNumber
    {
        // instance variable
        public int number;
        public int sum = 0;

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="number"></param>
        public PerfectNumber(int number)
        {
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum = sum + i;
            }
            if (sum == number)
                Console.WriteLine("{0} is a Perfect Number", number);
            else
                Console.WriteLine("{0} is not a Perfect Number", number);
        }
    }
}
