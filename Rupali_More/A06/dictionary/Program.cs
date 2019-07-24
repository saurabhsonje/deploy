using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> singchar = new Dictionary<char, int>();
            string str = "Java programing";
           str= str.Trim();
            char[] arr = str.ToCharArray();
            foreach(char i in arr)
            {
                int k = 0;
                foreach (char j in arr)
                {
                    if(i==j)
                    {
                        k++;
                    }
                }
                try
                {
                    singchar.Add(i, k);
                }
                catch
                {
                    continue;
                }
                
            }
            foreach (KeyValuePair<char, int> author in singchar)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                author.Key, author.Value);
                Console.ReadLine();

            }


        }
    }
}
