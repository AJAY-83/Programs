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
                    Console.WriteLine("Remaining Amount is " + x);
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
        
        /*************************** Monthly Salary ********************************************************************************/
       
        /// <summary>
        /// Monthlies the sal.
        /// </summary>
        /// <param name="p">The p is payment</param>
        /// <param name="y">The y is year</param>
        /// <param name="r">The r </param>
        /// <returns>Return the payment</returns>
      public double MonthlySal(double p, double y, double r)
        {
            double n = 12 * y;
         double r1 = r / (12 * 100);

            double num = p * r1;
            double power = (double)Math.Pow(1 + r1, -n);
            double deno = 1 - power;
            double payment = num / deno;
            return payment;
        }

        /********************* Square Root **********************************************************************************/
       
        /// <summary>
        /// Gates the square root.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>return t as square root</returns>
        public int GateSquareRoot(double c)
        {
            double t = c;
            ////epsiloln formula 
            double epsilon = 1e-15;
            while (Math.Abs((t - c) / t) > (epsilon * t))
            {
                t = ((c / t) + t) / 2.0;                
            }
            ////convert the double into integer
            int t1 = Convert.ToInt32(t);
            ////retrun the t1
            return t1;
        }

        /**************************** Decimmal to Binary ************************************************************/

        /// <summary>
        /// Converts to binary.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>return convert as a string that is binary number</returns>
        public string ToBinary(int number)
        {
            //// convert is string is used to stored the binary number
            string convert = " ";
            //// it is use to stored remainder 
            int rem;

            ////while loop execute the till number is > 0
            while (number > 0)
            { 
                rem = number % 2;
                ////  convert stored the remainder value into the convert variable
                convert = rem + " " + convert;
                ///// number divide the 2 
                number = number / 2;
            }
            ////return the converted string
            //// that having  the binary number
            return convert;
        }

        /*************************** Binary To Decimal *********************************************************************************/

        /// <summary>
        /// Binaries to decimal.
        /// </summary>
        /// <param name="b">The b.</param>
        /// <returns> Return the decimal number</returns>
        public int BinaryToDecimal(int b)
        {
            //// double type decimal number to store the decimal value
            double deciml = 0;
            int n = 0;

            while (true)
            {
                if (b == 0)
                {
                    break;
                }
                else
                {
                    int temp = b % 10;
                    deciml += temp * Math.Pow(2, n);
                    b = b / 10;
                    n++;
                }
            }

            int result = Convert.ToInt32(deciml);
            return result;
        }
    }
}