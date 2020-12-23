using System;
using System.Collections;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack stackOne = new Stack();
        public Stack stackTwo = new Stack();

        public void Enqueue(int value)
        {
            while(stackOne.Count != 0)
            {
                stackTwo.Push(stackOne.Pop());
            }

            stackOne.Push(value);

            while (stackTwo.Count != 0)
            {
                stackOne.Push(stackTwo.Pop());
            }
        }

        public int Dequeue()
        {
            int value = (int)stackOne.Pop();
            return value;
        }
    }
}
