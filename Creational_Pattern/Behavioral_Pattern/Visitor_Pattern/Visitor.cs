// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="Visitor.cs" company="Bridgelabz">
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
    /// Visitor class as abstract 
    /// </summary>
    public abstract class Visitor
    {
        /// <summary>
        /// ConcreteElementA as function
        /// </summary>
        /// <param name="concreteElementA">concreteElementA as object</param>
        public abstract void ConcreteElementA(ConcreteElementA concreteElementA);

        /// <summary>
        /// ConcreteElementB as function
        /// </summary>
        /// <param name="concreteElementBClass">concreteElementB as object</param>
        public abstract void ConcreteElementB(ConcreteElementB concreteElementB);
    }
}
