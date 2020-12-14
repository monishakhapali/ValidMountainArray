using System;

namespace ValidMountain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2 };
            Console.WriteLine(ValidMountainArray(arr));
            Console.ReadLine();

        }

        public static bool ValidMountainArray(int[] arr)
        {
            int i = 0;
            while (i + 1 < arr.Length && arr[i] < arr[i + 1])
            {
                i++;
            }
            if (i == 0 || i == arr.Length - 1)
            {
                return false;
            }

            while (i + 1 < arr.Length && arr[i] > arr[i + 1])
            {
                i++;
            }
            return i == arr.Length - 1;
        }
    }
}
