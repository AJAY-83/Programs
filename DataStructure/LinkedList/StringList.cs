// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class StringList
    {
        public class Node
        {
            public string data;
            public Node next;

            public Node(string data)
            {
                this.data = data;
                next = null;
            }
        }
        /*********************************** class LinkList ******************************/
        
            Node head;
            /***************************************insertFront method************************/
            public void InsertFront(string data)
            {
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
            /***************************************insertNextToKey method************************/
            public bool InsertNextTOKey(string key, string data)
            {
                Node current = head;
                while (current.data != key)
                {
                    if (current.next == null)
                    {
                        break;
                    }
                    current = current.next;
                }
                if (current.data == key)
                {
                    Node newNode = new Node(data);
                    newNode.next = current.next;
                    current.next = newNode;
                    Console.WriteLine("element is added to list");
                    return true;
                }
                else
                {
                    Console.WriteLine("key is not in the list");
                    return false;
                }
            }
            /*************************************DisplayList method************************/
            public void DisplayList()
            {
                Node current = head;
                if (head != null)
                {
                    while (current != null)
                    {
                        Console.Write(current.data + "-->");
                        current = current.next;
                    }
                    Console.Write("null");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("List is empty");
                }
            }
            /***************************************ReturnString method************************/
            public string ReturnString()
            {
                string stringText = "";
                Node current = head;
                if (head != null)
                {
                    stringText += current.data;
                    current = current.next;
                    while (current != null)
                    {
                        stringText = stringText + " " + current.data;
                        current = current.next;
                    }
                    return stringText;
                }
                else
                {
                    Console.WriteLine("List is empty");
                    return null;
                }
            }
            /***************************************Search method************************/
            public bool Search(string key)
            {
                Node current = head;
                if (head == null)
                {
                    Console.WriteLine("List is empty so none element deleted");
                    return false;
                }
                while (current.data != key)
                {
                    if (current.next == null)
                    {
                        break;
                    }
                    current = current.next;
                }
                if (current.data == key)
                {
                    Console.WriteLine("element found in list");
                    return true;
                }
                else
                {
                    Console.WriteLine("element is not in list");
                    return false;
                }
            }
            /***************************************DeleteFront method************************/
            public void DeleteFront()
            {
                if (head == null)
                {
                    Console.WriteLine("List is empty so none element deleted");
                }
                else if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    head.data = head.next.data;
                    head.next = head.next.next;
                }
            }
            /***************************************DeleteKeyElement method************************/
            public bool DeleteKeyElement(string key)
            {
                Node current = head;
                Node previous = head;
                if (current.data == key)
                {
                    head.data = head.next.data;
                    head.next = head.next.next;
                    Console.WriteLine("1st element deleted from the list");
                    return true;
                }
                else
                {
                    current = current.next;
                }
                while (current.data != key)
                {
                    if (current.next == null)
                    {
                        break;
                    }
                    previous = current;
                    current = current.next;
                }
                if (current.data == key)
                {
                    previous.next = current.next;
                    Console.WriteLine("element  deleted from the list");
                    return true;
                }
                else
                {
                    Console.WriteLine("element is not in list");
                    return false;
                }
            }
            // end of all methods.
       
    }
}
