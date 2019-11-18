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
                Console.WriteLine(" 1. Adapter Pattern \n 2. Facade Pattern \n 3. Proxy Pattern \n 4. Exit");
                Console.WriteLine("Enter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Adapter_Pattern.Shopping shopping = new Adapter_Pattern.Shopping();
                        shopping.AdapterFunction();
                        break;
                    
                    case 2:
                        Facade_Pattern.Main mainClass = new Facade_Pattern.Main();
                        mainClass.MinFunction();
                        break;
                    case 3:
                        Proxy_Pattern.Proxy proxyClass = new Proxy_Pattern.Proxy();
                        proxyClass.ProxyFunction();
                        break;
                    case 4:
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
