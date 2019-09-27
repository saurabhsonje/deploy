using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 7, 3, 4, 6 };
            int num;

            // Ascending
            Array.Sort(arr);

            // Descending
            Array.Reverse(arr);

            Console.WriteLine("Sorted array in descending order - ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("What number you want to search ?");
            num = Console.Read();

            foreach (int element in arr)
            {
                if (element == num)
                {
                    Console.WriteLine("Found");
                }
            }

        }
    }
}