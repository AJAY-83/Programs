//-----------------------------------------------------------------------
// <copyright file="CouponNumber.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The CouponNumbers
    /// </summary>
    public class CouponNumber
    {
        /// <summary>
        /// The Random function gives the random number
        /// </summary>
       private readonly Random rand = new Random();

        /// <summary>
        /// Print the coupon.
        /// </summary>
        public void GenrateCoupon()
        {
            Console.WriteLine("Printing 10 random numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} -> {1}", i, this.rand.Next());
            }
        }
    }
}