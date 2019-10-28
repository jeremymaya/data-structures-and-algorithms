using System;
using Xunit;

namespace CodeChallenge06Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();

            Assert.Null(testList.Head);
        }

        [Fact]
        public void CanProperlyInsertIntoTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Insert(1);

            Assert.Equal(1, testList.Head.Value);
        }

        [Fact]
        public void TheHeadPropertyWillProperlyPointToTheFirstNodeInTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Insert(5);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(1);

            Assert.Equal(1, testList.Head.Value);
        }

        [Fact]
        public void CanProperlyInsertMultipleNodesIntoTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Insert(5);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(1);

            Assert.Equal(3, testList.Head.Next.Value);
        }

        [Fact]
        public void WillReturnTrueWhenFindingAValueWithinTheLinkedListThatExists()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Insert(5);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(1);

            Assert.True(testList.Include(5));
        }

        [Fact]
        public void WillReturnFalseWhenSearchingForAValueInTheLinkedListThatDoesNotExist()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Insert(5);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(1);

            Assert.False(testList.Include(9));
        }

        [Fact]
        public void CanProperlyReturnACollectionOfAllTheValuesThatExistInTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Insert(5);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(1);

            Assert.Equal("1 3 2 5 ", testList.ListToString());
        }


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

        [Fact]
        public void KIsGreaterThanTheLengthOfTheLinkedList()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(8);
            testList.Append(2);

            Assert.Throws<NullReferenceException>(() => testList.KthFromEnd(6));
        }

        [Fact]
        public void KAndTheLengthOfTheListAreTheSame()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(8);
            testList.Append(2);

            Assert.Throws<NullReferenceException>(() => testList.KthFromEnd(4));
        }

        [Fact]
        public void KIsNotAPositiveInteger()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(8);
            testList.Append(2);
        }

        [Fact]
        public void LinkedListIsOfASizeOne()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);

            Assert.Equal(1, testList.KthFromEnd(0));
        }

        [Fact]
        public void HappyPathKthFromEnd()
        {
            LinkedList.Classes.LinkedList testList = new LinkedList.Classes.LinkedList();
            testList.Append(1);
            testList.Append(3);
            testList.Append(8);
            testList.Append(2);

            Assert.Equal(3, testList.KthFromEnd(2));
        }
    }
}
