using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,n,team,flag=0;
            int[] num = new int[30];
            Console.WriteLine("hom many element you want in array");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            for (i=0;i<n;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What you want ascending(1) or descending(0)");

            flag =int.Parse(Console.ReadLine());
            if(flag==1)//for ascending
            {
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n - 1; j++)
                    {
                        if (num[j] > num[j + 1])
                        {
                            team = num[j + 1];
                            num[j + 1] = num[j];
                            num[j] = team;
                        }
                    }
                }
                Console.WriteLine("Ascendings");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(num[i]);
                    Console.ReadKey();
                }
            }
            else//for descending
            {
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n - 1; j++)
                    {
                        if (num[j] < num[j + 1])
                        {
                            team = num[j + 1];
                            num[j + 1] = num[j];
                            num[j] = team;
                        }
                    }
                }
                Console.WriteLine("descending");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(num[i]);
                    Console.ReadKey();
                }

            }

        }
        
    }
}
