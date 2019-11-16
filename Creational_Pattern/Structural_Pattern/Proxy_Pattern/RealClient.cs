using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Proxy_Pattern
{
    public class RealClient:IClient
    {
        /// <summary>
        /// data as private field
        /// </summary>
        private string data;

        /// <summary>
        /// Initializes a new instance of the <see cref="RealClientClass"/> class.
        /// </summary>
        public RealClient()
        {
            //// Constructor message when called
            Console.WriteLine("Real Client: Initialized");
            this.data = "Dot Net Tricks";
        }

        /// <summary>
        /// GetData as function
        /// </summary>
        /// <returns>return string</returns>
        public string GetData()
        {
            return this.data;
        }
    }
}
