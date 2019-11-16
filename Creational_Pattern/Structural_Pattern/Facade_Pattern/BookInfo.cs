using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Facade_Pattern
{
   public class BookInfo
    {
        /// <summary>
        /// BookInformation as function
        /// </summary>
        public void BookInformation()
        {
            try
            {
                Console.WriteLine("Book Info class function called");
                Console.WriteLine("Book price");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select your standard");
                string standard = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
