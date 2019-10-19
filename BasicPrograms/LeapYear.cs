using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
   
    class LeapYear
    {
        Utility utility = new Utility();

        public void FindLeapYear()
        {
            int Year;
            Console.WriteLine("Enter the Year ");
            Year = utility.ReadInt();

          Boolean Result = utility.LeapYear(Year);
            if (Result)
            {
                Console.WriteLine("{0} is Leap Year ", Year);
            }
            else
            {
                Console.WriteLine("{0} is Not Leap Year ", Year);
            }

        }

    }
}
