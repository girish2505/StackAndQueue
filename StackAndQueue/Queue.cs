using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Queue
    {
        Node head =null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into Queue",node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp==null)
            {
                Console.WriteLine("Queue is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {

                head = head.next;
                return;
            }

        }
    }
}
