//-----------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DayOfWeek class is find the day
    /// </summary>
     public class DayOfWeek
    {
        /// <summary>
        /// The utility have the all logical part
        /// </summary>
      private readonly Utility utility = new Utility();

        /// <summary>
        /// Weeks the day WeekDay Methods find the days
        /// </summary>
       public void WeekDay()
        {
            Utility utility = new Utility();
            //// month variable stored the month
            //// year variable stored the year
            //// date varaible stored theday
            int month, year, date;
            //// da is array is have the week days
            string[] da = { "sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            ////take the date from user
            Console.WriteLine("Enter Date");
            date = Convert.ToInt32(Console.ReadLine());
            //// take the month from the user
            Console.WriteLine("Enter Month");
            month = Convert.ToInt32(Console.ReadLine());

            ////take the year from user
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
            ////dayIs() method  pass the three  parameter first is month second is day and last is year
            int d = utility.DayIs(month, date, year);
            ////print the user input
            Console.WriteLine("Entered date is " + date + "/" + month + "/" + year);
            ////  then print the the day
            Console.WriteLine("The day of week is " + da[d]);
        }
    }
}
