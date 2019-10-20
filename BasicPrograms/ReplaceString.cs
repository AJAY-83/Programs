using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class ReplaceString
    {
        ////this is utility class there all logic part
        Utility utility = new Utility();

        ///this variable is use to take Username
        String userName;

        public void Replace()
        {
            Console.WriteLine("Enter your UserName : ");

            ////Read method will returnthe String
            userName = this.utility.ReadString();


            String template = "Hello <<username>>, How are you".Replace("<<username>>", userName);

            ////Print the replaced string here
            Console.WriteLine(template);




            ////console.ReadKey() function is used to hold the screen
            Console.ReadKey();
        }////End Replace Method
    } ////End the ReplaceString
}////End Namespace
