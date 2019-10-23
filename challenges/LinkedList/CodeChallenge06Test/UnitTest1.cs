using System;
using Xunit;

namespace CodeChallenge06Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddANodeToTheEndOfALinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(2);
            testList.Append(5);

            Assert.Equal(5, testList.Head.Next.Next.Next.Value);
        }

        [Fact]
        public void CanAddMultipleNodesToTheEndOfALinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(2);
            testList.Append(5);

            Assert.Equal(2, testList.Head.Next.Next.Value);
        }

        [Fact]
        public void CanInsertBeforeANodeInTheMiddleOfTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(2);
            testList.InsertBefore(3, 5);

            Assert.Equal(5, testList.Head.Next.Value);
        }

        [Fact]
        public void CanInsertBeforeTheFirstNodeOfTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(2);
            testList.InsertBefore(1, 5);

            Assert.Equal(5, testList.Head.Value);
        }

        [Fact]
        public void CanInsertAfterANodeInTheMiddleOfTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(2);
            testList.InsertAfter(3, 5);

            Assert.Equal(5, testList.Head.Next.Next.Value);
        }

        [Fact]
        public void CanInsertAfterTheNodeInTheLastNodeOfTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(2);
            testList.InsertAfter(2, 5);

            Assert.Equal(5, testList.Head.Next.Next.Next.Value);
        }
    }
}
