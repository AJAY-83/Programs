// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ConcreteMediator.cs" Company="Bridgelabz">
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
    /// ConcreteMediator class have the SendMessage that is use for the calling the method
    /// </summary>
    public class ConcreteMediator : IMediator
    {
        /// <summary>
        /// Gets or Sets is used for getting value and returning that will back.
        /// ConcreteColleagueA class have the  Colleague1 instance of the class
        /// </summary>
        public ConcreteColleagueA Colleague1 { get; set; }

       ////public ConcreteColleagueB Colleague2 { get; set; }

            /// <summary>
            /// SendMessage is use the send the message or receive message
            /// </summary>
            /// <param name="caller">caller</param>
            /// <param name="msg">msg</param>
        public void SendMessage(Colleague caller, string msg)
        {
            if (caller == Colleague1)
            {
                //     Colleague2.Receive(msg);
            }
            else
            {
                Colleague1.Receive(msg);
            }
                
        }
    }
}
