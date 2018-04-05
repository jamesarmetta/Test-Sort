/*
 * James Armetta
 * 1009459
 * 4/9/18 
 * CSCI-335
 * Test Sort
 */
using System;

namespace TestSort
{
    class TestSort
    {
        static void PickArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out array[i]))
                {
                    // Tell the user something went wrong:
                    Console.WriteLine("Sorry, '{0}' is not a valid number.", input);
                    // Don't move to the next array element:
                    i--;
                }
            }
        }
        static void sort(int[] arr)
        {
            int n = arr.Length;
            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
        // Prints the array
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        // Driver code 
        public static void Main()
        {
            Console.WriteLine("Pick an array size between 1 and 1,000");
            
            int[] arr = { 0 };
            PickArray(arr);
            sort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);

            Console.WriteLine("1. Selection Sort");
            Console.WriteLine("2. Exit");

            while (Console.ReadKey().Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Selection Sort");
            }
            while (Console.ReadKey().Key != ConsoleKey.NumPad2)
            {
                Console.WriteLine("Exit");
            }           
        }
    }
}