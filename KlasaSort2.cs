using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaSort2
{
    class Sort
    {
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] >= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
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
            
            int[] arr = { 5, 2, 8, 1, 4, 7, 3, 6 };

            
            Sort.QuickSort(arr, 0, arr.Length - 1);

          
            Console.WriteLine("Sortirani niz u silaznom redoslijedu:");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }

            
            Console.ReadLine();
        }
    }
}
