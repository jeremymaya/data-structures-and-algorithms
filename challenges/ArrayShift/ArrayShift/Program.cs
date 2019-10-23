using System;

namespace ArrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int[] insertShiftArray(int[] arr, int num)
        {
            int[] newArr = new int[(arr.Length + 1)];
            double middle= Math.Ceiling(arr.Length / 2.0);

            for (int i = 0; i <= arr.Length; i++)
            {
                if (i < middle)
                {
                    newArr[i] = arr[i];
                }
                else if (i == middle)
                {
                    newArr[i] = num;
                }
                else if (i > middle)
                {
                    newArr[i] = arr[i - 1];
                }
            }
            return newArr;
        }
}
}
