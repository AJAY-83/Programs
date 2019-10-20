namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class is use To Genrate the Harmonic Number
    /// 1/1+1/2+1/3+1/4+1/5=2.2833333
    /// </summary>
 public class HarmonicNumber
    {
        /// <summary>
        /// The utility class
        /// </summary>
        Utility utility = new Utility();

        /// <summary>
        /// This variable use to Take Number From User
        /// </summary>
        int Number;
        
      
      public void HarmonicNum()
        {
            Console.WriteLine("Enter The Number : ");
            Number = this.utility.ReadInt();

            double Result = this.utility.HarmonicNumber(Number);
            Console.WriteLine(Result);
        }

    }
}
