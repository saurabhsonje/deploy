using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilderOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dest = new char[10];
            StringBuilder sb = new StringBuilder("This is training stuff");
            sb.Replace("stuff", "Material");
            Console.WriteLine("String after replacement:\n {0} \n", sb);

            sb.Remove(5, 3);
            Console.WriteLine("String after Removal of certain part:\n {0} \n", sb);

            sb.CopyTo(5,dest,0,9);
            Console.Write("String after CopyTo operation:\n");
            Console.WriteLine(dest);

            sb.Append(" from Globant");
            Console.WriteLine("String after Appending of certain part:\n {0} \n", sb);

            sb.Insert(5,"is ");
            Console.WriteLine("String after Appending of certain part:\n {0} \n", sb);

            Console.ReadKey();
        }
    }
}
