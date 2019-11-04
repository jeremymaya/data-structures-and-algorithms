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
            Node newTop = new Node(value);
            Top.Next = newTop;
            Top = Top.Next;
        }
    }
}
