using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Sort
{
    class MergeSort
    {
        public void Merge_Sort(int[] numbers)
        {
            int[] temp = new int[numbers.Length];
            Merge_Sort(numbers, temp, 0, numbers.Length - 1);
        }
        public void Merge_Sort(int[] numbers, int[] temp, int start, int end)
        {
            if(start < end)
            {
                int middle = (start + end) / 2;
                Merge_Sort(numbers, temp, start, middle);
                Merge_Sort(numbers, temp, middle + 1, end);

                Merge(numbers, temp, start, middle, end);
            }
        }

        public void Merge(int[] numbers, int[] temp, int start, int mid, int end)
        {
            for(int i = start; i <= end; i++)
            {
                temp[i] = numbers[i];
            }

            int tempLeft = start;
            int tempRight = mid + 1;
            int current = start;

            while (tempLeft <= mid && tempRight <= end)
            {
                if (temp[tempLeft] <= temp[tempRight])
                {
                    numbers[current] = temp[tempLeft];
                    tempLeft++;
                }
                else
                {
                    numbers[current] = temp[tempRight];
                    tempRight++;
                }
                current++;
            }
            int remaining = mid - tempLeft;
            for(int i = 0; i <= remaining; i++)
            {
                numbers[current + i] = temp[tempLeft + i];
            }
        }

        //public static void Main()
        //{
        //    MergeSort mergeSort = new MergeSort();
        //    int[] numbers = { 7, 6, 5, 8, 3, 5, 9, 1 };
        //    mergeSort.Merge_Sort(numbers);
        //    for(int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}
    }
}
