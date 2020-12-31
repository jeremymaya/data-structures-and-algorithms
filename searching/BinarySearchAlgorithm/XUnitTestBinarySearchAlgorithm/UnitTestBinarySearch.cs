using System;
using Xunit;
using static BinarySearchAlgorithm.Program;

namespace XUnitTestBinarySearchAlgorithm
{
    public class UnitTestBinarySearch
    {
        [Theory]
        [InlineData(new int[] { }, 0, -1)]
        [InlineData(new int[] { 1 }, 1, 0)]
        [InlineData(new int[] { 1, 2 }, 1, 0)]
        [InlineData(new int[] { 1, 2, 3}, 2, 1)]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 15, 2)]
        [InlineData(new int[] { 11, 22, 33, 44, 55, 66, 77 }, 90, -1)]
        public void CanSuccessfullyFindTheTargetElementAndReturnCorrectOutput(int[] nums, int target, int expected)
        {
            Assert.Equal(expected, BinarySearch(nums, target));
        }
    }
}
