// <copyright file="PrimeAnagram.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Prime funnction is use to find the prime number
    /// 
    /// </summary>
    class PrimeAnagrams
    {
       
        public void isPrimeAnagram()
        { 
            Utility utility = new Utility();

            int[] arr = utility.CheckPrimeNumbers();

            string string1;
            string string2;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    string1 = Convert.ToString(arr[i]);
                    string2 = Convert.ToString(arr[j]);

                   
                   
                    char[] c1 = string1.ToCharArray();
                    char[] c2 = string2.ToCharArray();
                    
                    Array.Sort(c1);
                   Array.Sort(c2);

                    if (string1.Equals(string2))
                    {
                        Console.WriteLine("ad");
                        Console.WriteLine(string1 + "\t" + string2);

                    }
                    
                    
                }
                 
            }
        }
    }
}
        

