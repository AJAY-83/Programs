using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Proxy_Pattern
{
   public class Proxy
    {
        /// <summary>
        /// ProxyFunction as function
        /// </summary>
        public void ProxyFunction()
        {
            try
            {
                //// create Instancr of an ProxyClientClass class.
                ProxyClient proxy = new ProxyClient();
                Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
