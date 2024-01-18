using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaSort
{
    class Sort
    {
        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    class Program
    {
        static void Main()
        {
            Sort sorter = new Sort();

          
            int[] arr = { 5, 2, 8, 1, 4, 7, 3, 6 };

           
            sorter.QuickSort(arr, 0, arr.Length - 1);

           
            Console.WriteLine("Sortirani niz:");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }

            
            Console.ReadLine();
        }
    }
}
