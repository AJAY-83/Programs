//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
/*
 * @author Ajay J Lodale
 * 
 * @Since 21-10-2019
 *
 * @Purpose : Bridgelabz Assignments (Logical And JUnit)
 */
 /************************************************************************************************************************************************/
namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility class having all logical code
    /// </summary>
   public class Utility
    {
        /// <summary>
        /// Reads the Integer
        /// </summary>
        /// <returns>Return the Integer to the user</returns>
        public int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Reads the double.
        /// </summary>
        /// <returns>return  the  double type value to the user</returns>
        public double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns>Return the  string type values to the user</returns>
        public string ReadString()
        {
            return Convert.ToString(Console.ReadLine());
        }

/********************************* Vending Machine *****************************************************************************************************************/

        /// <summary>
        /// Moneys the specified x.
        /// </summary>
        /// <param name="x">The x is amount user want to withdraw</param>
        /// <param name="arr">The array is array in that have all available notes</param>
        public void Money(int x, int[] arr)
        {
            ////String str = " ";
            int count = 0;

            ////for two checks the available note 
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                ////check the amount the greater than the note available
                while (x >= arr[i])
                {
                    ////reduce thay amount from the array
                    x = x - arr[i];
                    ////print the remaining amounts
                    Console.WriteLine("Remaining Amount is ", x);
                    ////count is how much note are going out that much only
                    count++;
                }
            }

            Console.WriteLine("total Number of Notes " + count);
        }

        /************************************** Day Of Week *************************************************************************************/
        
         /// <summary>
        /// Days the is  method that will return the day
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="date">The date.</param>
        /// <param name="year">The year.</param>
        /// <returns>return the day</returns>
        public int DayIs(int month, int date, int year)
        {
            ////calculate the year in y variable
            int y = (year - (14 - month)) / 12;
            ////calculate the day
            int x = y + (y / 4) - (y / 100) + (y / 400);
            ////calculatre the month using this formula
            int m = ((month + 12) * (14 - month) / 12) - 2;
            ////calculate the day 
            int d = (date + x + ((31 * m) / 12)) % 7;
            ////retrun the day
            return d;
        }
    }
}
