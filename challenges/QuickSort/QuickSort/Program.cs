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

        static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
