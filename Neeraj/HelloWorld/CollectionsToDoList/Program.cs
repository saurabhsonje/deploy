using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionsToDoList
{
    class Program
    {
        ////Declare an instance for log4net
        //private static readonly ILog Log =
        //      LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            List<ToDo> toDoList = new List<ToDo>();
            int choice = 0;
            ToDo toDo;
            String task;
            int priorty;

            try
            {
                do
                {
                    Console.WriteLine("1.Add 2.View all 3.Search by Priority 4.Update Priority 5.Exit");

                    //    choice = Convert.ToInt32(Console.ReadLine());
                    choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter task");
                            task = Console.ReadLine();
                            Console.WriteLine("Enter priority");
                            priorty = Int32.Parse(Console.ReadLine());
                            toDo = new ToDo(task, priorty);
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

                        case 3:
                            Console.WriteLine("Enter Priority");
                            priorty = Convert.ToInt32(Console.ReadLine());
                            foreach (ToDo item in toDoList)
                            {
                                if (item.priority == priorty)
                                {
                                    Console.WriteLine($"Task:{item.task}");
                                    // Console.WriteLine($"Priority:{item.priority}");
                                }
                                else
                                {
                                    Console.WriteLine("Item not found");
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

                        case 5:
                            Console.WriteLine("Existing....");
                            break;












                    }
                } while (choice != 5);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Incorrect format");
            }
            catch (ArgumentNullException ne)
            {
                Console.WriteLine("Null data found ");
            }

        //    ImplementLoggingFuntion();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

  /*      private static void ImplementLoggingFuntion()
        {
             //We have 5 levels of log message. Let's test all.
             //  FATAL
             //   ERROR
             //   WARN
             //   INFO
             //   DEBUG
                         var secs = 3;
            Log.Fatal("Start log FATAL...");
            Console.WriteLine("Start log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Error("Start log ERROR...");
            Console.WriteLine("Start log ERROR...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Warn("Start log WARN...");
            Console.WriteLine("Start log WARN...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Info("Start log INFO...");
            Console.WriteLine("Start log INFO...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Debug("Start log DEBUG...");
            Console.WriteLine("Start log DEBUG...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        } */
    }
}
