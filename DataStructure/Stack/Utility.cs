using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Utility
    {

        private readonly int SIZE;
        int top;
        int[] stack;


        public Utility(int SIZE)
        {
            this.SIZE = SIZE;
            stack = new int[SIZE];
            top = -1;

        }
        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool IsFull()
        {
            if (top >= SIZE)
            {
                return true;
            }
            else {
                return false;
            }
        }
        public bool Push(int data)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
               return false;
            }
            else
            {
               
                stack[++top] = data;
              
               return true;
            }


        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
            //if (!IsEmpty())
            //{
            //    data = stack[top];
            //    top = top - 1;
            //    return data;
            //}
            //else
            //{
            //    printf("Could not retrieve data, Stack is empty.\n");
            //}
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
  }
