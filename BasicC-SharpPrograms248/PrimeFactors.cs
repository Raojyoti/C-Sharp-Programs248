using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    /// <summary>
    /// PrimeFactors class created to Print the prime factors of number N.
    /// </summary>
    public class PrimeFactors
    {
        //static variable
        public static int number;

        /// <summary>
        /// Use static method to Print the prime factors of number N.
        /// </summary>
        public static void PrintPrimeFactors()
        {
            Console.Write("Enter number which you want to find prime factor: ");
            number=Convert.ToInt32(Console.ReadLine());
            for(int i=2; i<=number; i++)
            {
                while(number%i==0)
                {
                    number = number / i;
                    Console.WriteLine(i);
                }
            }
            if(number>2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
