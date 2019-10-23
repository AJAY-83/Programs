//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace LogicalAndJUnit
{
    using System;

    /// <summary>
    /// Main program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
        Label:
            try
            {
                int choice;
                bool flag = true;
                Utility utility = new Utility();
                while (flag)
                {
                    Console.WriteLine(" 1. Coupon Number ");
                    Console.WriteLine(" 2. Start Time ");
                    Console.WriteLine(" 3. Exit ");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Enter Your Choice ");
                    choice = utility.ReadInt();
                    switch (choice)
                    {
                        case 1:
                            CouponNumber genrateCoupon = new CouponNumber();
                            genrateCoupon.GenrateCoupon();
                            break;
                        case 2:
                            StopwatchSimulate st = new StopwatchSimulate();
                            st.SimulateTime();
                            break;
                        case 3:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Input please Try Agian");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter correct option");
                goto Label;
            }
        }
    }
}
