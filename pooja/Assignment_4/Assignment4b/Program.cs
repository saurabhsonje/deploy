using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment4b
{
    class Program
    {
        static void Main(string[] args)
        {

            //*********Using ArrayList
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("abcd");
            arrayList.Add(true);

            arrayList.RemoveAt(2);// del element of index 2
            arrayList.Remove(1);// del element which is 1

            ArrayList arrayList2 = new ArrayList();

            arrayList2.Add("pooja");
            arrayList2.Add(3);
            arrayList.AddRange(arrayList2);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }


            //*******Using List<T>
            
            List<Student> students = new List<Student>();
            students.Add(new Student(2, "Pooja", "Pune"));
            students.Add(new Student(1, "Raks", "Pune"));
            students.Add(new Student(3, "Raji", "Pune"));
            students.Add(new Student(4, "Pachu", "Pune"));
            
            Display(students);
            students.Reverse();
            Display(students);
            students.RemoveAt(2);
            //students.OrderBy(s => s.Id);
            Display(students);
            students = students.OrderByDescending(s=> s.Name).ToList();
            Display(students);

            students = students.OrderBy(s => s.Id).ToList();
            Display(students);

            Console.ReadLine();
        }

        public static void Display(List<Student> students)
        {
            Console.WriteLine("---------------------------------\n" +
                       "Id" + "\tName" + "\t Location\n" +
                       "" + "---------------------------------");
            foreach (Student student in students)
            {
                Console.WriteLine("{0}\t{1}\t{2}", student.Id, student.Name, student.Location);
            }
        }
           
    }
}
