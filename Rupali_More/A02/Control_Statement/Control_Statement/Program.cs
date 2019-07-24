using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = new string[7] { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };
            int i, j;
            //Used of for loop , if condition and continue 
            for (i = 0; i < 7; i++)
            {
                if (day[i] == "sun")
                {
                    Console.WriteLine("hurrry holiday :)");
                   
                }
                else
                {
                    continue;
                }
            }

            //used of switch case and break
            string casecatch = "mon";
            switch (casecatch)
            {
                case "sun":
                    Console.WriteLine("found at case 1");
                    Console.ReadLine();
                    break;

                case "mon":
                    Console.WriteLine("found at case 2");
                    Console.ReadLine();
                    break;
                case "tue":
                    Console.WriteLine("found at case 3");
                    Console.ReadLine();
                    break;
                case "wed":
                    Console.WriteLine("found at case 4");
                    Console.ReadLine();
                    break;
                case "thu":
                    Console.WriteLine("found at case 5");
                    Console.ReadLine();
                    break;
                case "fri":
                    Console.WriteLine("found at case 6");
                    Console.ReadLine();
                    break;
                case "sat":
                    Console.WriteLine("found at case 7");
                    Console.ReadLine();
                    break;
            }

            //use of while loop
            int k = 0;
            while (day[k] == "sat")                
            {
                k++;
            }
            Console.WriteLine("match the condition");

            //use of do while
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (day[i] == "sat");
            Console.WriteLine("found !!!!!!!!!!!!!");

            //use of ternary operator
           var resulte= day[0]=="sun"? "match found" : "match not found";
            Console.WriteLine(resulte);
            Console.ReadLine();
        }
    }
}
