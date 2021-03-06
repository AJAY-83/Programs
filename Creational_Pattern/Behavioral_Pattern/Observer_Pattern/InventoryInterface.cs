﻿// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="InventoryInterface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Behavioral_Pattern.Observer_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InventoryInterface is the interface is used to update the details
    /// </summary>
    public interface InventoryInterface
    {
        /// <summary>
        /// Update as function
        /// </summary>
        /// <param name="stock">stockClass as object</param>
        void Update(Stock stock);
    }
}
