using System;

namespace Structural_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n -------------- Desing Pattern -------------------\n");
                Console.WriteLine(" 1. Adapter Pattern \n 2. Exit");
                Console.WriteLine("Enter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Adapter_Pattern.Shopping shopping = new Adapter_Pattern.Shopping();
                        shopping.AdapterFunction();
                        break;

                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You entered wrong input please try again");
                        break;
                }
            }
        }
    }
}
