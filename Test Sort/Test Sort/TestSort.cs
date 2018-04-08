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
    internal class TestSort
    {      
        public int success = 1;
        public int failure = 1;

        public static void sizeTestArray(int[] array) //User input for the array size
        {
            Console.Write("Enter array size: ");
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
            Console.WriteLine("Here is the unsorted array: ");
            Console.WriteLine(" ");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void SelectionSort(int[] arr) //Sorts array using selection sort
        {
            int numberOfSorts = 1;

            Console.WriteLine("Here is the sorted array: ");
            Console.WriteLine();
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
                numberOfSorts++;
            }
            Console.WriteLine("Number of Swaps: " + numberOfSorts);
            Console.WriteLine();
        }
        // Prints the sorted array
        public static void printSorted(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        // Driver code

        public static void Main()
        {
            int numberOfPreformedSorts = 0;

            do
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("1. Selection Sort"); //Let user input another array
                Console.WriteLine("2. Exit"); //Exit Program

                if (Console.ReadKey().Key == ConsoleKey.NumPad1) //what happens when 1 is pressed
                {
                    Console.WriteLine();
                    Console.WriteLine("Selection Sort");
                    Console.WriteLine(" ");
                    Console.WriteLine("Pick an array size between 1 and 1,000");

                    int Min = 1;
                    int Max = 1000;

                    int[] arr = new int[10];

                    Random randNum = new Random();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = randNum.Next(Min, Max);
                    }
                    sizeTestArray(arr);
                    SelectionSort(arr);
                    if (arr == null)
                    {
                        Console.WriteLine("Failure: ");
                    }
                    else
                    {
                        Console.WriteLine("Succsess: ");
                    }
                    printSorted(arr);

                    numberOfPreformedSorts++;
                    Console.WriteLine();
                    Console.WriteLine("Number of Sorts Preformed: " + numberOfPreformedSorts);

                }
                else if (Console.ReadKey().Key != ConsoleKey.NumPad2) //what happens when 2 is pressed
                {
                    Console.WriteLine("Exit");
                }
            } while (numberOfPreformedSorts != 4;
        }
    }
}