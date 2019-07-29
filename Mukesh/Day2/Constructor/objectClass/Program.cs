using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectClass
{
    class Company
    {
        int empId;
        string name;
        int year;
        static float rateOfGrowth;

        //creating parameterized constructor
        public Company(int i, string n, int y)
        {
            empId = i;
            name = n;
            year = y;
        }

        //creating static constructor
        static Company()
        {
            rateOfGrowth = 14.7f;
        }

        //Creating static Class, whose instance can't be created
        public static class companyval
        {
            public static int monthlyVal = 10;

            public static int yearlyVal(int n)
            {
                return monthlyVal * n;
            }
        }

        public void showDetails()
        {
            Console.WriteLine("Hi this is {0} and my employee Id is {1} and I have been working for {2} years", name,empId, year);
            Console.WriteLine(" and the Growth of company is {0} with monthly income of {1} million USD and yearly {2} million USD\n", rateOfGrowth,companyval.monthlyVal,companyval.yearlyVal(12));
        }

    }

    class Program
    {
     
        static void Main(string[] args)
        {
            Company cp = new Company(120, "Sohail", 3);
            Company cp1 = new Company(122, "Arun", 5);
            cp.showDetails();
            cp1.showDetails();

            Console.ReadKey();
        }
    }
}
