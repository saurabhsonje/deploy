using System;

namespace GenericAPP
{
    public class Employee<T,W>
    {
        private T empName;
        private W empSalary;

        public Employee(T name, W salary)
        {
            this.empName = name;
            this.empSalary = salary;
        }
        Employee()
        {
            
        }
        
        public void addEmployee()
        {
           
        }
        public void removeEmployee()
        {
            
        }
        public void display()
        {
            Console.WriteLine("Name : {0}, Salary : {1}", empName, empSalary);
        }
       
    }
    class ProgramCall
    { 

        static void Main()

        {

            //Instantiating the genric class with int type

            Employee<string,long> intobject = new Employee<string,long>(new );
            intobject.display();
            

            Console.Read();



        }



    }


}
