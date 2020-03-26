using System;
using System.Collections;
using System.Collections.Generic;

namespace MaxStack
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    // use the built-in stack class to implement a new MaxStack class with a method GetMax that returns the largest element in the stack
    // getmax should not remove the item from the stack
    // assume stack is only holding int values
    public class MaxStack
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> maxStack = new Stack<int>();

        public void Push(int item)
        {
            stack.Push(item);
            if (maxStack.Count == 0 || item > maxStack.Peek())
            {
                maxStack.Push(item);
            }
        }

        public int Pop()
        {
            int item = stack.Pop();
            if (item == maxStack.Peek())
            {
                maxStack.Pop();
            }
            return item;
        }

        public int GetMax()
        {
            return maxStack.Peek();
        }
    }
}
