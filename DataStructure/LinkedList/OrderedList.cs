using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LinkedList
{
    class OrderedList
    {

        LinkedList list = new LinkedList();
        public void ReadFile()
        {
            string file = File.ReadAllText( @"C:/Users/admin/source/repos/DataStructure/LinkedList/myfile.txt");
            //string line;

            //if (File.Exists(filePath))
            //{
            //    StreamReader file = null;
            //    try
            //    {
            //        file = new StreamReader(filePath);
            //        while ((line = file.ReadLine()) != null)
            //        {
            //           // Console.WriteLine(line);
            //            int num = int.Parse();
            //            Console.WriteLine(num);
            //            ////list.InsertAtLast(num);
            //        }
            //    }
            //    finally
            //    {
            //        if (file != null)
            //            file.Close();
            //    }
            //}

            //Console.ReadLine();

            string seprator = " ";
            
           string[] array = file.Split(seprator, StringSplitOptions.RemoveEmptyEntries);

            string temp;
            
            //// sort the given file
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) < 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                      

                    }
                }
            }
            //// print sorted array
            //Console.WriteLine("Sorted array");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i]+" ");
            //}
          
           
                
        }

       
            
            
            

 
       }
}
