using System;

namespace SearchBinary
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static int SearchBinary(int[] arr, int num)
        {
            int left = 0;
            int right = arr.Length - 1;
            int index = -1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                Console.WriteLine(mid);
                if (arr[mid] == num)
                {
                    index = mid;
                    right = -1;
                }
                else if (arr[mid] > num)
                {
                    right = mid - 1;
                }
                else if (arr[mid] < num)
                {
                    left = mid + 1;
                }
            }
            return index;
        }
    }
}
