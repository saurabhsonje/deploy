using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07
{
    class Program
    {
        
        static void Main(string[] args)
        { int caseuse = 1; ;
            string Continue;
            do
            {
                Console.WriteLine("1.ArrayList\n2.List");
                caseuse = int.Parse(Console.ReadLine());
                Customer_info cust = new Customer_info();
                switch (caseuse)
                {

                    case 1:
                        ArrayList_operation op = new ArrayList_operation();

                        //CURD operation on ArrayList
                        cust.GetInfo();
                        op.ArrayList_Add(cust);
                        op.Reverse();
                        op.Delete();
                        op.search();
                        op.a1.Insert(1, "Sau");
                        op.display(op.a1);
                        op.update();

                        break;
                    case 2:

                        //CURD operation on List
                        ListOpration list = new ListOpration();
                        
                        cust.GetInfo();
                        list.AddListElement(cust);
                        list.sortElement();
                        list.DeleteListElement(cust);
                        list.UpdateListElement();
                        break;
                }
                Console.Write("Do You Want To Continue? (Y/N) : ");
                Continue = Console.ReadLine();

            } while (Continue != "N" && Continue != "n");
                               
        }
    }
}
