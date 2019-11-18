using System;

namespace Behavioral_Pattern
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
                Console.WriteLine(" 1. Obsercer Pattern \n 2. Visitor Pattern \n 4. Exit");
                Console.WriteLine("Enter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Observer_Pattern.Observer.ObserverFunction();
                        break;
                    case 2:
                        Visitor_Pattern.MainVisitor.VisitorFunction();
                        break;
                    case 3:
                        //Proxy_Pattern.Proxy proxy = new Proxy_Pattern.Proxy();
                        //proxy.ProxyFunction();
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
