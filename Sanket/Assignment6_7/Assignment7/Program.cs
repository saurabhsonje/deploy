using System;
using System.Collections.Generic;
using System.Collections;

namespace Assignment7
{
    class Program
    {
        static void ProcessArraylist(ArrayList arrlist) 
        {
            Console.WriteLine("Adding some numbers:");
            arrlist.Add(40000391);
            arrlist.Add(40000595);
            arrlist.Add(40000890);
            arrlist.Add(40000340);
            arrlist.Add(400001029);
            

            Console.WriteLine("Capacity: {0} ", arrlist.Capacity);
            Console.WriteLine("Count: {0}", arrlist.Count);

            arrlist.RemoveAt(3);
            Console.Write("Arraylist Content after deleting 3rd index element: ");
            foreach (int i in arrlist)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
        static void ProcessSortedList(SortedList sl)
        {
            sl.Add(sl.Count + 1, "MS Dhoni");
            sl.Add(sl.Count + 1, "Virat Kohli");
            sl.Add(sl.Count + 1, "V Sehwag");
            sl.Add(sl.Count + 1, "Rishabh Pant");
            sl.Add(sl.Count + 1, "Lokesh Rahul");
            sl.Add(sl.Count + 1, "Rohit Sharma");
            sl.Add(sl.Count + 1, "B Kumar");

            if (sl.ContainsValue("Sachin Tendulkar"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add(sl.Count + 1, "Sachin Tendulkar");
            }

            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach (int k in key)
            {
                Console.WriteLine(k + " : " + sl[k]);
            }

        }
        static void ProcessStack() 
        {
            Stack st = new Stack();

            st.Push('a');
            st.Push('e');
            st.Push('i');
            st.Push('o');
            st.Push('u');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            Console.WriteLine("stack after popping: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        static void ProcessDictionary()
        {
            Dictionary<int,String> dict = new Dictionary<int,String>();

            dict.Add(dict.Count + 1, "Taj Mahal");
            dict.Add(dict.Count + 1, "Panhala Fort");
            dict.Add(dict.Count + 1, "Rajmachi");
            dict.Add(dict.Count + 1, "Big Ben");
            dict.Add(dict.Count + 1, "Sphinx");

            foreach (KeyValuePair<int, string> ele1 in dict)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }
            Console.WriteLine("Dictionary size: " + dict.Count);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine("do you want to view ArrayList elements? enter y/Y");
            if(String.Equals(Console.ReadLine(),"y",StringComparison.InvariantCultureIgnoreCase))
                ProcessArraylist(arr);
            
            Console.WriteLine();
            Console.WriteLine("do you want to view SortedList elements? enter y/Y");
            if (String.Equals(Console.ReadLine(), "y", StringComparison.InvariantCultureIgnoreCase))
            {
                SortedList sl = new SortedList();
                ProcessSortedList(sl);
            }
            
            Console.WriteLine("do you want to view Stack elements? enter y/Y");
            if (String.Equals(Console.ReadLine(), "y", StringComparison.InvariantCultureIgnoreCase))
                ProcessStack();

            Console.WriteLine("do you want to view Dictionary elements? enter y/Y");
            if (String.Equals(Console.ReadLine(), "y", StringComparison.InvariantCultureIgnoreCase))
                ProcessDictionary();
        }
    }
}
