//-----------------------------------------------------------------------
// <copyright file="PrimeFactores.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// finds the prime Factors and display
    /// </summary>
    public class PrimeFactores
    {
        /// <summary>
        /// This is utility class in that have the all logical part
        /// </summary>
     readonly Utility utility = new Utility();
        /// <summary>
        /// The number is user input to find that number factors
        /// </summary>
       private int number;
        /// <summary>
        /// Find the Number Is prime or Not
        /// </summary
        public void IsPrime()
        {
          
        Console.WriteLine("Enter the Number : ");
            number = this.utility.ReadInt();
            for (int i = 2; i*i<= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine("{0}", i);
                    number = number / i;
                }
            }
            if (number > 1)
            {
                Console.WriteLine("{0}",number);
            }
          
        }
    }
}
