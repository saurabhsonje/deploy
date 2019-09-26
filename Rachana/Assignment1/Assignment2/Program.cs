using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, key;

            Console.Write("Enter the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the element which we want to search");
            key = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (arr1[i] == key)
                {

                    Console.WriteLine("Element is found");
                    Environment.Exit(0);
                }

            }
            Console.WriteLine("Element is not found");

        }

    }
}

