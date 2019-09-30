using System;

namespace Assignment4
{
    class Employee<T>
    {
        public string id;
        public string name;
        public string salary;
    }

    class Excecutor {
        static void Main(string[] args)
        {
            Employee<string> e = new Employee<string>();

            Employee<string>[] arr = new Employee<string>[5];

            try
            {
                e.id = "Emp1";
                e.name = "name1";
                e.salary = "salary1";

                arr[0] = e;

                for (int i=0;i<arr.Length;i++)
                {
                    Console.WriteLine(arr[i].id + " " + arr[i].name + " " + arr[i].salary);
                }

                arr[0] = null;

                Console.WriteLine(arr);
            }
            catch
            {
                Console.WriteLine("Exception caught");
            }

        }
    }
}