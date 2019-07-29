using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_04_Count_Letters
{
    class Program
    {
        public const string ENTER_STRING = "ENTER THE STRING ";
        public const string INVALID_STRING = "EMPTY STRING IS NOT ACCEPTED --";
        public const string INVALID_CHARACTERS = "ENTER VALID CHARACTERS  ";
        public const string SORTED_STRING = "ENTERED STRING IN SORTED FORM-------------->";


        static void Main(string[] args)
        {
            
            Console.WriteLine(ENTER_STRING);
            var enteredString = Console.ReadLine();
            while (string.IsNullOrEmpty(enteredString))
            {
                Console.WriteLine(INVALID_STRING);
                enteredString = Console.ReadLine();
            }
            while (!Regex.IsMatch(enteredString, "[a-zA-Z]"))
            {
                Console.WriteLine(INVALID_CHARACTERS);
                enteredString = Console.ReadLine();    
            }
            enteredString   = enteredString.Trim().ToLower();
            Initialization(ref enteredString);                  //Using ref To PASS THE STRING
        }


        public static void Initialization(ref string EnteredString)
        {

            Dictionary<char, int> RepeatedCharacter = new Dictionary<char, int>();
            for (int i = 0; i < EnteredString.Length; i++)
            {
                if (RepeatedCharacter.ContainsKey(EnteredString[i]))
                {
                    int count = RepeatedCharacter[EnteredString[i]];
                    RepeatedCharacter[EnteredString[i]] = count + 1;
                }
                else {
                 RepeatedCharacter.Add(EnteredString[i] , 1);
                 }
            }

           var  val = from Values in RepeatedCharacter
                      orderby Values.Value ascending
                      select Values;

            PrintSortedString( val);
            Console.ReadLine();
        }


        public static void PrintSortedString(dynamic val)
        {
            Console.WriteLine(SORTED_STRING);
            foreach (KeyValuePair<char, int> kvp in val)
            {
                Console.WriteLine(kvp.Key + " Counts are " + kvp.Value);
            }

        }



    }
}
