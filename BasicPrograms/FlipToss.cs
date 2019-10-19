using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    /// <summary>
    /// This class is use for countung number of toss happen and what is head pecentage and tails percentage
    /// </summary>
    class FlipToss
    {
       
        Utility utility = new Utility();

        //this variable to use toss the coin
        int Toss;
     
        //this method perform the toss operation
        public void TossCoin()
        {
            Console.WriteLine(" Enter the How much Toss Do You want To Do ");
            Toss = utility.ReadInt();
            utility.FlipToss(Toss);
       }

    }
}
