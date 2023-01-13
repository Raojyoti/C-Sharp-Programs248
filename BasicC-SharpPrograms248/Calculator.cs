using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    /// <summary>
    /// Calculator class created to perform arithmetic operations
    /// </summary>
    public class Calculator
    {
        // instance variables
        public int first;
        public int second;
        public double result;

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        public Calculator(int firstNumber, int secondNumber)
        {
            first = firstNumber;
            second = secondNumber;
        }
        /// <summary>
        /// Addition of two numbers to get sum
        /// </summary>
        public void Addition()
        {
            result = first + second;
            Console.WriteLine("Sum : " + result);
        }
    }
}
