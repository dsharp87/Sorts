using System;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[]{5,1,4,8,2};
            arr = bubSort(arr);
        }

        //On^2 as its a nested loop
        public static int[] bubSort(int[] arr)
        {
            bool swapped = true;
            while(swapped)
            {
                if(swapped)
                {
                    swapped = false;
                }
                for(int i = 0; i < arr.Length - 1; i++)
                {
                    if(arr[i] > arr[i+1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        swapped = true;
                    }
                }

            }
            return arr;
        }
    }
}
