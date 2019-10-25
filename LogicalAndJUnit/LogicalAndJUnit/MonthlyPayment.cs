//-----------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// calculate the monthly salary
    /// </summary>
   public class MonthlyPayment
    {
        /// <summary>
        /// Function calculates the monthly salary using formula.
        /// </summary>
        public void MonthlyPay()
        {
            Utility utility = new Utility();

            //// Enter the salary from user
            Console.WriteLine("Enter payment amount : ");
            int p = Convert.ToInt32(Console.ReadLine());

            ////Enter the how much year payment are remaining
            Console.WriteLine("Enter year : ");
            int y = Convert.ToInt32(Console.ReadLine());

            //// Rate of Intrest on it
            Console.WriteLine("Enter interest : ");
            int r = Convert.ToInt32(Console.ReadLine());

            //// take into one variable
            double payment = utility.MonthlySal(p, y, r);

            ////Print the monly payment
            Console.WriteLine("The monthly payment is : " + payment);
        }
    }
}
