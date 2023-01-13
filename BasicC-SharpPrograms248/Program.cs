using System;

namespace BasicC_SharpPrograms248
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the basics c-sharp programs");
            Console.WriteLine("Enter first number: ");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.Exit ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter first number: ");
                    int first = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    int second = Convert.ToInt16(Console.ReadLine());
                    Calculator calculator1 = new Calculator(first, second);
                    calculator1.Addition();
                    break;
                case 2:
                    Console.WriteLine("Enter first number: ");
                    int third = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    int fourth = Convert.ToInt16(Console.ReadLine());
                    Calculator calculator2 = new Calculator(third, fourth);
                    calculator2.Substraction();
                    break;
                case 3:
                    Console.WriteLine("Enter first number: ");
                    int fithnum = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    int sixthnum = Convert.ToInt16(Console.ReadLine());
                    Calculator calculator3 = new Calculator(fithnum,sixthnum);
                    calculator3.Multiplication();
                    break;
                    case 4:
                    Console.WriteLine("Enter first number: ");
                    int number1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    int number2 = Convert.ToInt16(Console.ReadLine());
                    Calculator calculator4 = new Calculator(number1,number2);
                    calculator4.Division();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Select valid options only ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
