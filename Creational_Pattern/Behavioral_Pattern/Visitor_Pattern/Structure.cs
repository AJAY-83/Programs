// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="Structure.cs" company="Bridgelabz">
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
    /// Structure class have the attach or detach methods
    /// </summary>
    public class Structure
    {
        /// <summary>
        /// ElementClass as class
        /// </summary>
        private List<Element> elementClasses = new List<Element>();

        /// <summary>
        /// Attach as function
        /// </summary>
        /// <param name="element">element as object</param>
        public void Attach(Element element)
        {
            try
            {
                this.elementClasses.Add(element);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Detach as function
        /// </summary>
        /// <param name="element">element as object</param>
        public void Detach(Element element)
        {
            try
            {
                this.elementClasses.Remove(element);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitorClass">visitorClass as object</param>
        public void AcceptVisitor(Visitor visitorClass)
        {
            try
            {
                foreach (Element elementClass in this.elementClasses)
                {
                    elementClass.AcceptVisitor(visitorClass);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
