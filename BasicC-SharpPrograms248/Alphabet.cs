using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    /// <summary>
    /// Alphabet class created to Check Whether an Alphabet is Vowel or Consonant
    /// </summary>
    public class Alphabet
    {
         // instance variables
       public char vowel;
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="vowel"></param>
        public Alphabet(char vowelChar)
        {
            vowel = vowelChar;
        }
        /// <summary>
        /// Check an Alphabet is Vowel or Consonant
        /// </summary>
        public void CheckAlphabetIsVowelOrConsonant()
        {
            switch(vowel)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("{0} is vowel", vowel);
                    break;
                default:
                    Console.WriteLine("{0} is Consonant", vowel);
                    break;
            }

        }
    }
}
