// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="IMediator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Behavioral_Pattern.Mediator_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IMediator is the interface in that have the one method 
    /// that will implement by the inherited classes 
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        /// SendMessage() have the 
        /// </summary>
        /// <param name="caller">caller</param>
        /// <param name="msg">msg</param>
        void SendMessage(Colleague caller, string msg);
    }
}