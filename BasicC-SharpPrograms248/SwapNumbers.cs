using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    /// <summary>
    /// SwapNumbers class created for swap two numbers
    /// </summary>
    public class SwapNumbers
    {
        /// <summary>
        /// Swap two numbers without using third variable
        /// </summary>
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("Enter values for a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Values of a and b before swapping: {0} {1} ", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Values of a and b after swapping: {0} {1} ", a, b);
        }
    }
}
