// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
  
    
    class SinglyLinkedList
    {

        LinkedList list = new LinkedList();
        public void checkLinklist()
        {
           
            //list.InsertAtBegining(11); list.InsertAtBegining(10); list.InsertAtBegining(09);
            int length;
            int value;
            Console.WriteLine("How much Nummber do you want to insert ");
            length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Insert Node  at {0} " + i + " Position");
                int number = Convert.ToInt32(Console.ReadLine());
                list.InsertAtBegining(number);
            }
        }
        public void PrintList()
        {
            list.PrintLinkedList();
        }

        public void AddLast()
        {
            int number;
            Console.WriteLine("Enter the number ");
            number = Convert.ToInt32(Console.ReadLine());
            list.InsertAtLast(number);
        }


    }
}
