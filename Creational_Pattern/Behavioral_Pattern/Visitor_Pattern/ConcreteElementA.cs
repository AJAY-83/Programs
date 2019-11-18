// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ConcreteElementA.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Behavioral_Pattern.Visitor_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ConcreteElementA class have the inherited from the Element abstract class
    /// </summary>
    public class ConcreteElementA : Element
    {
        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitorClass"> Visitor visitor</param>
        public override void AcceptVisitor(Visitor visitor)
        {
            try
            {
                visitor.ConcreteElementA(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
