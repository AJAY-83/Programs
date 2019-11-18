// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ConcreteColleagueB.cs" Company="Bridgelabz">
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
    /// ConcreteColleagueB class is inherited from the Abstract Colleague
    /// </summary>
    public class ConcreteColleagueB : Colleague
    {
        /// <summary>
        /// ConcreteColleagueB class have the constructor 
        /// </summary>
        /// <param name="mediator"></param>
        public ConcreteColleagueB(IMediator mediator) : base(mediator) { }

        /// <summary>
        ///  Send() is used to show the message that are from B Concrete class
        /// </summary>
        /// <param name="msg">message</param>
    public void Send(string msg)
    {
     Console.WriteLine("B send message:" + msg);
    _mediator.SendMessage(this, msg);
    }

        /// <summary>
        /// Receive() method have the body with some details
        /// that will response the receive message
        /// </summary>
        /// <param name="msg">message</param>
    public void Receive(string msg)
    {
        Console.WriteLine("B receive message:" + msg);
    }
  }
}
