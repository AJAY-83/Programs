﻿//-----------------------------------------------------------------------
// <copyright file="WildChill.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// WildChill class is use convert temperature fahrenheit
    /// </summary>
public class WildChill
    {
        readonly Utility utility = new Utility();

        /// <summary>
        /// Converts the temporary.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        public void ConvertTemp(string first,string second)
        {

         int temperature = Convert.ToInt32(first);
         int speed = Convert.ToInt32(second);
           //// Here call the Tempreture function that  is written in utility classs
            double result = utility.Tepreture(temperature, speed);
            //// Then print the reulst that is send by Utility class
            Console.WriteLine(result);  
        }
    }
}
