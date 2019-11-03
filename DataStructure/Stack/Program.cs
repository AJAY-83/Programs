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
            if (valid)
            {
                Utility utility = new Utility(size);
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
