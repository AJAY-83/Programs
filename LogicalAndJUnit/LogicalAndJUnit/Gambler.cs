//-----------------------------------------------------------------------
// <copyright file="Gambler.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Gambler class is finding the percentage of wining and loosing  
    /// </summary>
  public class Gambler
    {
        readonly Utility utility = new Utility();
        /// <summary>
        /// The goal  How much money want to win
        /// stake is how many cash do you have
        /// trial ishow much  time will you play
        /// </summary>
        public int goal, stake, trial;
        /// <summary>
        /// Wins the or loss.
        /// </summary>
        public void WinOrLoss()
        {
            Console.WriteLine("Enter your Amount ");
            this.stake = this.utility.ReadInt();
            Console.WriteLine("Enter the Trails ");
            this.trial = this.utility.ReadInt();
            Console.WriteLine("Enter Your Money Goal");
            this.goal = this.utility.ReadInt();

           
        }
       
    }
}
