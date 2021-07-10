
using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            //Console.WriteLine("Stack and Queue Implementation !");
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);
            //stack.Display();
            //stack.Peek();
            //stack.Pop();
            //stack.IsEmpty();
            //stack.Display();
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
