using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1c
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder Builder = new StringBuilder();
            Builder.Append("Good Evening");
            Builder.AppendFormat("\n Pune");
            Console.WriteLine(Builder);
            Builder.Clear();
            Console.WriteLine(Builder);


            //The range of a 16-bit unsigned integer: 0 to 65535
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("The range of a 16-bit unsigned integer: ");
            sb.Append(UInt16.MinValue).Append(" to ").Append(UInt16.MaxValue);
            Console.WriteLine(sb);


            //The range of a 32-bit unsigned integer: 0 to 4294967295
            StringBuilder sb1 = new StringBuilder();
            Console.WriteLine("The range of a 32-bit unsigned integer: ");
            sb1.Append(UInt32.MinValue).Append(" to ").Append(UInt32.MaxValue);
            Console.WriteLine(sb1);


            //The range of a 64-bit unsigned integer: 0 to 18446744073709551615
            StringBuilder sb2 = new StringBuilder();
            Console.WriteLine("The range of a 64-bit unsigned integer: ");
            sb2.Append(UInt64.MinValue).Append(" to ").Append(UInt64.MaxValue);
            Console.WriteLine(sb2);


            //The array from positions 0 to 2 contains abcde
            char[] chars = { 'a', 'b', 'c', 'd', 'e' };
            StringBuilder sb3 = new StringBuilder();
            int startPosition = Array.IndexOf(chars, 'a');
            int endPosition = Array.IndexOf(chars, 'e');
            if (startPosition >= 0 && endPosition >= 0)
            {
                sb3.Append("The array from positions ").Append(startPosition).
                          Append(" to ").Append(endPosition).Append(" contains ").
                          Append(chars, startPosition, endPosition + 1);

                Console.WriteLine(sb3);
            }



            //The value of the flag is False.
            bool flag = false;
            StringBuilder sb4 = new StringBuilder();
            sb4.Append("The value of the flag is ").Append(flag);
            Console.WriteLine(sb4.ToString());


            //    First President of the United States: George Washington, from 1789 to 1797
            StringBuilder sb5 = new StringBuilder();
            string str = "First;George Washington;1789;1797";
            int index = 0;

            int length = str.IndexOf(';', index);
            sb5.Append(str, index, length).Append(" President of the United States: ");
            index += length + 1;

            length = str.IndexOf(';', index) - index;
            sb5.Append(str, index, length).Append(", from ");
            index += length + 1;


            length = str.IndexOf(';', index) - index;
            sb5.Append(str, index, length).Append(" to ");
            index += length + 1;

            sb5.Append(str, index, str.Length - index);
            Console.WriteLine(sb5);
        
            


            //*****$1,346.19*****
            decimal value = 1346.19m;
            StringBuilder sb6 = new StringBuilder();
            sb6.Append('*', 5).AppendFormat("{0:C2}", value).Append('*', 5);
            Console.WriteLine(sb6);


            //The range of an 8-bit unsigned integer: -128 to 127
            StringBuilder sb7 = new StringBuilder("The range of an 8-bit signed integer: ");
            sb7.Append(SByte.MinValue).Append(" to ").Append(SByte.MaxValue);
            Console.WriteLine(sb7);


            //       *****1034769.47*****
            float value1 = 1034769.47f;
            StringBuilder sb8 = new StringBuilder();
            sb8.Append('*', 5).Append(value1).Append('*', 5);
            Console.WriteLine(sb8);





            // The example displays the following output:
            //       The initial array
            //       The changed array
            //       The different array

            // Embed an array of characters in a string
            string strSource = "changed";

            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
            'a', 'r', 'r', 'a', 'y' };

            // Print the char array
            Console.WriteLine(destination);

            // Embed the source string in the destination string
            strSource.CopyTo(0, destination, 4, strSource.Length);

            // Print the resulting array
            Console.WriteLine(destination);

            strSource = "A different string";

            // Embed only a section of the source string in the destination
            strSource.CopyTo(2, destination, 3, 9);

            // Print the resulting array
            Console.WriteLine(destination);
      
      



            Console.ReadLine();
        }
    }
}
