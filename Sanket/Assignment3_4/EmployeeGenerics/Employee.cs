using System;


namespace EmployeeGenerics
{
    public class Employee<T>
    {
        private T name;
        private T age; 
        private T salary;
        private T designation;
        private static T id;

        public Employee() { }
        public Employee(T name, T age, T salary, T designation) {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.designation = designation;
        }
        public override string ToString()
        {
            Console.WriteLine();
            return "ID: "+ this.PropertyId + "\nName: " + this.PropertyName + "\nAge: " + this.PropertyAge + "\nDesignation: " + this.PropertyDesg + "\nsalary: " + this.PropertySalary;
        }

        public T PropertyName { get { return name; } set { name = value; } }
        public T PropertyAge { get { return age; } set { age = value; } }
        public T PropertySalary { get { return salary; } set { salary = value; } }
        public T PropertyDesg { get { return designation; } set { designation = value; } }
        public T PropertyId { get { return id; } set { id = value; } }
    }
}

