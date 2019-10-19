using System;
using System.Collections.Generic;
using System.Text;

/**
 * @author Ajay J Lodale
 * 
 * @Since 18-10-2019
 *
 * @Purpose : Bridgelabz Assignments
 */
/*****************************************************************************************************************************************************/

namespace BasicPrograms
{
    /// <summary>
    /// Utility class is use for the Writing the Logic part 
    /// </summary>


    class Utility
    {
        Random random = new Random();

        /********************************************  Returning the User Input  ********************************************************************************/

        //@this method retrun the integer value

        public int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        //@this method return the Double value

        public double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        //@this method return the String value

        public String ReadString()
        {
            return Console.ReadLine();
        }

        /**********************************************  Basic Programs   **************************************************************************************/

        /*******************************************   FlipToss Program *******************************************************************************/

        //this method is use to flip coin to toss and find the percentage of head and tail  

        public void FlipToss(int Toss)
        {
            //head and tail are use to store the two sides of coin 
            float head = 0, tail = 0;

            //this for loop iterating upto Enterd toss 
            //this is use to Genrate Toss Random number 

            for (int i = 0; i < Toss; i++)
            {
                //double   result = random.NextDouble(0, 9);
                double result = (random.NextDouble() * 2.0) - 1.0;
                //  Console.WriteLine(result);
                if (result < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }


            //HeadPercentage and TailPercentage is use to find the percentage of head and tail

            double HeadPercentage = (head / Toss) * 100;
            double TailPercentage = (tail / Toss) * 100;

            //here print the Percentage of Head and Tail
            Console.WriteLine(" Head Percentage is : {0} ", HeadPercentage);
            Console.WriteLine(" Tail Percentage is : {0} ", TailPercentage);
        }

        /******************************************** Leap Year ***********************************************************************************************/

        public Boolean LeapYear(int Year)
        {
            if (((Year % 4 == 0) || (Year % 400 == 0)) && (Year % 100 != 0) && (Year > 1000 && Year < 9999))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*************************************     Find the Power of 2    *****************************************************************************************/

        public void FindPowerTwo(int Number)
        {
            Console.WriteLine("Print the number Till the " + Number);

            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(2 * i);
            }
        }
    }
}

