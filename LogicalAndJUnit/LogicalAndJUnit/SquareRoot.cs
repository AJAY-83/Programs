//-----------------------------------------------------------------------
// <copyright file="SquareRoot.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// squareRoot class is used to find the square root
    /// </summary>
    public class SquareRoot
    {
        /// <summary>
        /// Finds the square root.
        /// </summary>
        public void FindSquareRoot()
        {
            Utility utility = new Utility();
            ////take the user input
            Console.WriteLine("Enter number to find square root : ");
            double number = utility.ReadDouble();
            //// GateSquareRoot return input store in square variable 
            int square = utility.GateSquareRoot(number);
            //// print the output
            Console.WriteLine("Square root of entered number is : " + square);
        }
    }
}