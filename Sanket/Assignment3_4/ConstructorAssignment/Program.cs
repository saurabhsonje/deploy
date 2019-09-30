using System;

namespace ConstructorAssignment
{
    public class Counter
    {
        static int count = 0;
        private Counter()
        { }
        public static int Increment()
        {
            return ++count;
        }
        public static void Print() {
            Console.WriteLine("Count: " + count);
        }
    }

    public class Worker
    {
        String name;
        int age;
        static readonly String department;

        //copy constructor
        public Worker(Worker worker) {
            this.age = worker.age;
            this.name = worker.name;
        }
        //parameterized constructor
        public Worker(String name, int age) {
            this.name = name;
            this.age = age;
        }
        //static constructor
        static Worker() {
            department = "WorkShop";
        }
        
        static void Main(string[] args)
        {
            Worker e1 = new Worker("Ajay", 21);
            Console.WriteLine("department: " + department);

            //department = "Welding workshop";
            Worker e2 = new Worker("Sujay", 24);
            Console.WriteLine("department: " + department);

            Worker e3 = new Worker(e2);
            Console.WriteLine(e3.name + " " + e3.age);

            //uncommenting following statement will generate
            // an error because the constructor is inaccessible due its protection level
            //Counter c = new Counter();
            
            Counter.Increment();
            Counter.Print();

            Console.ReadLine();
        }
    }
}
