//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// VendingMachine class have all details about the transaction
    /// </summary>
   public class VendingMachine
    {
        /// <summary>
        /// The utility class have the logical parts
        /// </summary>
        private readonly Utility utility = new Utility();

        /// <summary>
        /// The note is array here have the all available notes
        /// </summary>
        private readonly int[] note = { 1, 2, 5, 10, 20, 50, 100, 500, 1000 };

        /// <summary>
        /// Machines the vending.
        /// </summary>
        public void MachineVending()
        {
            int amount = 0;
            ////take the amount from user as input
            Console.WriteLine("Enter the Your Amount : ");
            amount = this.utility.ReadInt();
            ////call the Money method
            ////pass the two parameter 
            //// amount is money that user input
            ////Note is the array it has the all available note
            this.utility.Money(amount, this.note);
        }
    }
}
