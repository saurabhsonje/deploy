using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ToDo
{
    class Test_ToDo
    {
        static void Main(string[] args)
        {
            List<ToDo> toDoList = new List<ToDo>();
            ToDo toDo;
            int priority;
            string task , task1;
            int choice , ans , ans1 , newpriority;

            Console.WriteLine("Welcome to ToDo List");
            do
            {
                Console.WriteLine("The options are");
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. Display the list");
                Console.WriteLine("3. Remove from list");
                Console.WriteLine("4. Search an Entry");
                Console.WriteLine("5. Replace an Entry");
                Console.WriteLine("Enter you choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Adding your task");
                        Console.WriteLine("Enter your task");
                        task = Console.ReadLine();
                        Console.WriteLine("Enter your priority");
                        priority = int.Parse(Console.ReadLine());
                        toDo = new ToDo(task, priority);
                        toDoList.Add(toDo);
                        break;

                    case 2:
                        Console.WriteLine("Displaying your list");
                        foreach (ToDo item in toDoList)
                        {
                            Console.WriteLine($"Task:{item.Task}");
                            Console.WriteLine($"Priority:{item.Priority}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Removing an entry");
                        Console.WriteLine("Enter your task");
                        task = Console.ReadLine();
                        Console.WriteLine("Enter your priority");
                        priority = int.Parse(Console.ReadLine());
                        toDo = new ToDo(task, priority);
                        toDoList.Remove(toDo);
                        break;

                    case 4:
                        Console.WriteLine("Search an Entry");
                        Console.WriteLine("Enter priority");
                        priority = int.Parse(Console.ReadLine());
                        foreach (ToDo item in toDoList)
                        {
                            if (item.Priority.Equals(priority))
                            {
                                Console.WriteLine("Found the entry");
                                Console.WriteLine($"Task:{item.Task}");
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Updating an Entry");
                        Console.WriteLine("Enter task");
                        task = Console.ReadLine();
                        foreach (ToDo item in toDoList)
                        {
                            if ((item.Task).Equals(task))
                            {
                                Console.WriteLine("Found");
                                Console.WriteLine($"Task:{item.Priority}");
                                Console.WriteLine($"Task:{item.Task}");

                                Console.WriteLine("enter new priority");
                                newpriority = int.Parse(Console.ReadLine());
                                item.Priority = newpriority;
                            }
                        }
                        break;
                }
                Console.WriteLine("Do you want to continue");
                ans = int.Parse(Console.ReadLine());
            }
            while (ans == 1);
            Console.WriteLine("Thank you");
            Console.ReadLine();
        }
    }
}
