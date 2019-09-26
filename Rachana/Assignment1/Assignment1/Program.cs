using System;

namespace Assignment1
{
    public class Program
    {
        public static void Main()
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;

            Console.Write("Enter the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nAscending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] > arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nDecending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr1[i]);
            }

        }
    }
}