using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PowerOfTwo
    {
        Utility utility = new Utility();

        int num;
        public void PowerOf()
        {
           Console.WriteLine("Enter the Number ");
            num = utility.ReadInt();

            utility.FindPowerTwo(num);

        }
            }


    }

