// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ConcreteElementB.cs" company="Bridgelabz">
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
    /// ConcreteElementB class have the Element abstract class
    /// </summary>
    public class ConcreteElementB : Element
    {
        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitor">visitor as object</param>
        public override void AcceptVisitor(Visitor visitor)
        {
            try
            {
                visitor.ConcreteElementB(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
