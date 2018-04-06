using System;

namespace TestSort
{
    internal class ArraySize
    {
        private static void PickArray(int[] array) //User input for the array size
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
        }
    }
}