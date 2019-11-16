using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Adapter_Pattern
{
    public class Shopping
    {
        /// <summary>
        /// AdapterFunction as function
        /// </summary>
        public void AdapterFunction()
        {
            try
            {
                //// create Instance of an interface an class assign to that interface
                IAdapter adapter = new VenderAdapter();

                //// access all values in GetProductDetails using foreach loop.
                foreach (string product in adapter.GetProductDetails())
                {
                    Console.WriteLine(product);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
