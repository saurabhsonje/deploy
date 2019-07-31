using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07_Entity
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentDBContext data = new StudentDBContext();


            //var list = ctx.Database.SqlQuery<Teacher>("GetTeacherInfo").ToList();
            ////int result = ctx.Database.ExecuteSqlCommand("Teacher_Insert @TeacherName, @ModeOfTeaching", tname, mode);
            //GetTeacherInfo and  Teacher_Insert are SP names

            // data.Database.SqlQuery<Student>("")

            Student student = new Student() { Name = "Raj", Department_Id = 2 };
            data.Students.Add(student);
            data.SaveChanges();

            Console.WriteLine("-------------");

            var a = data.Students.Join
                         (data.Departments,
                         s => s.Department_Id,
                         d => d.Department_Id,
                        (s, d) => new { d.Department_Name, s.Department_Id, s.Name }).ToList();

  
            foreach (var e in a)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("-------------");
          
            var query = (from stu in data.Students
                         join dept in data.Departments on
                            stu.Department_Id equals dept.Department_Id
                         select new { stu.Department_Id, stu.Name, dept.Department_Name}).ToList();


            foreach(var s in query)
            {
                Console.WriteLine(s);
            }
         Console.ReadLine();
        }
    }
}
