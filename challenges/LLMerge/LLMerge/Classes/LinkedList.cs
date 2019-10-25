using System;
namespace LLMerge.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public Node MergeLists(LinkedList listOne, LinkedList listTwo)
        {
            Node currentOne = listOne.Head;
            Node currentTwo = listTwo.Head;

            LinkedList mergedList = new LinkedList();
            mergedList.Append(currentOne.Value);
            currentOne = currentOne.Next;
            Node tracker = mergedList.Head;

            int count = 1;
            while (currentOne != null && currentTwo != null)
            {
                if (count % 2 == 0)
                {
                    tracker.Next = new Node(currentOne.Value);
                    currentOne = currentOne.Next;
                }
                if (count % 2 == 1)
                {
                    tracker.Next = new Node(currentTwo.Value);
                    currentTwo = currentTwo.Next;
                }
                tracker = tracker.Next;
                count++;
            }
            tracker = mergedList.Head;
            return tracker;
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
    }
}
