using System;
using Xunit;
using StackAndQueue;

namespace XUnitTestSinglyLinkedList
{
    public class UnitTestQueue
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyQueue()
        {
            Queue<char> queue = new Queue<char>();

            Assert.NotNull(queue);
        }

        [Fact]
        public void CanSuccessfullyEnqueueIntoAQueue()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("candy cane");

            Assert.NotNull(queue.Front);
            Assert.Equal("candy cane", queue.Front.Value);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 1)]
        [InlineData(new int[] { 2, 3 }, 2)]
        [InlineData(new int[] { 3, 4 }, 3)]
        public void CanSuccessfullyEnqueueMultipleValuesIntoAQueue(int[] nums, int expected)
        {
            Queue<int> queue = new Queue<int>();

            foreach (int num in nums)
                queue.Enqueue(num);

            Assert.Equal(expected, queue.Front.Value);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 1)]
        [InlineData(new int[] { 2, 3 }, 2)]
        [InlineData(new int[] { 3, 4 }, 3)]
        public void CanSuccessfullyDequeueOutOfAQueueTheExpectedValue(int[] nums, int expected)
        {
            Queue<int> queue = new Queue<int>();

            foreach (int num in nums)
                queue.Enqueue(num);

            Assert.Equal(expected, queue.Dequeue());
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 1)]
        [InlineData(new int[] { 2, 3 }, 2)]
        [InlineData(new int[] { 3, 4 }, 3)]
        public void CanSuccessfullyPeekIntoAQueueSeeingTheExpectedValue(int[] nums, int expected)
        {
            Queue<int> queue = new Queue<int>();

            foreach (int num in nums)
                queue.Enqueue(num);

            Assert.Equal(expected, queue.Peek());
        }

        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        public void CanSuccessfullyEmptyAQueueAfterMultipleDequeus(int[] nums)
        {
            Queue<int> queue = new Queue<int>();

            foreach (int num in nums)
                queue.Enqueue(num);

            while (!queue.IsEmpty())
                queue.Dequeue();

            Assert.Null(queue.Front);
        }
    }
}
