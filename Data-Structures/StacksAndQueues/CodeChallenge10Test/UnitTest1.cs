using System;
using Xunit;
using StacksAndQueues.Classes;

namespace CodeChallenge10Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyPushOntoAStack()
        {
            Stack testStack = new Stack();
            testStack.Push(1);

            Assert.Equal(1, testStack.Top.Value);
        }

        [Fact]
        public void CanSuccessfullyPushMultipleValuesOntoAStackTop()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);

            Assert.Equal(2, testStack.Top.Value);
        }

        [Fact]
        public void CanSuccessfullyPushMultipleValuesOntoAStackNext()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);

            Assert.Equal(1, testStack.Top.Next.Value);
        }

        [Fact]
        public void CanSuccessfullyPopOffTheStack()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);

            Assert.Equal(2, testStack.Pop());
        }

        [Fact]
        public void CanSuccessfullyEmptyAStackAfterMultiplePops()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);
            testStack.Pop();
            testStack.Pop();

            Assert.True(testStack.IsEmpty());
        }

        [Fact]
        public void CanSuccessfullyPeekTheNextItemOnTheStack()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);

            Assert.Equal(2, testStack.Peek());
        }

        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyStack()
        {
            Stack testStack = new Stack();

            Assert.True(testStack.IsEmpty());
        }

        [Fact]
        public void CanSuccessfullyEnqueueIntoAQueue()
        {
            Queue testQueue = new Queue();
            testQueue.QueueTheValue(1);

            Assert.Equal(1, testQueue.Front.Value);
        }

        [Fact]
        public void CanSuccessfullyEnqueueMultipleValuesIntoAQueueFront()
        {
            Queue testQueue = new Queue();
            testQueue.QueueTheValue(1);
            testQueue.QueueTheValue(2);

            Assert.Equal(1, testQueue.Front.Value);
        }

        [Fact]
        public void CanSuccessfullyEnqueueMultipleValuesIntoAQueueEnd()
        {
            Queue testQueue = new Queue();
            testQueue.QueueTheValue(1);
            testQueue.QueueTheValue(2);

            Assert.Equal(2, testQueue.Front.Next.Value);
        }

        [Fact]
        public void CanSuccessfullyDequeueOutOfAQueueTheExpectedValue()
        {
            Queue testQueue = new Queue();
            testQueue.QueueTheValue(1);
            testQueue.QueueTheValue(2);

            Assert.Equal(1, testQueue.Dequeue());
        }
    }
}
