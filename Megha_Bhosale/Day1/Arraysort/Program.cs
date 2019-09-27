using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;

            Console.WriteLine("Enter the number of value you want to store:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] myval = new int[num];

            //accepting user input
            Console.WriteLine("Enter the {0} integer value:", num);
            for (int x = 0; x < num; x++)
            {
                myval[x] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter 0 to sort in ascending and 1 to sort in descending:");
            int flag = Convert.ToInt32(Console.ReadLine());

            //sorting array
            if(flag == 0)
            {

                for(int i=0; i < myval.Length-1; i++)
                {
                    for(int j=i+1; j< myval.Length; j++)
                    {
                        if(myval[i] > myval[j])
                        {
                            temp = myval[i];
                            myval[i] = myval[j];
                            myval[j] = temp;
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < myval.Length - 1; i++)
                {
                    for (int j = i + 1; j < myval.Length; j++)
                    {
                        if (myval[i] < myval[j])
                        {
                            temp = myval[i];
                            myval[i] = myval[j];
                            myval[j] = temp;
                        }
                    }

                }
            }

            //displaying final array
            Console.WriteLine("Final array after sort is:");
            for (int y = 0; y < myval.Length; y++)
            {
                Console.WriteLine(myval[y]);
            }


            Console.ReadKey();

        }
    }
}
