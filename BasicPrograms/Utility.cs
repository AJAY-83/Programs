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


 public  class Utility
 {
        Random random = new Random();

        /********************************************  Returning the User Input  ********************************************************************************/

        ////@this method retrun the integer value

        public int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        ////@this method return the Double value

        public double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        //// this method return the String value

        public String ReadString()
        {
            return Console.ReadLine();
        }

        /**********************************************  Basic Programs   **************************************************************************************/

        /*******************************************   FlipToss Program *******************************************************************************/

        ////this method is use to flip coin to toss and find the percentage of head and tail  

        public void FlipToss(int Toss)
        {
            ////head and tail are use to store the two sides of coin 
            float head = 0, tail = 0;

            ////this for loop iterating upto Enterd toss 
            ////this is use to Genrate Toss Random number 

            for (int count = 0; count < Toss; count++)
            {
                ////double   result = random.NextDouble(0, 9);
                double result = (random.NextDouble() * 2.0) - 1.0;
                ////  Console.WriteLine(result);-
                if (result < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }


////HeadPercentage and TailPercentage is use to find the percentage of head and tail

            double HeadPercentage = (head / Toss) * 100;
            double TailPercentage = (tail / Toss) * 100;

////here print the Percentage of Head and Tail
            Console.WriteLine(" Head Percentage is : {0} ", HeadPercentage);
            Console.WriteLine(" Tail Percentage is : {0} ", TailPercentage);
        }

  /******************************************** Leap Year ***********************************************************************************************/

        /// <summary>
        /// Leaps the year.
        /// </summary>
        /// <param name="Year">Find The year.</param>
        /// <returns>True Or False</returns>

        //year%4==0 it will check the year is divible by 4 or not  if divisible then it is prime number
        //year%400==0 if year is divible by 400 or not  if divisible then it is prime number
        //year%100!=0 in this condition we are checking the suppose 1400 this not leap year but op is true so we are using this condition
        //year>999 && year<9999 year should be 4 digit only

        public bool LeapYear(int Year)
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

        /// <summary>
        /// Finds the power two.
        /// </summary>
        /// <param name="Number">The Power Of Number.</param>

        public void FindPowerTwo(int Number)
        {
            Console.WriteLine("Print the number Till the " + Number);

            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(2 * i);
            }////End Loop
        }////End the FindPowerTwo method

        /******************************************* Find the Harmonic Number ****************************************************************************************/

        public double HarmonicNumber(int Result)
        {
            double sum=0;
            int i;
            for(i=1;i<=Result;i++)
            {
                sum = sum + (float)1 / i;
            }
            return sum;
        }
        /********************************************* 2-D Matrix *********************************************************************************************/

        /// <summary>
        /// Display  the Array  elements.
        /// </summary>
        /// <param name="array">The array.</param>
        
            //r is use  as a rows and c is use as column

       public void insertElements(object[,] array)
        {
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(array[r, c] + " ");
                }
                Console.WriteLine();
            }
        } //End insertElements

        /************************************** Quadratic Equation Root ***************************************************************************************/
        /// <summary>
        /// Finds the root.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public void findRoot(int a, int b, int c)
        {
          
                int delta = b * b - 4 * a * c;
                int sqrt = (int)Math.Pow(delta, 0.5);
                int root1 = (-b + sqrt) / (2 * a);
                int root2 = (-b - sqrt) / (2 * a);

                Console.WriteLine("Root 1 ", root1);
                Console.WriteLine("Root 2 ", root2);
           
        }//End the findRoot
    }////End the Utility Class
} ////End the Namespace
