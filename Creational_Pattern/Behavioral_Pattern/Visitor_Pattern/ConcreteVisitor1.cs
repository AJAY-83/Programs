// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ConcreteVisitor1.cs" company="Bridgelabz">
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
    /// ConcreteVisitor1 class have the Visitor abstract class
    /// </summary>
    public class ConcreteVisitor1 : Visitor
    {
        /// <summary>
        /// concreteElementB create a instance of this class
        /// </summary>
        private object concreteElementB;

        /// <summary>
        /// ConcreteElementA as function
        /// </summary>
        /// <param name="concreteElementA">concreteElementA as object</param>
        public override void ConcreteElementA(ConcreteElementA concreteElementA)
        {
            try
            {
                Console.WriteLine("{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ConcreteElementB as function
        /// </summary>
        /// <param name="concreteElementBClass">concreteElementBClass as object</param>
        public override void ConcreteElementB(ConcreteElementB concreteElement)
        {
            try
            {
                Console.WriteLine("{0} Visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
