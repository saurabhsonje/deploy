using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment7
{
    class CollectionOperations
    {

        public void arrayList()
        {

            ArrayList al = new ArrayList();
            al.Add(40001818);
            al.Add(40001814);
            al.Add(40001815);
            al.Add(40001813);
            al.Add(40001820);
            al.Add(40001811);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Capacity of ArrayList:{0}", al.Capacity);
            Console.WriteLine("Count of ArrayList:{0}", al.Count);

            al.RemoveAt(4);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Capacity of ArrayList:{0}", al.Capacity);
            Console.WriteLine("Count of ArrayList:{0}", al.Count);

        }

        public void sortedList()
        {
            SortedList sl = new SortedList();
            sl.Add(1, "Virat Kohali");
            sl.Add(2, "Rohit Sharma");
            sl.Add(3, "MS Dhoni");
            sl.Add(4, "Ajinkya Rahane");
            sl.Add(5, "Suresh Raina");
            foreach (DictionaryEntry pair in sl)
            {
                Console.WriteLine("{0} {1}",
                          pair.Key, pair.Value);
            }

            if (sl.ContainsValue("Sachin Tendulkar"))
            {

                Console.WriteLine("Yes Sachin is present in arraylist");
            }
            else {

                sl.Add(8, "Sachin Tendulkar");

            }
            Console.WriteLine("\n");
            foreach (DictionaryEntry pair in sl)
            {
               
                Console.WriteLine("{0} {1}",
                          pair.Key, pair.Value);
            }


        }

        public void stackoprations()
        {
            Stack s = new Stack();
            Console.WriteLine("After pushing the elements");
            s.Push('a');
            s.Push('e');
            s.Push('i');
            s.Push('o');
            s.Push('u');

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            s.Pop();
            s.Pop();

            Console.WriteLine("After pop two element");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

        }

        public void dictOperations()
        {
            IDictionary<int, int> d = new Dictionary<int, int>();
              d.Add(1,97);
              d.Add(2,89);
              d.Add(3,77);
              d.Add(4,88);
            Console.WriteLine("Count :{0}", d.Count);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            CollectionOperations co = new CollectionOperations();
            Console.WriteLine("**********ArrayList*********");
            co.arrayList();
            Console.WriteLine("**********SortedList*********");
            co.sortedList();
            Console.WriteLine("**********Stack*********");
            co.stackoprations();
            Console.WriteLine("**********Dictionary*********");
            co.dictOperations();
        }
    }
}
