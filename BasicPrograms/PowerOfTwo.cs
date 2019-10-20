using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PowerOfTwo
    {
        Utility utility = new Utility();

        int num;

        /// <summary>
        /// Powers the of.
        /// </summary>
        public void PowerOf()
        {
           Console.WriteLine("Enter the Number ");
            num = this.utility.ReadInt();

            this.utility.FindPowerTwo(num);

        } ////end PowerOf Method
    }////End PowerOfTwo 

  }////End the Namespace

