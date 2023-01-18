using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    /// <summary>
    /// Powerof2 class created for find power of two
    /// </summary>
    public class Powerof2
    {
        public static int number;
        public static int power;
        /// <summary>
        /// find power of two
        /// </summary>
        public static void FindPowerOfTwo()
        {
            Console.WriteLine("Enter number until find power of two :");
            number = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=number;i++)
            {
                power = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine("power of {0} is {1} ", i, power);
            }
        }
    }
}
