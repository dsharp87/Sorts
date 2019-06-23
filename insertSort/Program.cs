using System;

namespace insertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[]{4,3,2,10,12,1,5,6};
            arr = insertionSort(arr);
            System.Console.WriteLine("done");
        }

        static int[] insertionSort(int[] arr)
        {
            //iterate through entire array except last value
            for(int i = 1; i < arr.Length; i++)
            {
                int temp  = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > temp)
                {
                    arr[j+ 1] = arr[j];
                    j--;
                }
                 arr[j + 1] = temp;
            }
            return arr;
        }
    }
}
