// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            Console.WriteLine("Enter the Arithematic Expression ");
            string expression = Console.ReadLine();

            char[] charArray = expression.ToCharArray();
            int size = charArray.Length;

            for (int j = 0; j < size; j++)
            {
                if (charArray[j] == '(' || charArray[j] == '{' || charArray[j] == '[' || charArray[j]==')'||charArray[j]=='}' ||charArray[j]==']')
                {
                    valid = true;
                    break;
                }
            }
            Utility utility = new Utility(size);
            if (valid)
            {
                
                int i = 0;

                while (i < size)
                {
                    if (charArray[i] == '(' || charArray[i] == '{' || charArray[i] == '[')
                    {
                        utility.Push(charArray[i]);
                    }
                    else if (charArray[i] == ')' || charArray[i] == '}' || charArray[i] == ']')
                    {
                        utility.Pop();
                    }
                    i++;
                }

                if (utility.IsEmpty())
                {
                    Console.WriteLine("Expressin  parenthesis is Balanced");
                }
                else
                {
                    Console.WriteLine("Expressin  parenthesis is Not Balanced");
                }
            }
            else {
                Console.WriteLine("No Brackets Available in Expression");
            }
            Console.ReadKey();
        }
    }
}
