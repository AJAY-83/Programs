using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Adapter_Pattern
{
   public class Adapter
    {
        /// <summary>
        /// ListOfProductDetails as function
        /// </summary>
        /// <returns>return string</returns>
        public List<string> ListOfProductDetails()
        {
            //// Use List as generic collection type
            List<string> news = new List<string>();
            try
            {
                Console.WriteLine("Industrial News");
                Console.WriteLine("Television News");
                Console.WriteLine("Educational News");
                Console.WriteLine("Share Market News");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return news;
        }
    }
}
