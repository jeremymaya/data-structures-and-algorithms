using System;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PseudoQueue testQueue = new PseudoQueue();
            testQueue.Enqueue(10);
            testQueue.Enqueue(15);
            testQueue.Enqueue(20);

            Console.WriteLine(testQueue.Dequeue());
            Console.WriteLine(testQueue.Dequeue());
            Console.WriteLine(testQueue.Dequeue());
        }
    }
}
