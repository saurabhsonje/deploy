using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_StringBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
             Int16 i = 0;

            //Finding Number of Characters in the String

            Console.WriteLine("Enter the String Whose Length To Be Calculated");
            string EnteredString = Console.ReadLine();

            foreach (char a in EnteredString)
            {

                if (a == ' ')
                    continue;  // Use of Continue
                i++;
            }
            Console.WriteLine("Number of Character in string is :=" + i);



            //Using StringBuilder

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hi ");         //Append
            stringBuilder.AppendLine();         //AppendLine
            stringBuilder.AppendLine("all");    //AppendLine with parameter
            stringBuilder.AppendFormat("Good {0}", "Morning");


            Console.WriteLine(stringBuilder.ToString());

            Console.WriteLine("After Replacing all with ALL------------------->");
            stringBuilder.Replace("all", "ALL");     //Replace
            Console.WriteLine(stringBuilder.ToString());


            stringBuilder.Replace("Good", "Bad", 5, 3);
            Console.WriteLine("After Replacing Good with Bad" + " " + stringBuilder.ToString());


            Console.WriteLine("After Inserting k at Position 0------------------->");
            stringBuilder.Insert(0, 'k');                //Insert
            Console.WriteLine(stringBuilder.ToString());


            stringBuilder.Clear();                          //Clear
            Console.WriteLine("Printing StringBuilder After Clearing" + stringBuilder.ToString());
            Console.WriteLine("Maximum Capacity of StringBuilder" + " " + stringBuilder.MaxCapacity);
            Console.WriteLine("Capacity of StringBuilder" + " " + stringBuilder.Capacity);


            string stringValue = "helloworld";

            StringBuilder sb = new StringBuilder(stringValue);
            sb.Replace("wo", "hq", 5, 2);                       //Replace
            Console.WriteLine("After replacing the wo with hq" + " " + sb.ToString());

            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                'a', 'r', 'r', 'a', 'y' };


            Console.WriteLine(destination);
            strSource.CopyTo(0, destination, 4, strSource.Length); // CopyTo


            Console.WriteLine(destination);
            strSource = "A different string";


            strSource.CopyTo(2, destination, 3, 9);
            Console.WriteLine(destination);

            Console.ReadLine();

        }
    }
}
