using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           LinkedList list = new LinkedList();
            SinglyLinkedList singlylist = new SinglyLinkedList();
            bool flag = true;
            
            while (flag)
            {
               //// Console.Clear();
                int choice;
                Console.WriteLine("---------- Linked List All Operations --------------");
                Console.WriteLine(" 1. Insert Node At Bigining\n 2. Insert Node At Last \n 3. Insert Node At Position ");
                Console.WriteLine(" 4. Delete First Node \n 5. Delete Last Node \n 6. Delete Position Node");
                Console.WriteLine(" 7. Find The Lenth\n 8. Find The Duplicate Node And Remove\n 9. Reverse Linked List\n 10. Print List");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:

                        singlylist.checkLinklist();
                       // singlylinkedlist.PrintLinkedList();
                        break;
                    case 2:
                        singlylist.AddLast();
                        break;
                    case 3:
                        OrderedList ol = new OrderedList();
                        ol.ReadFile();
                       
                        break;
                    case 4:
                        UnsortedList us = new UnsortedList();
                        us.Unorderd();
                        break;
                    case 5:
                        flag=false;
                        break;
                    case 10:
                        singlylist.PrintList();
                        break;

                }
            }

        }
    }
}
