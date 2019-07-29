using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07
{
    
    public class ArrayList_operation
    {
       public  ArrayList a1 = new ArrayList();
        //insert data into array list
        public void ArrayList_Add(Customer_info c)
        {
            a1.Add(new Customer_info (c.name,c.number,c.address));
            a1.Add(new Customer_info("rupali",12,"sanjivan"));
            display(a1);
        }
        //remove data from array list
        public void Delete()
        {
            Console.WriteLine("which element you want todelete");
            var val = Console.ReadLine();
            for (int i = 0; i < a1.Count; i++)
            {
                a1.Remove(val);
            }
            try
            { 
            a1.RemoveAt(1);
             }
            catch
            {
                Console.WriteLine("exception occure");
            }
            Console.WriteLine("your arrayList is:");
             display(a1);
        }
        //Accessing  arrayList of element 
        public void display(ArrayList a1)
        {
            foreach(var i in a1)
            {
                Console.WriteLine(i);
            }
        }

        //search operation on ArrayList
        public void search()
        {
            Console.WriteLine("which element you want to Search");
            var val = Console.ReadLine();
            if (a1.Contains(val))
            {
                Console.WriteLine("element found");
            }
        }
        
        //reverse arraylist element
        public void Reverse()
        {
            ArrayList a2 = new ArrayList();
            a1.Reverse();
            a2 = a1;
            Console.WriteLine("revers of arraylist is here:)");
            display(a2);
        }
        public void update()
        {
            Console.WriteLine("which element you want to update");
            var val = Console.ReadLine();
            Console.WriteLine("what value you want to put there");
            var val1 = Console.ReadLine();
                if (a1.Contains(val))
                {
                    a1.Remove(val);
                }
            a1.Insert(1,val1);
            foreach (var i in a1)
            {
                Console.WriteLine(i);
            }

        }
        
    }
}
