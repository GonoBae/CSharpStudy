using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Sort
{
    class QuickSort
    {
        void quickSort(int[] arr, int left, int right)
        {
            int index = partition(arr, left, right);
            if (left < index - 1)
                quickSort(arr, left, index - 1);
            if (index < right)
                quickSort(arr, index, right);
        }
        int partition(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while(left <= right)
            {
                while (arr[left] < pivot) left++; // pivot 값보다 크거나 같은 값을 만날 때까지
                while(arr[right] > pivot) right--; // pivot 값보다 작거나 같은 값을 만날 때까지

                if(left <= right) // 엇갈리지 않았다면
                {
                    Swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }
        void Swap(int[] arr, int left, int right)
        {
            var tmp = arr[left];
            arr[left] = arr[right];
            arr[right] = tmp;
        }
        //public static void Main()
        //{
        //    QuickSort quickSort = new QuickSort();
        //    int[] numbers = { 7, 6, 5, 8, 3, 5, 9, 1 };
        //    quickSort.quickSort(numbers, 0, numbers.Length - 1);
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}
    }
}
