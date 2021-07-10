using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack
    {
        private Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack",data);
        }

        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data+ " ");
                temp = temp.next;
            }
        }
    }
}
