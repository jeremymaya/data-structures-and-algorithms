using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] random = { 8, 4, 23, 42, 16, 15 };
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine("[ " + string.Join(", ", QuickSort(random, 0, random.Length - 1)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", QuickSort(reverseSorted, 0, reverseSorted.Length - 1)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", QuickSort(fewUniques, 0, fewUniques.Length - 1)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", QuickSort(nearlySorted, 0, nearlySorted.Length - 1)) + " ]");
        }

        /// <summary>
        /// A recursive method which uses the divide-and-conquer approach sort an array
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="left">Leftmost position of the array</param>
        /// <param name="right">Rightmost position of the array</param>
        /// <returns>A sorted Array</returns>
        public static int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);
                QuickSort(arr, position + 1, right);
            }

            return arr;
        }

        /// <summary>
        /// A method that partitions the array arr so that:
        /// Left side of pivot contains values less than the pivot
        /// Righr side of pivot contains values greater than the pivot
        /// </summary>
        /// <param name="arr">Array to be partitioned</param>
        /// <param name="left">Leftmost position of the array</param>
        /// <param name="right">Rightmost position of the array</param>
        /// <returns>Position of the pivot</returns>
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }

            Swap(arr, right, low + 1);

            return low + 1;
        }

        /// <summary>
        /// A method that rearranges the partitioned array
        /// </summary>
        /// <param name="arr">Partitioned array</param>
        /// <param name="i">Current index position</param>
        /// <param name="low">Reference position for the pivot</param>
        static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
