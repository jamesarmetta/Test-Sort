/*
 * James Armetta
 * 1009459
 * 4/30/18
 * CSCI-335
 * Test Sort
 */
using System;

namespace TestSort
{
    internal class TestSort
    {      
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
            Console.WriteLine("> Here is the unsorted array: ");
            Console.WriteLine(" ");
            for (int i = 0; i < array.Length; ++i) //prints the array in current method
            {
                Console.Write(array[i] + "-");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void BubbleSort(int[] arr) // sorts array using bubble sort
        {
            int temp = 0; // starts off with a zero until there is a selected input to avoid errors

            for (int write = 0; write < arr.Length; write++)
            {
                //this will sort the given array
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "-");
            }
        }
        public static void SelectionSort(int[] arr) //Sorts array using selection sort
        {
            int numberOfSorts = 1;
            //int swapIntegers = 0;

            Console.WriteLine("> Here is the sorted array: ");
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
               /*
                if (min_idx != i)
                {
                    swapIntegers(arr, min_idx, 1);
                }
                */ 
                // Swap the found minimum element with the first element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
                numberOfSorts++;
                //swapIntegers++;
            }
            Console.WriteLine("Total Number of Swaps: " + numberOfSorts);
            Console.WriteLine();
            for (int i = 0; i < n; ++i) //prints the array in current method
            {
                Console.Write(arr[i] + "-");
            }               
            Console.WriteLine();
        }
        public void swapIntegers(int[] arr, int min_indx, int j )
        {
            int smallerNumber = arr[j];

            arr[j] = arr[min_indx];
            arr[min_indx] = smallerNumber;
        }
        // Driver code
        public static void Main()
        {
            int numberOfPreformedSorts = 0;
            int success = 0;
            int failure = 0;            

            do //loop for program to work
            {
                Console.WriteLine("--------------------------------------------------------------------------------"); //Seperate sorts
                Console.WriteLine("1. Bubble Sort"); //Let user input another array using Bubble sort
                Console.WriteLine("2. Selection Sort"); //Let user input another array using selection sort
                Console.WriteLine("3. Exit"); //Exit Program
                Console.WriteLine();

                if (Console.ReadKey().Key == ConsoleKey.NumPad1) //what happens when 1 is pressed
                {
                    Console.WriteLine(": Bubble Sort");
                    Console.WriteLine();
                    Console.WriteLine("Pick an array size between 1 and 1,000");

                    int Min = 1;
                    int Max = 1000;

                    int[] arr = new int[1000];

                    Random randNum = new Random();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = randNum.Next(Min, Max);
                    }
                    sizeTestArray(arr);
                    BubbleSort(arr);

                    if (arr == null) //checks if program ran correclty
                    {
                        failure++;
                        Console.WriteLine("Succsess: " + success);
                        Console.WriteLine("Failure: " + failure);
                    }
                    else 
                    {
                        success++;
                        Console.WriteLine();
                        Console.WriteLine("Succsess: " + success);
                        Console.WriteLine("Failure: " + failure);
                    }
                    numberOfPreformedSorts++;
                    Console.WriteLine("Number of Sorts Preformed: " + numberOfPreformedSorts);
                }
                else if (Console.ReadKey().Key == ConsoleKey.NumPad2) //what happens when 1 is pressed
                {
                    Console.WriteLine(": Selection Sort");
                    Console.WriteLine();
                    Console.WriteLine("Pick an array size between 1 and 1,000");

                    int Min = 1;
                    int Max = 1000;

                    int[] arr = new int[1000];

                    Random randNum = new Random();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = randNum.Next(Min, Max);
                    }
                    sizeTestArray(arr);
                    SelectionSort(arr);

                    if (arr == null) //checks if program ran correclty
                    {
                        failure++;
                        Console.WriteLine("Succsess: " + success);
                        Console.WriteLine("Failure: " + failure);
                    }
                    else
                    {
                        success++;
                        Console.WriteLine();
                        Console.WriteLine("Succsess: " + success);
                        Console.WriteLine("Failure: " + failure);
                    }
                    numberOfPreformedSorts++;
                    Console.WriteLine("Number of Sorts Preformed: " + numberOfPreformedSorts);
                }
                else if (Console.ReadKey().Key != ConsoleKey.NumPad3) //what happens when 2 is pressed
                {
                    Console.WriteLine("Exit"); //self documentation, user doesn't see
                }
            } while (numberOfPreformedSorts != 4); //program stops after the 4th sort 
        }
    }
}