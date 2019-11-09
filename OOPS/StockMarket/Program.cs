// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace StockMarket
{
    using System;

    /// <summary>
    /// this class have the all details about the shares market
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Utility utility = new Utility();
            Console.WriteLine("\n");
            Console.WriteLine(" ***** Welcome To Share Market ***** ");
            Console.WriteLine("   1. Buy Shares \n   2. Sell Shares ");
            Console.WriteLine("  Enter Your Input ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    utility.BuyShares();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("You Entered Wrong Input Please Enter Again");
                    break;
            }
            Console.ReadKey();
        }
       
    }
}
