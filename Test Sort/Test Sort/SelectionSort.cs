using System;
using TestSort;

namespace TestSort
{
    public class SelectionSort
    {
        public static void ArraySize() //User input for the array size (int[] array)
        {
            int n;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out n) || n < 1 || n > 1000)
            {
                Console.WriteLine("Ivalid input.");
                input = Console.ReadLine();
            }
            int[] newArray = new int[n];

            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                newArray[i] = rand.Next(1, 1000);
            }
        }
        public static void Sort(int[] arr)
        {
            
            int n = arr.Length;
            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }
                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
    }
}