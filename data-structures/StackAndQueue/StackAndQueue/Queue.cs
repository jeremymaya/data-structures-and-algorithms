using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        private Node<T> Rear { get; set; }

        public Queue()
        {
            Rear = Front;
        }

        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);

            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
                return default;

            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp.Value;
        }

        public T Peek()
        {
            return Front.Value;
        }

        public bool IsEmpty()
        {
            return Front == null;
        }
    }
}
