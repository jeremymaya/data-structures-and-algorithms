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

        public LinkedList MergeLists(LinkedList listOne, LinkedList listTwo)
        {
            Node currentOne = listOne.Head;
            Node currentTwo = listTwo.Head;
            Node mergedNode = null;

            bool iterate = true;
            while (iterate)
            {
                mergedNode = currentOne;
                currentOne = currentOne.Next;

                if (currentTwo != null)
                {
                    mergedNode.Next = new Node(currentTwo.Value);
                    currentTwo = currentTwo.Next;
                }
                if (currentOne != null)
                {
                    mergedNode.Next = new Node(currentOne.Value);
                    currentOne = currentOne.Next;
                }
                if (currentOne == null & currentTwo == null)
                {
                    iterate = false;
                }
            }


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
            return mergedList;
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
