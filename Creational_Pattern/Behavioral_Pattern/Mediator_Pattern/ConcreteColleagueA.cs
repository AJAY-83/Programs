// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ConcreteColleague.cs" Company="Bridgelabz">
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
    /// ConcreteColleagueA class have two method send() and receive
    /// it is abstracted from Colleague
    /// </summary>
    public class ConcreteColleagueA : Colleague
    {
        /// <summary>
        /// ConcreteColleagueA(IMediator mediator) have the instance of the base class means super class
        /// </summary>
        /// <param name="mediator">IMediator</param>
        public ConcreteColleagueA(IMediator mediator) : base(mediator) { }

        /// <summary>
        /// Send()  sends the method. 
        /// </summary>
        /// <param name="msg">message</param>
        public void Send(string msg)
        {
            Console.WriteLine("A send message:" + msg);
            _mediator.SendMessage(this, msg);
        }

        /// <summary>
        /// Receive() is the another method
        /// that will show the Receive message
        /// </summary>
        /// <param name="msg">Message</param>
        public void Receive(string msg)
        {
            Console.WriteLine("A receive message:" + msg);
        }
    }
}