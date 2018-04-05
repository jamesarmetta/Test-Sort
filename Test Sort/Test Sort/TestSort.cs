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
        static void PickArray(int[] array) //User input for the array size
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
        static void Sort(int[] arr) //Sorts array using selection sort
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

            //int Min = 1;
            //int Max = 1000;

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero

            int[] arr = new int[1000];
            //int[] arr = new int[1000];
/*
            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);              
            }
*/
            //int[] arr = { 0,0,0 };
            PickArray(arr);
            Sort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);

            Console.WriteLine("1. Selection Sort"); //Let user input another array
            Console.WriteLine("2. Exit"); //Exit Program

            if(Console.ReadKey().Key == ConsoleKey.NumPad1) //what happens when 1 is pressed
            {
                Console.WriteLine(" ");
                Console.WriteLine("Selection Sort");

                
            }
            else if (Console.ReadKey().Key != ConsoleKey.NumPad2) //what happens when 2 is pressed
            {
                Console.WriteLine("Exit");
            }           
        }
    }
}