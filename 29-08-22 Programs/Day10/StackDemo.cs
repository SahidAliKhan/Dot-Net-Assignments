using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class StackDemo
    {
        internal static readonly int max = 1000;
        internal int[] stack = new int[max];
        int top;

        internal bool isStackEmpty()
        {
            //bool status = false;
            //if (top<0)
            //{
            //    status = true;
            //}
            //return status;
            return (top < 0);
        }

        public StackDemo()
        {
            top = -1;
        }

        internal void Push(int data)
        {
            if (top >= max)
            {
                Console.WriteLine("No space on the stack");
                return;
            }
            else
            {
                stack[++top] = data;

            }
        }

        internal void Pop()
        {
            int value = 0;
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                value = stack[top--];
                Console.WriteLine(value);
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                int value = stack[top];
                Console.WriteLine(value);
            }
        }

        internal void PrintStackElements()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
