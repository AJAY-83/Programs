using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program 
    {
        static void Main(string[] args)
        {
            Result r = new Result();
            r.ResultofAbstract();
            Console.ReadLine();
        }
    }

    abstract class CheckAbstract
    {

       void MethodOne()
        {
            int a=90, b= 90;
            int c = a + b;
            Console.WriteLine(c);

        }
        public void Show()
        {
            MethodOne();
        }
    }
    class Result : CheckAbstract
    {
        public void ResultofAbstract()
        {
            Show();
        }
    }
}
