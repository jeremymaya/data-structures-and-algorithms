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
            Node testNode = new Node(1);
            Stack testStack = new Stack();
            testStack.Push(1);

            Assert.Equal(1, testStack.Top.Value);
        }

        [Fact]
        public void CanSuccessfullyPushMultipleValuesOntoAStack()
        {
            Node testNode = new Node(1);
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);

            Assert.Equal(2, testStack.Top.Value);
        }
    }
}
