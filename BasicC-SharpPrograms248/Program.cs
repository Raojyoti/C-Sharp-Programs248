using System;

namespace BasicC_SharpPrograms248
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the basics c-sharp programs");
            Console.WriteLine("Enter first number: ");
            int first = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int second = Convert.ToInt16(Console.ReadLine());
            Calculator calculator1 = new Calculator(first, second);
            calculator1.Addition();
        }
    }
}
