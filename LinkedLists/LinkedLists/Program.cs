using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    // implement a linkedlist from scratch

    // create a node class to describe each node in the linkedlist and its connection to the next node
    // create a linkedlist class with functions to create a linkedlist, add/delete/modify nodes, count nodes, etc.

    public class Node
    {
        // data in each node
        public int data;
        // pointer to next node
        public Node next;

        // constructor to create a new node with data
        public Node(int data)
        {
            this.data = data;
        }  
    }

    public class LinkedList
    {
        Node head;
        Node tail;
        // create a linkedlist
        public LinkedList(int data)
        {
            Node head = new Node(data);
        }

        // add node
        public void AppendNode(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
        }

        // prepend node
        public void PrependNode(int data)
        {
            // add a new head
            // add pointer to old head
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }

        // delete node
        public void DeleteNode(int data)
        {
            // to remove a node, just change the pointer before it to the next node
            // need to walk through linkedlist to find node which has a pointer to current
            if (head == null)
            {
                return;
            }
            // special case: head is the node we want to delete
            if (head.data == data)
            {
                head = head.next;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    // change the pointer
                    current.next = current.next.next;
                    return;
                }
                // move current
                current = current.next;
            }
        }

        // count nodes
        public int CountNodes(Node head)
        {
            if (head == null)
            {
                return 0;
            }

            int counter = 1;
            Node current = head;

            while (current.next != null)
            {
                current = current.next;
                counter++;
            }
            return counter;
        }
    }
}
