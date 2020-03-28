using System;
using System.Collections.Generic;

namespace QueueFromTwoStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        // implement a queue using two stacks.
        // queue should have an enqueue and dequeue method and be FIFO
        // optimize for m number of calls on the queue (either enqueue or dequeue calls)
        // assume you already have a stack implementation with O(1) time pop and push

        // a queue is first in first out
        // enqueue adds a value to the end; dequeue removes a value from the beginning

        // a stack is last in first out
        // push adds a value to the beginning; pop removes a value from the beginning
    }

    public class QueueFromStacks
    {
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();

    }
}
