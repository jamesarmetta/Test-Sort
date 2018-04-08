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
        private int numberOfSorts = 1;
        private int numberOfPreformedSorts = 0;
        private int sizeTestArray = 0;
        private int success = 1;
        private int failure = 1;

        //public static int GetIntFromUser(int minVal, int maxVal);
        //public static int[] GetRandomizedArray(int size, int minRndVal, int maxRndVal);
        //int[] randomValues = GetRandomizedArray(GetIntFromUser(1, 1000), 1, 1000);
        public static void ArraySize(int[] array) //User input for the array size
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
            Console.WriteLine("The Array Before Selection Sort is: ");
            Console.WriteLine(" ");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        /*
         static void PickArray(int[] array) //User input for the array size
         {
             int[] newArray = new int[n];
             for (int i = 0; i < array.Length; i++)
             {
                 Console.Write("Enter array size: ");
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
         */
        public static void Sort(int[] arr) //Sorts array using selection sort
        {
            Console.WriteLine("The Array After Selection Sort is: ");
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
            }
        }
        // Prints the original array
        public static void printArray(int[] arr)
        {

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
                    int Max = 200;

                    int[] arr = new int[100];

                    Random randNum = new Random();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = randNum.Next(Min, Max);
                    }
                    ArraySize(arr);
                    Sort(arr);
                    
                    printSorted(arr);
                }
                else if (Console.ReadKey().Key != ConsoleKey.NumPad2) //what happens when 2 is pressed
                {
                    Console.WriteLine("Exit");
                }
            } while (true);
        }
    }
}