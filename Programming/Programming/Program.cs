using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle triangle = new Circle();
            
            triangle.Test();
            Console.Read();
        }
    }

    public interface IAutomonile
    {
         void hello();
    }
    public class Rectangle
    {
       
        public virtual void Test()
        {
            Console.WriteLine("Rectangle");        
        }
    }
    public class Circle: Rectangle
    {
        public override void Test()
        {
            Console.WriteLine("Circle");
        }
    }
}
