
namespace LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class UnsortedList
    {
      
            public void Unorderd()
            {
                string text = File.ReadAllText(@"C:/Users/admin/source/repos/DataStructure/LinkedList/myfile.txt", Encoding.UTF8);
                string[] stringSeparator = new string[] { " " };
                string[] textArray;
                textArray = text.Split(stringSeparator, StringSplitOptions.RemoveEmptyEntries);
               StringList list = new StringList();
                for (int i = textArray.Length - 1; i >= 0; i--)
                {
                    list.InsertFront(textArray[i]);
                }
                list.DisplayList();
                Console.WriteLine("Enter a string which you want to be found:");
                string searchString = Console.ReadLine();
                if (list.Search(searchString))
                {
                    list.DeleteKeyElement(searchString);
                }
                else
                {
                    list.InsertFront(searchString);
                }
                string textFile = list.ReturnString();
                File.WriteAllText(@"C:/Users/admin/source/repos/DataStructure/LinkedList/myfile.txt",textFile);
                // Console.WriteLine("Enter a string which you want to be add:");
                // string inputString = Console.ReadLine();
                // list.InsertNextTOKey(searchString,inputString);
                list.DisplayList();
            }
      
    }
}
