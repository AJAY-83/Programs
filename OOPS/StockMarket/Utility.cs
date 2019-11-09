// <copyright file="Utility.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace StockMarket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Text;
    using System.IO;
    class Utility
    {
     
        /// <summary>
        /// Buys the shares.
        /// this method have the details about the  which cimpany have how much Avialable shares 
        /// </summary>
        public void BuyShares()
        {

            StockDataManagment data = JsonConvert.DeserializeObject<StockDataManagment>(File.ReadAllText(@"C:\Users\admin\source\repos\OOPS\StockMarket\Company.json"));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  *****  Capgemini Company Details About The Shares  ***** \n");

            //// This foreach loop for showing the details about the capgemini shares and price of shares
            //// here StockDataManagment.CapgeminiRecord have a class  CapgeminiRecord
            ////  and get the value from json file and print that data
            foreach (StockDataManagment.CapgeminiRecord i in data.Capgemini)
            {
                Console.WriteLine("   Available Shares : " + i.Available_Shares + "  Share Price " + i.Share_Price + "\n");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  *****  TATA Company Details About The Shares  ***** \n");

            //// This foreach loop for showing the details about the TATA shares and price of shares
            //// here StockDataManagment.TATARecord have a class  TATARecord
            ////  and get the value from json file and print that data
            foreach (StockDataManagment.TATARecord i in data.TATA)
            {
                Console.WriteLine("   Available Shares : " + i.Available_Shares + "  Share Price " + i.Share_Price);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Enter 1 For Capgemini And 2 For  TATA ");
            int choice = Convert.ToInt32(Console.ReadLine());

           
           
            switch (choice)
            {
                case 1:
                    Utility.Capgemini();
                    break;
            }
        }

        public static void Capgemini()
        {
            //// https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            //// this is used from this site
            DateTime now = DateTime.Now;

            //// date the todays date to store into Holders.json as well as Transaction.json 
            string date = now.ToString("MM/dd/yyyy");
            ////Type namenameType = date.GetType();
            ////Console.WriteLine(namenameType);
            ///// store the value into the Holders.json file since your are buy this share
            string since = now.ToString("yyyy");

            string campany = "Capgemini";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Enter the Amount To Your  Account ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > 0)
            {
                Console.WriteLine("Enter Your Name ");
                string name = Console.ReadLine();
                StockDataManagment data = JsonConvert.DeserializeObject<StockDataManagment>(File.ReadAllText(@"C:\Users\admin\source\repos\OOPS\StockMarket\Company.json"));
                int share_price=0;
                int shares=0;
                int total = 0;
                int myshares = 0;
                int number_of_holders = 0;
                foreach (StockDataManagment.CapgeminiRecord i in data.Capgemini)
                {
                   share_price =i.Share_Price ;
                    ////Console.WriteLine(" Share Rate : "+share_price);
                    shares = i.Available_Shares;
                    number_of_holders = i.Number_Of_Shares_Holder;
                }
                Console.WriteLine(" Share Price is  "+share_price);
                Console.WriteLine(" Available Share is  " + shares);
                Console.WriteLine(" How much share do you want to Buy ");
                myshares = Convert.ToInt32(Console.ReadLine());
                total = myshares * share_price;
                if (total <= amount)
                {
                    amount = amount - total;
                    // here we are updating the number_of_holders in Company.json file
                    // And add the one more holder in this file
                    // Reduce the share
                    // Increase the total share price
                    Holders(name,amount,myshares, campany, date,since);
                }

                else {
                    Console.WriteLine("Your Account Amount is Less to Buy " + myshares );
                }

            }
            else {
                Console.WriteLine("Please Enter Valid Amount");
            }
        }

        public static void Holders(string name, int amount, int myshare, string company, string date, string since)
        {
           // var newRiceMember = "{'Name': '" + riceName + "' ,'Weight':" + riceWeight + ",'Price':" + ricePrice + "}";
            var newMember = "{'Name': '" + name + "','Shares':" + myshare + ",'Money':" + amount+"}";
            //// FilePath have the path of that file where JSON file is stored
            string filePath = @"C:\Users\admin\source\repos\OOPS\StockMarket\Holders.json";
            var json = File.ReadAllText(filePath);
            var jsonObj = JObject.Parse(json);
            var holderArray = jsonObj.GetValue("Capgemini_Holders") as JArray;
            var newRice = JObject.Parse(newMember);
            holderArray.Add(newRice);
            jsonObj["Capgemini_Holders"] = holderArray;
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, newJsonResult);
            Console.WriteLine("Holder Added Successfully");
        }
    }
}
