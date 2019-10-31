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
                //// utility class havae the all logic
                Utility utility = new Utility();
                ////while loop execute till flag is true
                while (flag)
                {
                    //// Options of Programs
                    Console.WriteLine(" 1. Coupon Number ");
                    Console.WriteLine(" 2. Start Time ");
                    Console.WriteLine(" 3. Gambler ");
                    Console.WriteLine(" 4. Vending Machine ");
                    Console.WriteLine(" 5. Day Of Week ");
                    Console.WriteLine(" 6. Temprature Conversion ");
                    Console.WriteLine(" 7. Monthly Payment ");
                    Console.WriteLine(" 8. Square Root ");
                    Console.WriteLine(" 9. Decimal to binary ");
                    Console.WriteLine(" 10. Binary ");
                    Console.WriteLine(" 11. Exit ");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Enter Your Choice ");
                    choice = utility.ReadInt();
                    switch (choice)
                    {
                        case 1:
                            //// CouponNumber class called here
                            CouponNumber genrateCoupon = new CouponNumber();
                            genrateCoupon.GenrateCoupon();
                            break;
                        case 2:
                            //// StopwatchSimulate class called here
                            StopwatchSimulate st = new StopwatchSimulate();
                            st.SimulateTime();
                            break;
                        case 3:
                            //// Gambler class called here
                            Gambler g = new Gambler();
                            g.WinOrLoss();
                            break;
                            case 4:
                            //// VendingMachine class called here
                            VendingMachine vm = new VendingMachine();
                            vm.MachineVending();
                            break;
                        case 5:
                            //// DayOfWeek class called here
                            DayOfWeek dw = new DayOfWeek();
                            dw.WeekDay();
                            break;
                        case 6:
                            //// TemperatureConversion class called here
                            TemperatureConversion tc = new TemperatureConversion();
                            tc.TempConversion();
                            break;
                        case 7:
                            //// MonthlyPayment class called here
                            MonthlyPayment mp = new MonthlyPayment();
                            mp.MonthlyPay();
                            break;
                        case 8:
                            //// SquareRoot class called here
                            SquareRoot sr = new SquareRoot();
                            sr.FindSquareRoot();
                            break;
                        case 9:
                            //// DecimalToBinary class called here
                            DecimalToBinary dtob = new DecimalToBinary();
                            dtob.Binary();
                            break;
                        case 10:
                            //// Binary class called here
                            Binary b = new Binary();
                            b.ToConvert();
                            break;
                        case 11:
                            //// when user input 11 that time flag will be false and while loop stop to execute
                            flag = false;
                            break;
                        default:
                            //// default case will print
                            Console.WriteLine("Wrong Input please Try Agian");
                            break;
                    }
                }
            }            
            catch (Exception)
            {
                //// Exception occure when user input the incorrect
                Console.WriteLine("Please enter correct option");
                goto Label;
            }
        }
    }
}
