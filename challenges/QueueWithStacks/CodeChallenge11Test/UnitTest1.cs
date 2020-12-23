using System;
using System.Collections.Generic;
using QueueWithStacks.Classes;
using Xunit;

namespace CodeChallenge11Test
{
    public class UnitTest1
    {
        [Fact]
        public void LifoForStackFifoForQueueExpectedOutcome()
        {
            Stack<int> testStack = new Stack<int>();
            testStack.Push(5);
            testStack.Push(10);
            testStack.Push(15);
            testStack.Push(20);

            PseudoQueue testQueue = new PseudoQueue();
            testQueue.Enqueue(20);
            testQueue.Enqueue(15);
            testQueue.Enqueue(10);
            testQueue.Enqueue(5);


            Assert.Equal(testStack.Pop(), testQueue.Dequeue());
        }

        [Fact]
        public void LifoForStackFifoForQueueExpectedFailure()
        {
            Stack<int> testStack = new Stack<int>();
            testStack.Push(5);
            testStack.Push(10);
            testStack.Push(15);
            testStack.Push(20);

            PseudoQueue testQueue = new PseudoQueue();
            testQueue.Enqueue(5);
            testQueue.Enqueue(10);
            testQueue.Enqueue(15);
            testQueue.Enqueue(20);

            Assert.NotEqual(testStack.Pop(), testQueue.Dequeue());
        }

        [Fact]
        public void EnqueueAndDequeueWorksEdgeCase()
        {
            PseudoQueue testQueue = new PseudoQueue();
            testQueue.Enqueue(5);

            Assert.Equal(5, testQueue.Dequeue());
        }

        [Fact]
        public void DequeueWorksEdgeCase()
        {
            PseudoQueue testQueue = new PseudoQueue();

            Assert.Throws<InvalidOperationException>(() => testQueue.Dequeue());
        }
    }
}
