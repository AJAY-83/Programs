﻿// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ProxyClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Structural_Pattern.Proxy_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ProxyClient:IClient
    {
        /// <summary>
        /// RealClientClass as class
        /// </summary>
        private RealClient client = new RealClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyClientClass"/> class.
        /// </summary>
        public ProxyClient()
        {
            try
            {
                //// Prints the message
                Console.WriteLine("ProxyClient: Initialized");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// GetData as function
        /// </summary>
        /// <returns>return string</returns>
        public string GetData()
        {
            return this.client.GetData();
        }
    }
}
