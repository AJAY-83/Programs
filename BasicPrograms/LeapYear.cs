using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    /// <summary>
    /// this class is use to Find the Entered Year is leap Year or Not
    /// </summary>

    class LeapYear
    {
        ////utility in that All Logic are Written

        Utility utility = new Utility();

        ////Function to useEnter the User input 

        public void FindLeapYear()
        {
            int Year;
            Console.WriteLine("Enter the Year ");
            Year = this.utility.ReadInt();

            ////Boolean Result to take Output from Utility class is return
          Boolean Result = this.utility.LeapYear(Year);

            if (Result)
            {
                Console.WriteLine("{0} is Leap Year ", Year);
            }
            else
            {
                Console.WriteLine("{0} is Not Leap Year ", Year);
            }

        }////End FindLeapYear

    }////End theLeapYear class
}////End the namespace
