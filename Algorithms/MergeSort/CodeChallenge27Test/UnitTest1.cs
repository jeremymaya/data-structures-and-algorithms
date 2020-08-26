using System;
using Xunit;
using MergeSort;

namespace CodeChallenge27Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortARandomlySortedArray()
        {
            int[] random = { 8, 4, 23, 42, 16, 15 };

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, Program.MergeSort(random));
        }

        [Fact]
        public void CanSortAReverseSortedArray()
        {
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };

            Assert.Equal(new int[] { -2, 5, 8, 12, 18, 20 }, Program.MergeSort(reverseSorted));
        }

        [Fact]
        public void CanSortAFewUniquesArray()
        {
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };

            Assert.Equal(new int[] { 5, 5, 5, 7, 7, 12 }, Program.MergeSort(fewUniques));
        }

        [Fact]
        public void CanSortANearlySortedArray()
        {
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13 }, Program.MergeSort(nearlySorted));
        }

        [Fact]
        public void CanSortARandomlySortedArrayExpectedFailure()
        {
            int[] random = { 8, 4, 23, 42, 16, 15 };

            Assert.NotEqual(new int[] { 8, 4, 23, 42, 16, 15 }, Program.MergeSort(random));
        }
    }
}
