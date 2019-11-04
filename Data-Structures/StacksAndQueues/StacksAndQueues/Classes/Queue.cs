using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }

        public void QueueTheValue(int value)
        {
            if(Front == null)
            {
                Front = new Node(value);
            }
            else
            {
                Node pointer = Front;
                Node newQueue = new Node(value);

                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = newQueue;
            }
        }

        public int Dequeue()
        {
            if (Front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            int value = Front.Value;
            Front = Front.Next;

            return value;
        }

        //public int Peek()
        //{
        //    if (Top == null)
        //    {
        //        Console.WriteLine("Stack is empty");
        //    }
        //    int value = Top.Value;

        //    return value;
        //}

        //public bool IsEmpty()
        //{
        //    bool empty = false;
        //    if (Top == null)
        //    {
        //        empty = true;
        //        return empty;
        //    }
        //    return empty;
        //}
    }
}
