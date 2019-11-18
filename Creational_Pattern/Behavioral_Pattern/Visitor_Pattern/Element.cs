// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="Element.cs" company="Bridgelabz">
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
    /// Element is the abstract class 
    /// </summary>
    public abstract class Element
    {
        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitor">AcceptVisitor as object</param>
        public abstract void AcceptVisitor(Visitor visitor);
    }
}
