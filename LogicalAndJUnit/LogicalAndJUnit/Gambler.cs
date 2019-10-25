//-----------------------------------------------------------------------
// <copyright file="Gambler.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Gambler class is finding the percentage of wining and loosing  
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// The utility
        /// </summary>
        private readonly Utility utility = new Utility();

            /// <summary>
            /// The goal  How much money want to win
            /// stake is how many cash do you have
            /// trial is how much  time will you play
            /// </summary>
            private int goal, stake, trial;

        /// <summary>
        /// The win or loss two variable are used 
        /// </summary>
        private double win = 0.0;

        /// <summary>
        /// The loss to store the Game loss 
        /// </summary>
        private double loss = 0.0;

            /// <summary>
            /// Wins the or loss.
            /// </summary>
            public void WinOrLoss()
            {
            //// takes how much money from user
                Console.WriteLine("Enter your Amount ");
                this.stake = this.utility.ReadInt();

            //// takes the trials from the user
                Console.WriteLine("Enter the Trails ");
                this.trial = this.utility.ReadInt();
            
            ////takes the goal from the user
                Console.WriteLine("Enter Your Money Goal");
                this.goal = this.utility.ReadInt();
            ////random funtion generate the random function
                Random random = new Random();
            ////for use the play game upto user trials
                for (int i = 1; i <= this.trial; i++)
                {
                ////takes the stake into the cash variable for secuirity
                    int cash = this.stake;

                ////while loop to iterate till user have money
                    while (cash > 0 && cash < this.goal)
                    {
                    ////random.NextDouble() is use to generate the floating numbers
                    ////then count numbers of cash++ or numbers of cash--
                        if (random.NextDouble() < 0.5)
                        {
                            cash++;
                        }
                        else
                        {
                            cash--;
                        }
                    }
                    ////here check the cash is equal to goal which user input
                    /////if true win++ not win--
                    if (cash == this.goal)
                    {
                        this.win++;
                    }
                    else
                    {
                        this.loss++;
                    }
                }
                /////print the number of wins by user
                Console.WriteLine("win " + this.win);
            ////count the percentage if the winning
                double result = (this.win / this.trial) * 100;
            ////print the percentage of win 
                Console.WriteLine("percentage of win " + result);
            }
    }
}
