using Xunit;
using SinglyLinkedList;

namespace XUnitTestSinglyLinkedList
{
    public class UnitTestLinkedList
    {
        #region LinkedList
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();

            Assert.Null(list.Head);
        }
        #endregion

        #region Prepend()
        [Fact]
        public void CanPrependNodeToLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Prepend(1);

            Assert.Equal(1, list.Head.Value);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void PrependMultipleNodesToLinkedListAndCheckTheHead(int[] nums, int expected)
        {
            LinkedList<int> list = new LinkedList<int>();
            int actual = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    actual = nums[i];

                list.Prepend(nums[i]);
            }

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        public void PrependMultipleNodesToLinkedListAndCheckTheEnd(int[] nums, int expected)
        {
            LinkedList<int> list = new LinkedList<int>();
            int actual = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    actual = nums[i];

                list.Prepend(nums[i]);
            }

            Assert.Equal(expected, actual);
        }
        #endregion

        #region Append()
        [Fact]
        public void CanAppendNodeToLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Append(1);

            Assert.Equal(1, list.Head.Value);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        public void AppendMultipleNodesToLinkedListAndCheckTheHead(int[] nums, int expected)
        {
            LinkedList<int> list = new LinkedList<int>();
            int actual = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    actual = nums[i];

                list.Append(nums[i]);
            }

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] {  }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void AppendMultipleNodesToLinkedListAndCheckTheEnd(int[] nums, int expected)
        {
            LinkedList<int> list = new LinkedList<int>();
            int actual = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    actual = nums[i];

                list.Append(nums[i]);
            }

            Assert.Equal(expected, actual);
        }
        #endregion

        #region Lookup()
        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 0)]
        public void ReturnFalseForLookupWhenValueIsNotInLinkedList(int[] nums, int target)
        {
            LinkedList<int> list = new LinkedList<int>();

            foreach (var num in nums)
                list.Append(num);

            Assert.False(list.Lookup(target));
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void ReturnTrueForLookupWhenValueIsInLinkedList(int[] nums, int target)
        {
            LinkedList<int> list = new LinkedList<int>();

            foreach (var num in nums)
                list.Append(num);

            Assert.True(list.Lookup(target));
        }
        #endregion

        #region InsertAtIndex()
        [Theory]
        [InlineData(new int[] { }, 0, 5)]
        [InlineData(new int[] { 1, 3, 2 }, 0, 5)]
        [InlineData(new int[] { 1, 3, 2 }, 1, 5)]
        [InlineData(new int[] { 1, 3, 2 }, 2, 5)]
        [InlineData(new int[] { 1, 3, 2 }, 3, 5)]
        public void CanInsertAtIndex(int[] nums, int index, int value)
        {
            LinkedList<int> list = new LinkedList<int>();

            foreach (var num in nums)
                list.Append(num);

            list.InsertAtIndex(index, value);

            Assert.Equal(value, list.GetNodeFromIndex(index).Value);
        }
        #endregion

        #region DeleteAtIndex()
        [Theory]
        //[InlineData(new int[] { 1, 3, 2 }, 0, "HEAD -> 3 -> 2 -> NULL")]
        [InlineData(new int[] { 1, 3, 2 }, 1, "HEAD -> 1 -> 2 -> NULL")]
        [InlineData(new int[] { 1, 3, 2 }, 2, "HEAD -> 1 -> 3 -> NULL")]
        public void CanDeleteAtIndex(int[] nums, int index, string expected)
        {
            LinkedList<int> list = new LinkedList<int>();

            foreach (var num in nums)
                list.Append(num);

            list.DeleteAtIndex(index);

            Assert.Equal(expected, list.ToString());
        }
        #endregion

        #region ToString()
        [Theory]
        [InlineData(new int[] { }, "HEAD -> NULL")]
        [InlineData(new int[] { 1 }, "HEAD -> 1 -> NULL")]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, "HEAD -> 1 -> 2 -> 3 -> 4 -> 5 -> NULL")]
        public void CanPrintLinkedList(int[] nums, string expected)
        {
            LinkedList<int> list = new LinkedList<int>();

            foreach (var num in nums)
                list.Append(num);

            Assert.Equal(expected, list.ToString());
        }
        #endregion
    }
}
