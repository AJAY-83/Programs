using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Observer_Pattern
{
   public class Observer
    {
        /// <summary>
        /// ObserverFunction as function
        /// </summary>
        public static void ObserverFunction()
        {
            try
            {
                //// create Instance od an CompanyClass class.
                Company company = new Company("Capgemini", 100.00);
                company.Attach(new Inventory("Attach"));
                company.Detach(new Inventory("Detach"));

                company.Price = 100.10;
                company.Price = 100.20;
                company.Price = 100.30;
                company.Price = 100.40;

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
