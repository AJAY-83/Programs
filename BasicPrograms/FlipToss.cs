//-----------------------------------------------------------------------
// <copyright file="NameOfFile.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
using System;

    /// <summary>
    /// This class is use for countung number of toss happen and what is head pecentage and tails percentage
    /// </summary>
public class FlipToss
{
        /// <summary>
        /// The utility class
        /// </summary>
        Utility utility = new Utility();

        /// <summary>
        ///This variable to use toss the coin
        /// </summary>
        public int toss;

        /// <summary>
        /// Tosses the coin.
        /// </summary>
        public void TossCoin()
        {
            Console.WriteLine(" Enter the How much Toss Do You want To Do ");
           this.toss = this.utility.ReadInt();
            this.utility.FlipToss(this.toss);
       }////End TossCoin

    }////End FlipToss Class
}////End Namespace
