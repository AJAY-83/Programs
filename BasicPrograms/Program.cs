using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is utility class there all logic part
            Utility utility = new Utility();
           
            int choice;
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("\n\n 1.Replace Srtring ");
                Console.WriteLine(" 2.Flip Toss ");
                Console.WriteLine(" 3. Leap Year ");
                Console.WriteLine(" 4. Power Of Two ");
                Console.WriteLine(" 5. Exit ");
                choice = utility.ReadInt();

                switch (choice)
                {
                    case 1:
                        ReplaceString obj = new ReplaceString();
                        obj.Replace();
                        break;
                    case 2:
                        FlipToss ft = new FlipToss();
                        ft.TossCoin();
                        break;
                    case 3:
                        LeapYear ly = new LeapYear();
                        ly.FindLeapYear();
                        break;
                    case 4:
                        PowerOfTwo pt = new PowerOfTwo();
                        pt.PowerOf();
                        break;
                    case 5:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine(" Wrong Input Please Enter Correct Input");
                        break;
                    }
            }
            //console.ReadKey() function is used to hold the screen
            Console.ReadKey();
        }
    }
}
