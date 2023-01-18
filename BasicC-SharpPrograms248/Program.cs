using System;

namespace BasicC_SharpPrograms248
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the basics c-sharp programs");
                Console.WriteLine("Select given options");
                Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.WeekDays\n6.Findleapyear\n7.FindPowerOfTwo\n8.SwapTwoNumbers\n9.CheckAlphabetIsVowelOrConsonant\n10.FindPrimeFactors\n11.CheckVotingAge\n12.Exit\n");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter first number: ");
                        int first = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        int second = Convert.ToInt16(Console.ReadLine());
                        Calculator calculator1 = new Calculator(first, second);
                        calculator1.Addition();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter first number: ");
                        int third = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        int fourth = Convert.ToInt16(Console.ReadLine());
                        Calculator calculator2 = new Calculator(third, fourth);
                        calculator2.Substraction();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter first number: ");
                        int fithnum = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        int sixthnum = Convert.ToInt16(Console.ReadLine());
                        Calculator calculator3 = new Calculator(fithnum, sixthnum);
                        calculator3.Multiplication();
                        break;
                    case 4:
                        Console.WriteLine("Enter first number: ");
                        int number1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        int number2 = Convert.ToInt16(Console.ReadLine());
                        Calculator calculator4 = new Calculator(number1, number2);
                        calculator4.Division();
                        break;
                    case 5:
                        Console.Clear();
                        Week.WeekDays();
                        break;
                    case 6:
                        Console.Clear();
                        LeapYear.FindLeapYear();
                        break;
                    case 7:
                        Console.Clear();
                        Powerof2.FindPowerOfTwo();
                        break;
                    case 8:
                        Console.Clear();
                        SwapNumbers.SwapTwoNumbers();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Enter character for checking Vowel or Consonant");
                        char vowel = Convert.ToChar(Console.ReadLine());
                        Alphabet alphabet = new Alphabet(vowel);
                        alphabet.CheckAlphabetIsVowelOrConsonant();
                        break;
                    case 10:
                        Console.Clear();
                        PrimeFactors.PrintPrimeFactors();
                        break;
                    case 11:
                        Console.Clear();
                        VotingAge votingAge=new VotingAge();
                        votingAge.CheckVotingAge();
                        break;
                    case 12:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select valid options only ");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
