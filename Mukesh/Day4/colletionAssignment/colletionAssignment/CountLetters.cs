using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colletionAssignment
{
    class CountLetters
    {
        static void Main(string[] args)
        {
            int val = 1;
            string str = "this is .net training";
            char[] letterArray = str.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            //counting and storing the number of occurance of letters
            foreach (char word in letterArray)
            {
                if(!dict.ContainsKey(word))
                {
                    dict.Add(word, val);
                }
                else
                {
                    dict[word]++;
                }
            }
            
            //Displaying unsorted dictionary
            foreach(KeyValuePair<char,int> kv in dict)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            //to print max val
            Console.WriteLine("\nMax val is:{0}", dict.Values.Max());

            Console.ReadKey();
        }
    }
}
