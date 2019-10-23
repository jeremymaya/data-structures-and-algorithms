using System;
namespace LinkedList.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(value);
            }

        }

        public void InsertBefore(int value, int newValue)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node previous = null;
                Node current = Head;
                while (current.Value != value)
                {
                    previous = current;
                    current = current.Next;
                }
                if(previous == null)
                {
                    Head = new Node(newValue);
                }
                else
                {
                    previous.Next = new Node(newValue);
                }
            }
        }

        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Value != value)
                {
                    current = current.Next;
                }
                current.Next = new Node(newValue);
            }
        }
    }
}
