using System;
using System.Text.RegularExpressions;
namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1
            //Receive Words from User  
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();

            //Add optional validation of input words if needed.  
            //.....  
            //Step 2 
            // validating the white Spaces
            string normalized1 = Regex.Replace(word1, @"\s", "");
            string normalized2 = Regex.Replace(word2, @"\s", "");

            //step 3
            // conver the string into the lower case
            char[] char1 = normalized1.ToLowerInvariant().ToCharArray();
             char[] char2 = normalized2.ToLowerInvariant().ToCharArray();

           // char[] char1 = normalized1.ToCharArray();
           // char[] char2 = normalized2.ToCharArray();

           
              //strp 4
            // Sort the  character array
            Array.Sort(char1);
            Array.Sort(char2);

            // Step 5 
            // Convert Into String object  
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);
         //strp 6
         // check Both Are Equals or not
            bool stringEquals = String.Equals(
                NewWord1,
                NewWord2);
        // step 7
        // print the Sting Anagram or Not
            if (stringEquals)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", normalized1, normalized2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", normalized1, normalized2);
            }


            
            //Hold Console screen alive to view the results.  
            Console.ReadLine();
        }
    }
}
