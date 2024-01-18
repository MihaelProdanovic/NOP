using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaSearch
{
    class Search
    {
        public int BinarySearch(int[] arr, int x)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; 
        }
    }

    class Program
    {
        static void Main()
        {
            Search searcher = new Search();

           
            int[] arr = new int[100];
            for (int i = 0, value = 1; i < 100; i++, value += 2)
            {
                arr[i] = value;
            }

            
            int index = searcher.BinarySearch(arr, 75);

            
            if (index != -1)
            {
                Console.WriteLine($"Broj 75 pronađen na indeksu: {index}");
            }
            else
            {
                Console.WriteLine("Broj 75 nije pronađen u nizu.");
            }

           
            Console.ReadLine();
        }
    }
}
