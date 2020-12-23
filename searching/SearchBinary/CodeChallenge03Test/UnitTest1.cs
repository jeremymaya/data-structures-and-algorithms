using System;
using Xunit;
using SearchBinary;

namespace CodeChallenge03Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, new int[] { 4, 8, 15, 16, 23, 42 }, 4)]
        [InlineData(-1, new int[] { 11, 22, 33, 44, 55, 66, 77 }, 90)]
        [InlineData(0, new int[] { 4 }, 4)]
        public void ExpectedOutcome(int index, int[] arr, int num)
        {
            Assert.Equal(index, Program.SearchBinary(arr, num));
        }

        [Theory]
        [InlineData(2, new int[] { 4, 8, 15, 16, 23, 42 }, 16)]
        [InlineData(1, new int[] { 11, 22, 33, 44, 55, 66, 77 }, 9)]
        [InlineData(1, new int[] { 4, 4 }, 4)]
        [InlineData(0, new int[] { }, 4)]
        public void ExpectedFailure(int index, int[] arr, int num)
        {
            Assert.NotEqual(index, Program.SearchBinary(arr, num));
        }

        [Theory]
        [InlineData(0, new int[] { 4, 4 }, 4)]
        [InlineData(-1, new int[] { }, 4)]
        public void EdgeCase(int index, int[] arr, int num)
        {
            Assert.Equal(index, Program.SearchBinary(arr, num));
        }
    }
}
