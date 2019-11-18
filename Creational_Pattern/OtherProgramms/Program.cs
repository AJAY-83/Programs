using System;

namespace OtherProgramms
{
    class Program
    {
        delegate double CalArePointer(int r);
        static void Main(string[] args)
        {

            //// Using the Anonymous function
            /*CalArePointer pointer = new CalArePointer(
                delegate (int r)
                {
                    return 3.14 * r * r;
                }

                );
            double Area = pointer(20);
            */
            //// More Simpler using the Lamda function we are also called it inline function
            //// Console.WriteLine(Area);
            //CalArePointer pointer = r => 3.12 * r * r;
            //double Area = pointer(20);
            //Console.WriteLine(Area);

            //// using the Func,Action and Pridicate programs
            //// first is input type and second is output type
            //// function is used to call towards the method
            //// where you want input type anything and output time anything
            Func<double, double> pointer = r => 3.14 * r * r;

            //// Action is used where method not give any time like void
            Action<string> MyAction = y => Console.WriteLine(y);

            //// when i/n anything and o/p is boolean that time we are use the Predicate
            Predicate<string> CheckGreaterThan5 = x => x.Length > 5;

            Console.WriteLine(CheckGreaterThan5("Ajay's Way"));
            MyAction("MyStyle");
            Double area = pointer(20);
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
