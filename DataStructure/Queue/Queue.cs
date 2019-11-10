// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    
 using System;
using System.Collections.Generic;
using System.Text;
   

    /// <summary>
    /// Program to implement queue operations.
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// Queue operations.
        /// </summary>
        public void QueueOperations()
        {
        Label:
            try
            {
                Utility utility = new Utility();
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("\n 1 : Enqueue \n 2 : Dequeue \n 3 : Display \n 4 : Exit");
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter value to insert : ");
                            int data = Convert.ToInt32(Console.ReadLine());
                            utility.Enqueue(data);
                            break;
                        case 2:
                            utility.Dequeue();
                            break;
                        case 3:
                            utility.QueueDisplay();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter Valid Input");
                goto Label;
            }
        }
    }
}

