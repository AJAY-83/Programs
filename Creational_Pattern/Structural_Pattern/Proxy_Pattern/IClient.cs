// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="IClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Structural_Pattern.Proxy_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IClient is the Interface 
    /// In that have get GetData
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// GetData as function.
        /// </summary>
        /// <returns>return string</returns>
        string GetData();
    }
}
