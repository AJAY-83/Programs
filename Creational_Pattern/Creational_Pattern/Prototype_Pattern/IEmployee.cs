﻿// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="IEmployee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Creational_Pattern.Prototype_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Employee is the Interface.
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clone as function.
        /// </summary>
        /// <returns>return type interface.</returns>
        IEmployee Clone();

        /// <summary>
        /// GetEmployeeDetails as function.
        /// </summary>
        /// <returns>return string.</returns>
        string GetEmployeeDetails();
    }

    /// <summary>
    /// SoftwareDeveloper as class.
    /// </summary>
    public class SoftwareDeveloper : IEmployee
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int WordsPerMinute { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string PreferredTechnology { get; set; }

        /// <summary>
        /// Clone as function.
        /// </summary>
        /// <returns>return interface.</returns>
        public IEmployee Clone()
        {
            return (IEmployee)this.MemberwiseClone();
        }

        /// <summary>
        /// GetEmployeeDetails as function.
        /// </summary>
        /// <returns>return string.</returns>
        public string GetEmployeeDetails()
        {
            return string.Format("{0} {1} {2}", this.EmployeeName, this.EmployeeId, this.PreferredTechnology);
        }
    }

    /// <summary>
    /// Department as class implemented by IEmployee.
    /// </summary>
    public class Department : IEmployee
    {
        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public int WordsPerMinute { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string DId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string PreferredTechnology { get; set; }

        /// <summary>
        /// Clone as function.
        /// </summary>
        /// <returns>return as interface type.</returns>
        public IEmployee Clone()
        {
            return (IEmployee)this.MemberwiseClone();
        }

        /// <summary>
        /// GetEmployeeDetails as function.
        /// </summary>
        /// <returns>return string type.</returns>
        public string GetEmployeeDetails()
        {
            return string.Format("{0} {1} {2} ", this.DeptName, this.DId, this.WordsPerMinute);
        }
    }
}