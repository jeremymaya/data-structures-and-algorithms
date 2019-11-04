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

            Assert.Equal(2, testStack.Pop());
        }

    }
}
