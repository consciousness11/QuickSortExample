using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortExample
{
    class Program
    {
        private static void Quick_Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(arr, start, end);

                if (pivot > 1)
                {
                    Quick_Sort(arr, start, pivot - 1);
                }
                if (pivot + 1 < end)
                {
                    Quick_Sort(arr, pivot + 1, end);
                }
            }

        }

        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            while (true)
            {

                while (arr[start] < pivot)
                {
                    start++;
                }

                while (arr[end] > pivot)
                {
                    end--;
                }

                if (start < end)
                {
                    if (arr[start] == arr[end]) return end;

                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;


                }
                else
                {
                    return end;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    
}
