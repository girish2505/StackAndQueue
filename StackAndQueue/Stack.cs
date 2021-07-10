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
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("{0} is in the top of the stack",top.data);
            }
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty Deletion is not possible");
                return;
            }
            else
            {

                Console.WriteLine("Value popped is {0}",top.data);
                top = top.next;
            }
        }
        public void IsEmpty()
        {
            while(top!=null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty");
        }
    }
}
