using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any String");
            string str = Console.ReadLine(); 
            printCharWithFreq(str);
            Console.ReadKey();
        }
     
        static void printCharWithFreq(String str)
        {
            // size of the string 'str' 
            int n = str.Length;
          

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (str[i] == str[j])
                        count++;
                }
                if (!dict.ContainsKey(str[i]))

                    dict.Add(str[i], count);
            }
            for(int i=0;i<dict.Count;i++)
            {

                Console.WriteLine("{0}{1}",dict.Keys.ElementAt(i),dict[dict.Keys.ElementAt(i)]);
                
            }
         
        }
    }
}



