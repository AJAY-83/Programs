using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Facade_Pattern
{
   public class Main
    {
        /// <summary>
        /// MinFunction as function
        /// </summary>
        public void MinFunction()
        {
            try
            {
                BookFacade bookFacade = new BookFacade();
                bookFacade.CreateBookFunction();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
