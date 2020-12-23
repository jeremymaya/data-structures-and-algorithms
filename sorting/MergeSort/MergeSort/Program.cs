using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] random = { 8, 4, 23, 42, 16, 15 };
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine("[ " + string.Join(", ", MergeSort(random)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", MergeSort(reverseSorted)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", MergeSort(fewUniques)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", MergeSort(nearlySorted)) + " ]");
        }

        /// <summary>
        /// A recursive method which uses the divide-and-conquer approach sort an array
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <returns>Sorted Array</returns>
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < n; i++)
                {
                    if (i < mid)
                    {
                        left[i] = arr[i];
                    }
                    else
                    {
                        right[i - mid] = arr[i];
                    }
                }

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }

            return arr;
        }

        /// <summary>
        /// A method that iterates left and right half of the arrays and rearranges values
        /// </summary>
        /// <param name="left">Left half of the array</param>
        /// <param name="right">Right half of the array</param>
        /// <param name="arr">Array to be sorted</param>
        static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right [j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            if (i == left.Length)
            {
                while (j < right.Length)
                {
                    arr[k] = right[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < left.Length)
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }
            }
        }
    }
}
