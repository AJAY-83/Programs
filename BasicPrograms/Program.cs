using System;

namespace BasicPrograms
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        
        static void Main(string[] args)
        {
        Lable: try
            {
                ////this is utility class there all logic part
                Utility utility = new Utility();

            ////Choice is use to take  user Input
            int choice;

            ////flag is use to to continue the loop while it true
            Boolean flag = true;

            while (flag)
            {
                Console.WriteLine("\n\n 1.Replace Srtring ");
                Console.WriteLine(" 2.Flip Toss ");
                Console.WriteLine(" 3. Leap Year ");
                Console.WriteLine(" 4. Power Of Two ");
                Console.WriteLine(" 5. Harmonic Number ");
                Console.WriteLine(" 6. Prime Factor ");
                Console.WriteLine(" 7. Exit ");
                    choice = utility.ReadInt();

                ////switch case for user Input Action
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
                            HarmonicNumber hn = new HarmonicNumber();
                            hn.HarmonicNum();
                            break;
                        case 6:
                            PrimeFactores pf = new PrimeFactores();
                            pf.isPrime();
                            break;
                    case 7:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine(" Wrong Input Please Enter Correct Input");
                        break;
                }////end the  switch
            }////end the while

            //console.ReadKey() function is used to hold the screen
            Console.ReadKey();

        }////End Try Block

            //it use to take a correct input from user
        catch(Exception)
        {
                Console.WriteLine("Please Enter Correct Options");
                goto Lable;

       }////End Catch

}  ////End Main

 
    
    }////End the Class
} ////End Namespace
