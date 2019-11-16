using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Facade_Pattern
{
   public class UserData
    {
        /// <summary>
        /// UserDetails as function
        /// </summary>
        public void UserDetails()
        {
            try
            {
                Console.WriteLine("Enter your Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your first name");
                string fname = Console.ReadLine();
                Console.WriteLine("Enetr last name");
                string lname = Console.ReadLine();
                Console.WriteLine("Enter contact number");
                double contact = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
