using System;

namespace Assignment01
{
    class Sort_SearchNum
    {
        static void AscSort(int[] arr) {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void DscSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void AscSortUsingCompareTo(int[] arr) {
            //Ascending Order
            Array.Sort<int>(arr, new Comparison<int>(
                (int a, int b) => a.CompareTo(b)
                )) ;
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void Find(int[] arr, int elem)
        {
            int pos = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == elem)
                {
                    pos = i;
                    break;
                }
            }
            if (pos >= 0)
                Console.WriteLine("element found at index: " + pos);
            else
                Console.WriteLine("element is not found ");
        }
        static void Main(string[] args)
        {
            int[] arrnum = new int[]{5,2,1,3,5,6};

            //Array.Sort(arrnum);
            //Array.Reverse(arrnum);

            //AscSortUsingCompareTo(arrnum);
            Console.WriteLine("Array Elements :");
            foreach (int item in arrnum)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nAscending Sort :");
            AscSort(arrnum);
            foreach (int item in arrnum)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nDescending Sort :");
            DscSort(arrnum);
            foreach (int item in arrnum)
            {
                Console.Write(item + " ");
            }

            int[] arr = new int[] { 1, 3, 4, 5, 6, 11, 12, 33 };
            Console.WriteLine();
            Console.WriteLine("\nArray elements :");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            
            
            Console.WriteLine("\nEnter element to search from above array : ");
            
            Find(arr, Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
