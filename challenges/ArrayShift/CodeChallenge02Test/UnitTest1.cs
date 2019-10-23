using System;
using Xunit;
using static ArrayShift.Program;

namespace CodeChallenge02Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8 }, 5, new int[] { 2, 4, 5, 6, 8 })]
        [InlineData(new int[] { 4, 8, 15, 23, 42 }, 16, new int[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new int[] { 1 }, 4, new int[] { 1, 4 })]
        public void ExpectedOutcome(int[] arr, int num, int[] newArr)
        {
            Assert.Equal(newArr, insertShiftArray(arr, num));
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8 }, 5, new int[] { 2, 4, 6, 8 })]
        [InlineData(new int[] { 4, 8, 15, 23, 42 }, 16, new int[] { 4, 8, 16, 15, 23, 42 })]
        [InlineData(new int[] { 1 }, 4, new int[] { 4, 1 })]
        public void ExpectedFailure(int[] arr, int num, int[] newArr)
        {
            Assert.NotEqual(newArr, insertShiftArray(arr, num));
        }
        [Fact]
        public void EdgeCase()
        {
            int[] arr = { };
            int num = 1;
            int[] newArr = { 1 };
            Assert.Equal(newArr, insertShiftArray(arr, num));
        }
    }
}
