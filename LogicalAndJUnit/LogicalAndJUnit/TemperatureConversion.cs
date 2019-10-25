//-----------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Conversion class is use to Convert the  To Fahrenheit
    /// </summary>
   public class TemperatureConversion
    {
        /// <summary>
        /// The utility have the logic inside the Utility.cs file
        /// </summary>
       private readonly Utility utility = new Utility();

        /// <summary>
        /// Temporaries the conversion method.
        /// </summary>
        public void TempConversion()
        { 
            ////take the user Input in Celcius
            Console.WriteLine("Enter the Celcius input :");
           double c = this.utility.ReadDouble();

            ////take theuser input in Fahrenheit
            Console.WriteLine("Enter the Fahrenheit input :");
            double f = this.utility.ReadDouble();

            ////formula to convert the Celcius To Fahrenheit
            double celciusToFahrenheit = (c * 9 / 5) + 32;
            ////formula to convert the Fahrenheit To Celcius
            double fahrenheitToCelcius = (f - 32) * 5 / 9;

            ////print the values
            Console.WriteLine("Celcius To Fahrenheit" + celciusToFahrenheit);
            Console.WriteLine("Fahrenheit To Celcius" + fahrenheitToCelcius);
        }
    }
}
