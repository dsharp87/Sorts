using System;

namespace selectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{4,8,2,7,9,4,1,5,6};
            arr = selectSort(arr);
            System.Console.WriteLine("done");
        }

        public static int[] selectSort (int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int minIdx = i;
                int min = arr[i];
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < min)
                    {
                        min = arr[j];
                        minIdx = j;
                    }
                }
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}
