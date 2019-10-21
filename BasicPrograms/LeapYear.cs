﻿//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class is use to Find the Entered Year is leap Year or Not
    /// </summary>
   public class LeapYear
    {
      /// <summary>
     /// The utility  in that All Logic are Written
     /// </summary>
       readonly Utility utility = new Utility();
        /// <summary>
        /// Finds the leap year.
        /// </summary>
        public void FindLeapYear()
        {
            int year;
            Console.WriteLine("Enter the Year ");
            year = this.utility.ReadInt();

            ////Boolean Result to take Output from Utility class is return
          bool result = this.utility.LeapYear(year);

            if (result)
            {
                Console.WriteLine("{0} is Leap Year ", year);
            }
            else
            {
                Console.WriteLine("{0} is Not Leap Year ", year);
            }
        }
    }
}