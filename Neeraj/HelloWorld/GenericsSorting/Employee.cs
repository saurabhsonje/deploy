using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSorting
{
    class Employee :IValue
    {
        public int id { set; get; }
        public int age { set; get; }
        public string name { set; get; }


        public Employee(int id,string name,int age)
        {
            this.id = id;
            this.age = age;
            this.name = name;

        }

        public int GetValue()
        {
            return age;
        }
    }


}
