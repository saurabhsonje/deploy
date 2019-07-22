using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number Of Elements :");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] a = new int[size];
                int flag = 0;

                Console.WriteLine("Enter The Elements :");
                for (int i = 0; i < size; i++)
                {
                    a[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Enter (0/1) for (Descending/Ascending)");
                flag = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Elements are");
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                    {

                        if (flag != 0)
                        {
                            if (a[j] > a[j + 1])
                            {
                                int temp = a[j];
                                a[j] = a[j + 1];
                                a[j + 1] = temp;
                            }

                        }
                        else
                        {
                            if (a[j] < a[j + 1])
                            {
                                int temp = a[j + 1];
                                a[j + 1] = a[j];
                                a[j] = temp;
                            }
                        }


                    }

                }

                foreach (int b in a)
                {
                    Console.WriteLine(b);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
            Console.ReadLine();
        }
    }
}
