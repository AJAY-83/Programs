using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    /// <summary>
    /// TripleOfZero class is use for find the additon of three number is zero
    /// </summary>
    class TripletOfZero
    {
        //Array with some values 
        int[] array = { 1, 2, 0, -1, 1 };

        /// <summary>
        /// Determines whether is sum zero.
        /// </summary>
        public void isSumZero()
        {
            //first for loop is start from 0 index position to array.length
            for (int first = 0; first < array.Length; first++)
            {
                //second for loop start from i+1 to ignore first one
                for (int second = first+1; second < array.Length; second++)
                {
                    //second for loop start from j+1 to ignore first and second
                    for (int third = second+1; third < array.Length; third++)
                    {
                        //this condition we are checking all array position values are zero or not
                        if (array[first] + array[second] + array[third] == 0)
                        {
                            //Print the all situation which  are zero
                            Console.WriteLine(array[first] + "  " + array[second] + "  " + array[third]+"  ");
                        }
                    }
                }
            }

        }
    }
}
