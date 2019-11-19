using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] random = { 8, 4, 23, 42, 16, 15 };
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine("[ " + string.Join(", ", InsertionSort(random)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", InsertionSort(reverseSorted)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", InsertionSort(fewUniques)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", InsertionSort(nearlySorted)) + " ]");
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }

                arr[j + 1] = temp;
            }

            return arr;
        }
    }
}
