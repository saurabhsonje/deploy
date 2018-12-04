using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> toDoList = new List<ToDo>();
            int choice = 0;
            ToDo toDo;
            String task;
            int priorty;
            do
            {
                Console.WriteLine("1.Add 2.View all 3.Search by Priority 4.Update Priority 5.Exit");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("Enter task");
                        task =Console.ReadLine();
                        Console.WriteLine("Enter priority");
                            priorty =Convert.ToInt32( Console.ReadLine()) ;
                            toDo = new ToDo(task,priorty);
                            toDoList.Add(toDo);
                            break;

                    case 2:
                            Console.WriteLine("All the tasks");
                        foreach (ToDo item in toDoList)
                        { 
                            Console.WriteLine($"Task:{item.task}");
                            Console.WriteLine($"Priority:{item.priority}");
                        }
                            break;

                    case 3: Console.WriteLine("Enter Priority");
                        priorty = Convert.ToInt32(Console.ReadLine());
                        foreach (ToDo item in toDoList)
                        {
                            if (item.priority == priorty)
                            {
                                Console.WriteLine($"Task:{item.task}");
                               // Console.WriteLine($"Priority:{item.priority}");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter task");
                        task = Console.ReadLine();
                        foreach (ToDo item in toDoList)
                        {
                            if ((item.task).Equals(task))
                            {
                                Console.WriteLine("Found");
                                Console.WriteLine($"Task:{item.priority}");
                                Console.WriteLine($"Task:{item.task}");

                                Console.WriteLine("Enter your new priority");
                                int newPriorty = Convert.ToInt32(Console.ReadLine());
                                item.priority = newPriorty;
                                // Console.WriteLine($"Priority:{item.priority}");
                            }
                           
                        }
                        break;

                    case 5:Console.WriteLine("Existing....");
                        break;












                }
            } while (choice != 5);
            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
