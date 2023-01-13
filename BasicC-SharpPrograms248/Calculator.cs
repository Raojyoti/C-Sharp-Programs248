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
        /// <summary>
        /// Substraction of two numbers to get difference
        /// </summary>
        public void Substraction()
        {
            result = Math.Abs(first - second);
            Console.WriteLine("Difference : " + result);
        }
        /// <summary>
        /// Multiplication of two numbers to get products
        /// </summary>
        public void Multiplication()
        {
            result = first * second;
            Console.WriteLine("Products : " + result);
        }
    }
}
