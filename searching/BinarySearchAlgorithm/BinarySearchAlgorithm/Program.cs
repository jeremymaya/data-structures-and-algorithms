using System;

namespace BinarySearchAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {      
        }

        public static int BinarySearch(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int pivot = left + (right - left) / 2;

                if (nums[pivot] == target)
                    return pivot;

                if (target < nums[pivot])
                    right = pivot - 1;
                else
                    left = pivot + 1;
            }

            return -1;
        }
    }
}
