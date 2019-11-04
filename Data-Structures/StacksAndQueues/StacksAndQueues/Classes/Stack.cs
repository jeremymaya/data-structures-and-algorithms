using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public void Push(int value)
        {
            if(Top == null)
            {
                Top = new Node(value);
            }
            Node topNext = Top;
            Node newTop = new Node(value);
            Top = newTop;
            Top.Next = topNext;
        }

        public int Pop()
        {
            if(Top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            int value = Top.Value;
            Top = Top.Next;

            return value;
        }
        public int Peek()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            int value = Top.Value;
 
            return value;
        }
    }
}
