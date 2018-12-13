using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
   
    class Program
    {
        public static int choice;
        public static string work , work1 , search , update;
        public static int answer, answer1;

        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Learn C#");
            names.Add("Perform Coding");
            names.Add("Upload on Github");

            Console.WriteLine("Welcome to To-Do List");
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
                        do
                        {
                            Console.WriteLine("Add your work");
                            string work = Console.ReadLine();
                            names.Add(work);
                            Console.WriteLine("Do you want to continue");
                            answer = int.Parse(Console.ReadLine());
                        }
                        while (answer == 1);
                        break;

                    case 2:
                        Console.WriteLine("Displaying your list");
                        foreach (string name in names)
                        {
                            Console.WriteLine(name);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Deleting a entry");
                        Console.WriteLine("Enter your entry to delete");
                        string work1 = Console.ReadLine();
                        names.Remove(work1);
                        Console.WriteLine("Displaying your list");
                        foreach (string name in names)
                        {
                            Console.WriteLine(name);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Searching an entry");
                        Console.WriteLine("Enter the entry to search");
                        string search = Console.ReadLine();
                        if (names.Contains(search))
                        {
                            Console.WriteLine("Entry found");
                        }
                        else
                        {
                            Console.WriteLine("Entry not found");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Updating entry");
                        Console.WriteLine("Enter the entry to update");
                        string update = Console.ReadLine();
                        int index = names.IndexOf(update);
                        if (index >= 0)
                        {
                            names[index] = "Poetry";
                        }
                        Console.WriteLine("Displaying your list");
                        foreach (string name in names)
                        {
                            Console.WriteLine(name);
                        }
                        break;

                }

                Console.WriteLine("Do you want to continue");
                answer1 = int.Parse(Console.ReadLine());
            }
            while (answer1 == 1);
            Console.WriteLine("Thank you");
            Console.ReadLine();

         
        }
    }
}


