using System.Text;

namespace SinglyLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        private Node<T> TraverseToEnd()
        {
            Node<T> current = Head;

            while (current != null && current.Next != null)
                current = current.Next;

            return current;
        }

        public Node<T> GetNodeFromIndex(int index)
        {
            Node<T> current = Head;

            for (int i = 0; i < index && current != null; i++)
                current = current.Next;

            return current;
        }


        public void Prepend(T value)
        {
            Node<T> current = new Node<T>(value)
            {
                Next = Head
            };

            Head = current;
        }

        public void Append(T value)
        {
            if (Head == null)
            {
                Prepend(value);
                return;
            }

            Node<T> previous = TraverseToEnd();
            Node<T> current = new Node<T>(value);

            previous.Next = current;
        }


        public bool Lookup(T value)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public void InsertAtIndex(int index, T value)
        {
            if (index == 0)
            {
                Prepend(value);
                return;
            }

            Node<T> previous = GetNodeFromIndex(index - 1);

            if (previous == null)
                return;

            Node<T> current = new Node<T>(value);
            Node<T> next = previous.Next;

            current.Next = next;
            previous.Next = current;
        }

        public void DeleteAtIndex(int index)
        {
            Node<T> current = GetNodeFromIndex(index);

            if (current == null)
                return;

            Node<T> previous = GetNodeFromIndex(index - 1);
            Node<T> next = current.Next;

            if (previous != null)
                previous.Next = next;
            else
                Head = next;
        }

        public override string ToString()
        {
            Node<T> current = Head;

            StringBuilder sb = new StringBuilder();

            sb.Append("HEAD -> ");

            while (current != null)
            {
                sb.Append($"{current.Value} -> ");
                current = current.Next;
            }

            sb.Append("NULL");

            return sb.ToString();
        }
    }
}
