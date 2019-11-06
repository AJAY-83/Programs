// <copyright file="Utility.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace OOPS
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Utility class for all programs.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public List<Rice> rice { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public List<Pulses> pulses { get; set; }

        /// <summary>
        /// Gets or sets the wheats.
        /// </summary>
        /// <value>
        /// The wheats.
        /// </value>
        public List<Wheats> wheats { get; set; }

        /// <summary>
        /// Inventory management which reads json file.
        /// </summary>
        public static void InventoryManagement()
        {
            double totalRicePrice = 0;
            double totalPulsePrice = 0;
            double totalWheatPrice = 0;
            //// FilePath have the path of that file where JSON file is stored
            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
            StreamReader streamReader = new StreamReader(filePath);
            string read = streamReader.ReadToEnd();
            InventoryDataManagement inventoryData = (InventoryDataManagement)JsonConvert.DeserializeObject(read, typeof(InventoryDataManagement));

            Console.WriteLine("********* Rice ********\n");
            //// foreach class print the class Rice 
            //// Rice class have details type of Rice
            foreach (Rice objectRice in inventoryData.rice)
            {
                string name = objectRice.Name;
                double weight = objectRice.Weight;
                double price = objectRice.Price;
                totalRicePrice = totalRicePrice + (price * weight);
                Console.WriteLine("Rice Name : " + name);
                Console.WriteLine("Rice Weight : " + weight);
                Console.WriteLine("Rice Price : " + price);
                double ricePrice = price * weight;
                Console.WriteLine("Total Price Of " + objectRice.Name + " Is : " + ricePrice + "\n");
            }

            Console.WriteLine("Total Amount of Rice Is : " + totalRicePrice + "\n");

            Console.WriteLine("********* Pulses ********\n");
            //// foreach class print the class Pulses 
            //// Pulses class have details type of Pulses
            foreach (Pulses objectPulse in inventoryData.pulses)
            {
                string name = objectPulse.Name;
                double weight = objectPulse.Weight;
                double price = objectPulse.Price;
                totalPulsePrice = totalPulsePrice + (price * weight);
                Console.WriteLine("Pulse Name : " + name);
                Console.WriteLine("Pulse Weight : " + weight);
                Console.WriteLine("Pulse Price : " + price);
                double pulsePrice = price * weight;
                Console.WriteLine("Total Price Of " + objectPulse.Name + " Is : " + pulsePrice + "\n");
            }

            Console.WriteLine("Total Amount of Pulse Is : " + totalPulsePrice + "\n");

            Console.WriteLine("********* Wheats ********\n");
            //// foreach class print the class Wheats 
            //// Wheats class have details type of Wheats
            foreach (Wheats objectWheat in inventoryData.wheats)
            {
                string name = objectWheat.Name;
                double weight = objectWheat.Weight;
                double price = objectWheat.Price;
                totalWheatPrice = totalWheatPrice + (price * weight);
                Console.WriteLine("Wheat Name : " + name);
                Console.WriteLine("Wheat Weight : " + weight);
                Console.WriteLine("Wheat Price : " + price);
                double wheatPrice = price * weight;
                Console.WriteLine("Total Price Of " + objectWheat.Name + " Is : " + wheatPrice + "\n");
            }

            Console.WriteLine("Total Amount of Wheat Is : " + totalWheatPrice);
            streamReader.Close();
        }

        public static void AddInventory()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine(" 1 : Add Rice \n 2 : Add Pulses \n 3 : Add Wheats \n 4 : Exit");
                    Console.WriteLine("Enter In Which Inventory To Add : ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Rice Name : ");
                            string riceName = Console.ReadLine();

                            Console.WriteLine("Enter Rice Weight : ");
                            double riceWeight = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Rice Price : ");
                            double ricePrice = Convert.ToDouble(Console.ReadLine());
                            var newRiceMember = "{'Name': '" + riceName + "' ,'Weight':" + riceWeight + ",'Price':" + ricePrice + "}";

                            try
                            {
                                //// FilePath have the path of that file where JSON file is stored
                                string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                                var json = File.ReadAllText(filePath);
                                var jsonObj = JObject.Parse(json);
                                var riceArray = jsonObj.GetValue("Rice") as JArray;
                                var newRice = JObject.Parse(newRiceMember);
                                riceArray.Add(newRice);
                                jsonObj["Rice"] = riceArray;
                                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(filePath, newJsonResult);
                                Console.WriteLine("Inventory Added Successfully");
                            }
                            catch (FileNotFoundException fnot)
                            {
                                Console.WriteLine(fnot.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Add Error : " + e.Message);
                            }

                            break;
                        case 2:
                            Console.WriteLine("Enter Pulse Name : ");
                            string pulseName = Console.ReadLine();

                            Console.WriteLine("Enter Pulse Weight : ");
                            double pulseWeight = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Pulse Price : ");
                            double pulsePrice = Convert.ToDouble(Console.ReadLine());
                            var newPulseMember = "{'Name': '" + pulseName + "' ,'Weight':" + pulseWeight + ",'Price':" + pulsePrice + "}";

                            try
                            {
                                //// FilePath have the path of that file where JSON file is stored
                                string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                                var json = File.ReadAllText(filePath);
                                var jsonObj = JObject.Parse(json);
                                var riceArray = jsonObj.GetValue("Rice") as JArray;
                                var newPulse = JObject.Parse(newPulseMember);
                                riceArray.Add(newPulse);
                                jsonObj["Pulses"] = riceArray;
                                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(filePath, newJsonResult);
                                Console.WriteLine("Inventory Added Successfully");
                            }
                            catch (FileNotFoundException fnot)
                            {
                                Console.WriteLine(fnot.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Add Error : " + e.Message);
                            }

                            break;
                        case 3:
                            Console.WriteLine("Enter Wheat Name : ");
                            string wheatName = Console.ReadLine();

                            Console.WriteLine("Enter Wheat Weight : ");
                            double wheatWeight = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Wheat Price : ");
                            double wheatPrice = Convert.ToDouble(Console.ReadLine());
                            var newWheatMember = "{'Name': '" + wheatName + "' ,'Weight':" + wheatWeight + ",'Price':" + wheatPrice + "}";

                            try
                            {
                                //// FilePath have the path of that file where JSON file is stored
                                string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                                var json = File.ReadAllText(filePath);
                                var jsonObj = JObject.Parse(json);
                                var wheatArray = jsonObj.GetValue("Wheats") as JArray;
                                var newWheat = JObject.Parse(newWheatMember);
                                wheatArray.Add(newWheat);
                                jsonObj["Wheats"] = wheatArray;
                                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(filePath, newJsonResult);
                                Console.WriteLine("Inventory Added Successfully");
                            }
                            catch (FileNotFoundException fnot)
                            {
                                Console.WriteLine(fnot.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Add Error : " + e.Message);
                            }

                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Choice Not Found");
                            break;
                    }
                }
            }
            catch (FormatException e1)
                {
                Console.WriteLine(e1.Message);
            }
        }

        public static void UpdateInventory()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1 : Update Rice \n 2 : Update Pulses \n 3 : Update Wheats \n 4 : Exit");
                Console.WriteLine("Select Inventory To Update : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray riceArray = (JArray)jsonObj["Rice"];
                            Console.WriteLine("Enter Rice Name To Update");
                            string updateName = Console.ReadLine();
                            bool found = false;
                            foreach (var update in riceArray.Where(obj => obj["Name"].Value<string>() == updateName))
                            {
                                Console.WriteLine("Enter New Rice Name : ");
                                update["Name"] = Console.ReadLine();
                                Console.WriteLine("Enter New Rice Weight : ");
                                update["Weight"] = Console.ReadLine();
                                Console.WriteLine("Enter New Rice Price : ");
                                update["Price"] = Console.ReadLine();
                                found = true;
                            }

                            jsonObj["Rice"] = riceArray;
                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(filePath, output);
                            Console.WriteLine("Inventory Updated Successfully");
                            if (!found)
                            {
                                Console.WriteLine(updateName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Valid Input");
                        }

                        break;
                    case 2:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray pulseArray = (JArray)jsonObj["Pulses"];
                            Console.WriteLine("Enter Pulse Name To Update");
                            string updateName = Console.ReadLine();
                            bool found = false;
                            foreach (var update in pulseArray.Where(obj => obj["Name"].Value<string>() == updateName))
                            {
                                Console.WriteLine("Enter New Pulse Name : ");
                                update["Name"] = Console.ReadLine();
                                Console.WriteLine("Enter New Pulse Weight : ");
                                update["Weight"] = Console.ReadLine();
                                Console.WriteLine("Enter New Pulse Price : ");
                                update["Price"] = Console.ReadLine();
                                found = true;
                            }

                            jsonObj["Pulses"] = pulseArray;
                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(filePath, output);
                            Console.WriteLine("Inventory Updated Successfully");
                            if (!found)
                            {
                                Console.WriteLine(updateName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter valid Input");
                        }

                        break;
                    case 3:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray wheatArray = (JArray)jsonObj["Wheats"];
                            Console.WriteLine("Enter Wheat Name To Update");
                            string updateName = Console.ReadLine();
                            bool found = false;
                            foreach (var update in wheatArray.Where(obj => obj["Name"].Value<string>() == updateName))
                            {
                                Console.WriteLine("Enter New Wheat Name : ");
                                update["Name"] = Console.ReadLine();
                                Console.WriteLine("Enter New Wheat Weight : ");
                                update["Weight"] = Console.ReadLine();
                                Console.WriteLine("Enter New Wheat Price : ");
                                update["Price"] = Console.ReadLine();
                                found = true;
                            }

                            jsonObj["Wheats"] = wheatArray;
                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(filePath, output);
                            Console.WriteLine("Inventory Updated Successfully");
                            if (!found)
                            {
                                Console.WriteLine(updateName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Valid Input");
                        }

                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choice Not Found");
                        break;
                }
            }
        }

        public static void DeleteInventory()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1 : Delete Rice \n 2 : Delete Pulses \n 3 : Delete Wheats \n 4 : Exit");
                Console.WriteLine("Select Inventory To Delete : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray riceArray = (JArray)jsonObj["Rice"];
                            Console.WriteLine("Enter Rice Name To Delete : ");
                            string deleteName = Console.ReadLine();
                            bool found = false;
                            foreach (var delete in jsonObj["Rice"])
                            {
                                if (delete["Name"] + string.Empty == deleteName)
                                {
                                    var itemToDelete = riceArray.FirstOrDefault(obj => obj["Name"].Value<string>() == deleteName);
                                    riceArray.Remove(itemToDelete);
                                    jsonObj["Rice"] = riceArray;
                                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                    File.WriteAllText(filePath, output);
                                    Console.WriteLine("Inventory Deleted Successfully");
                                    found = true;
                                    return;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine(deleteName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Valid Input");
                        }

                        break;
                    case 2:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray pulseArray = (JArray)jsonObj["Pulses"];
                            Console.WriteLine("Enter Pulse Name To Delete : ");
                            string deleteName = Console.ReadLine();
                            bool found = false;
                            foreach (var delete in jsonObj["Pulses"])
                            {
                                if (delete["Name"] + string.Empty == deleteName)
                                {
                                    var itemToDelete = pulseArray.FirstOrDefault(obj => obj["Name"].Value<string>() == deleteName);
                                    pulseArray.Remove(itemToDelete);
                                    jsonObj["Pulses"] = pulseArray;
                                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                    File.WriteAllText(filePath, output);
                                    Console.WriteLine("Inventory Deleted Successfully");
                                    found = true;
                                    return;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine(deleteName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter valid Input");
                        }

                        break;
                    case 3:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray wheatArray = (JArray)jsonObj["Wheats"];
                            Console.WriteLine("Enter Pulse Name To Delete : ");
                            string deleteName = Console.ReadLine();
                            bool found = false;
                            foreach (var delete in jsonObj["Wheats"])
                            {
                                if (delete["Name"] + string.Empty == deleteName)
                                {
                                    var itemToDelete = wheatArray.FirstOrDefault(obj => obj["Name"].Value<string>() == deleteName);
                                    wheatArray.Remove(itemToDelete);
                                    jsonObj["Wheats"] = wheatArray;
                                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                    File.WriteAllText(filePath, output);
                                    Console.WriteLine("Inventory Deleted Successfully");
                                    found = true;
                                    return;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine(deleteName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Valid Input");
                        }

                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choice Not Found");
                        break;
                }
            }
        }

        /************************** Print the Player Cards *******************************************************************************/

        /// <summary>
        /// The random is uses to genrate the random cards within the buundle of cards
        /// </summary>
        Random random = new Random();
        /// <summary>
        /// this array is use to give the cards with some symbols that are in cards game only
        /// </summary>
        string[] suite = { "Clubs", "Diamonds", "Hearts", "Spades" };

        int i, j;
        /// <summary>
        /// this array is use to have the all cards
        /// </summary>
        string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
       readonly string[,] player = new string[9, 4];
       readonly int[,] sorting = new int[4,9];
        public void Sort(int[,] player,int n)
        {
           ////string temp;
            string[,] sort = new string[9,4];
            for ( i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    int index = this.random.Next(this.rank.Length);
                    string card = Convert.ToString(index);
                    //// sorting[i,j] = rank[index];
                    /*if (i==2)
                    {
                        if (sorting[j].CompareTo(sorting[j + 1]) > 0)
                        {
                            temp = sorting[j];
                            sorting[j] = sorting[j + 1];
                            sorting[j + 1] = temp;
                        }*/
                    // }    
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Display the Player Cards");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int s = this.random.Next(this.suite.Length);

                    Console.Write(this.sorting[i, j] + " " + this.suite[s] + " | ");
                    if (i == 2 && j == 0)
                    {
                        ////  player[i, j] = rank[index];
                        break;
                    }
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("------------------------------");
        }
        //public void Display()
        //{
            
        //    Console.WriteLine("------------------------------");
        //    Console.WriteLine("Display the Player Cards");
        //    Console.WriteLine("------------------------------");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            int s = random.Next(suite.Length);

        //            Console.Write(player[i, j] + " " + suite[s] + " | ");
        //            if (i == 2 && j == 0)
        //            {
        //                //  player[i, j] = rank[index];
        //                break;
        //            }

        //        }
        //        Console.WriteLine("\n");
        //    }
        //    Console.WriteLine("------------------------------");
        //}
    }
}
