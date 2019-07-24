using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Int16 choice = 0;
                do
                {
                    Console.WriteLine("Enter 0 for Exit");
                    Console.WriteLine("Enter 1 for Ascending Order");
                    Console.WriteLine("Enter 2 for Dscending Order");

                    choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            SortingInAscendingOrder();
                            break;

                        case 2:
                            SortingInDsendingOrder();
                            break;

                        default:
                            Console.WriteLine("Exit");
                            System.Environment.Exit(0);
                            break;
                    }
                } while (choice != 0);

            }
        }


        private static void SortingInDsendingOrder()
        {
            int[] ArrayToSort;
            ArrayToSort = InitializeArray();
            for (var i = 0; i < ArrayToSort.Length; i++)
            {
                for (var j = i + 1; j < ArrayToSort.Length; j++)
                {
                    if (ArrayToSort[i] < ArrayToSort[j])
                    {
                        int temp = ArrayToSort[i];
                        ArrayToSort[i] = ArrayToSort[j];
                        ArrayToSort[j] = temp;
                    }
                }

            }
            PrintSortedArray(ArrayToSort);
        }

        private static int[] InitializeArray()
        {
            Console.WriteLine("Enter the size of the Array");
            Int16 n = Convert.ToInt16(Console.ReadLine());
            int[] ArrayEnterd = new int[n];
            Console.WriteLine("Enter the element in  the Array ---------->");
            for (var j = 0; j < ArrayEnterd.Length; j++)
                ArrayEnterd[j] = Convert.ToInt16(Console.ReadLine());
            return ArrayEnterd;
        }




        private static void SortingInAscendingOrder()
        {
            int[] ArrayToSort;
            ArrayToSort = InitializeArray();
            for (var i = 0; i < ArrayToSort.Length; i++)
            {
                for (var j = i + 1; j < ArrayToSort.Length; j++)
                {
                    if (ArrayToSort[i] > ArrayToSort[j])
                    {
                        int temp = ArrayToSort[i];
                        ArrayToSort[i] = ArrayToSort[j];
                        ArrayToSort[j] = temp;
                    }
                }
            }
            PrintSortedArray(ArrayToSort);
        }



        private static void PrintSortedArray(int[] ArrayToPrint)
        {
            Console.WriteLine("Sorted Array is --->");
            foreach (var a in ArrayToPrint)
            {
             Console.WriteLine(a);
            }

        }

    }
}