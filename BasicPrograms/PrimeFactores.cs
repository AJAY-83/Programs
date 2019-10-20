using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
  public  class PrimeFactores
    {
        Utility utility = new Utility();
        int number;
        public void isPrime()
        { 
            Console.WriteLine("Enter the Number : ");
            number = utility.ReadInt();
            for (int i = 2; i < number; i++)
            {
                while(number%i == 0)
                {
                    Console.WriteLine("{0}", i);
                    number = number / i;
                }
            }
            if (number > 2)
            {
                Console.WriteLine("{0}", number);
            }
        }
    }
}
