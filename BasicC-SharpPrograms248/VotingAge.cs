using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_SharpPrograms248
{
    /// <summary>
    /// VotingAge class created to check Age for Voting
    /// </summary>
    public class VotingAge
    {
        // instance variables
        public int requiredAge;
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="eligibleAge"></param>
        public VotingAge(int eligibleAge)
        {
            requiredAge = eligibleAge;
        }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public VotingAge()
        {
            Console.WriteLine("Welcome to the voting age process");
        }
        /// <summary>
        /// Checking Age for Voting
        /// </summary>
        public void CheckVotingAge()
        {
            Console.Write("Please enter your age: ");
            requiredAge = Convert.ToInt32(Console.ReadLine());
            if(requiredAge>18)
            {
                Console.WriteLine("Your age are eligible for give vote");
            }
            else
            {
                Console.WriteLine("Your age are not eligible for give vote because your age is less the 18");
            }
        }
    }
}
