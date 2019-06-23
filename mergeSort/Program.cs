using System;

namespace mergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arrpractice = new int[]{2,4,5,6,8,6,8,9,10};
            // arrpractice = merge(arrpractice, 0, 8, 4);
            // int[] arr2 = new int[]{4,6,8,9,10};
            // int[] mergedarr = merge(arr1, arr2);
            int[] arr3 = new int[]{5,2,8,6,2,7,8,3,2,4,6,9,5,2,2};
            int[] sorted = mergeSorter(arr3, 0, arr3.Length - 1);
            System.Console.WriteLine("done");
        }


        static int[] mergeSorter(int[] arr, int left, int right)
        {
            if(right > left)
            {
                int mid = (left + right)/2;
                arr = mergeSorter(arr, left, mid);
                arr = mergeSorter(arr, mid + 1, right);
                arr = merge(arr, left, right, mid);
            }
            return arr;
        }

        static int[] merge(int [] arr, int left, int right, int mid)
        {
            //find the lower value that is first
            //establish 2 index counters, 1 for each array
            int[] arr1 = new int[mid- left + 1];
            int[] arr2  = new int[right - mid];
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[left + i];
            }
            for(int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = arr[mid + j + 1];
            }
            int idx1 = 0;
            int idx2 = 0;
            for(int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                if(idx1 < arr1.Length && idx2 < arr2.Length)
                {
                    if(arr1[idx1] < arr2[idx2])
                    {
                        arr[left + i] = arr1[idx1];
                        idx1++;
                    }
                    else
                    {
                        arr[left + i] = arr2[idx2];
                        idx2++;
                    }
                }
                else if(idx1 == arr1.Length)
                {
                    arr[left + i] = arr2[idx2];
                    idx2++;
                }
                else
                {
                    arr[left + i] = arr1[idx1];
                    idx1++;
                }
            }
            return arr;
        }
    }
}
