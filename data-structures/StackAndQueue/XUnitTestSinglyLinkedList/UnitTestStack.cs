using System;
using Xunit;
using StackAndQueue;

namespace XUnitTestSinglyLinkedList
{
    public class UnitTestStack
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyStack()
        {
            Stack<char> stack = new Stack<char>();

            Assert.NotNull(stack);
        }

        [Fact]
        public void CanSuccessfullyPushOntoAStack()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("candy cane");

            Assert.NotNull(stack.Top);
            Assert.Equal("candy cane", stack.Top);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 3 }, 3)]
        public void CanSuccessfullyPushMultipleValuesOntoAStack(int[] nums, int expected)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int num in nums)
                stack.Push(num);

            Assert.Equal(expected, stack.Top);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 3 }, 3)]
        public void CanSuccessfullyPopOffTheStack(int[] nums, int expected)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int num in nums)
                stack.Push(num);

            Assert.Equal(expected, stack.Pop());
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        public void CanSuccessfullyEmptyAStackAfterMultiplePops(int[] nums)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int num in nums)
                stack.Push(num);

            while (!stack.IsEmpty())
                stack.Pop();

            Assert.Equal(default, stack.Peek());
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 3 }, 3)]
        public void CanSuccessfullyPeekTheNextItemOnTheStack(int[] nums, int expected)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int num in nums)
                stack.Push(num);

            Assert.Equal(expected, stack.Peek());
        }
    }
}
