using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Dictionary<int, Todo> keyValuePairs = new Dictionary<int, Todo>();

            
            
    
            int ch;
       
            char choice;
           
           
            int count = 1;
            do
            {
                Console.WriteLine("1.Create");
                Console.WriteLine("2.Get Information");
                Console.WriteLine("3.Remove a Particular Activity ");
                Console.WriteLine("4.Search a Particular Activity");
                Console.WriteLine("5.Update a Particular Activity");
                Console.WriteLine("Enter Your Choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:

                     
                        do
                        {
                            Console.WriteLine("Enter Your Todays Activities");
                            string activitie = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter Your Todays Priority Activities");
                            int priority = Convert.ToInt32(Console.ReadLine());
                            keyValuePairs.Add(count, new Todo(activitie,priority));
                            count++;
                            Console.WriteLine("Do You Want To Continue");
                            choice = Convert.ToChar(Console.ReadLine());
                        } while (choice.Equals('Y') || choice.Equals('y'));
                        
                       
                        
                        break;
                    case 2:
                        for (int i = 0; i < keyValuePairs.Count; i++)
                        {

                            var item = keyValuePairs.ElementAt(i);
                            var itemKey = item.Key;
                            Todo itemValues = item.Value;
                            Console.WriteLine($"Key {itemKey}");
                            Console.WriteLine($"Task Name {itemValues.name}");
                            Console.WriteLine($"Task Priority{itemValues.priority}");

                        }
                        break;
                    case 3:
                        for (int i = 0; i < keyValuePairs.Count; i++)
                        {

                            var item = keyValuePairs.ElementAt(i);
                            var itemKey = item.Key;
                            Todo itemValues = item.Value;
                            Console.WriteLine($"Key {itemKey}");
                            Console.WriteLine($"Task Name {itemValues.name}");
                            Console.WriteLine($"Task Priority { itemValues.priority}");

                        }
                        Console.WriteLine("Enter activity to be remove from list");
                        int key = Convert.ToInt16(Console.ReadLine());
                        keyValuePairs.Remove(key);

                        break;
                    case 4:
                        Console.WriteLine("Enter key to be search from list");
                        int keys = Convert.ToInt16(Console.ReadLine());
                        if(keyValuePairs.ContainsKey(keys))
                        {
                            Console.WriteLine(keys);
                            Todo todo=keyValuePairs[keys];
                            Console.WriteLine($"Task Name {todo.name}");
                            Console.WriteLine($"Task Priority {todo.priority}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter key to be updated from list");
                        int keya = Convert.ToInt16(Console.ReadLine());
                        if (keyValuePairs.ContainsKey(keya))
                        {
                            Console.WriteLine(keya);
                            Todo todo = keyValuePairs[keya];
                            Console.WriteLine($"Task Name{todo.name}");
                            Console.WriteLine($"Task Priority{todo.priority}");
                            Console.WriteLine("Enter Priority to Be updated");
                            int priority = Convert.ToInt16(Console.ReadLine());
                            
                            todo.priority = priority;
                          
                        }
                        break;
                }
                Console.WriteLine("Do You Want To Continue");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice.Equals('Y') || choice.Equals('y'));
        }

    }
}
