using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Linq
    {
        public static void Main(String[] args)
        {
            int choice;
            IList<string> stringList = new List<string>
            {
                "C# Tutorials" , "VB.NET Tutorials" , "Learn C++" , "MVC Tutorials" , "Java"
            };

            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1 , StudentName = "Ajit" , Age = 30},
                new Student() { StudentID = 2 , StudentName = "Karan" , Age = 25},
                new Student() { StudentID = 3 , StudentName = "Shilpa" , Age = 23},
                new Student() { StudentID = 4 , StudentName = "Rohan" , Age = 35},
                new Student() { StudentID = 5 , StudentName = "Kashish" , Age = 20}
            };

            Console.WriteLine("Welcome to LINQ system");
            Console.WriteLine("The options are");
            Console.WriteLine("1.Get detail using Query Syntax");
            Console.WriteLine("2.Get detail using Method Synatx");
            Console.WriteLine("3.Get age using Query Syntax");
            Console.WriteLine("4.Get age using Method Syntax");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var result = from s in stringList where s.Contains("Tutorials") select s;
                    foreach (var str in result)
                    {
                        Console.WriteLine(str);
                    }
                    break;

                case 2:
                    var result1 = stringList.Where(s => s.Contains("Tutorials"));
                    foreach (var str in result1)
                    {
                        Console.WriteLine(str);
                    }
                    break;

                case 3:
                    var teenAge = from s in studentList where s.Age > 12 && s.Age < 20 select s;
                    foreach (var str in teenAge)
                    {
                        Console.WriteLine(str);
                    }
                    break;

                case 4:
                    var teenAge1 = studentList.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
                    foreach (var str in teenAge1)
                    {
                        Console.WriteLine(str);
                    }
                    break;                  
            }
            Console.ReadLine();
        }
    }
}
