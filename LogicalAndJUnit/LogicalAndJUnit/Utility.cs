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
    }
}
