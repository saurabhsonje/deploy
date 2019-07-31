using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsAssignment
{
    public class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public int CustSalary { get; set; }


        Savingccount svAcc = new Savingccount();
        Savingccount currAcc = new Savingccount();

        public void customerDetailsWithaccount()
        {

            Console.WriteLine("Enter 1 for Saving account:");
            Console.WriteLine("Enter 2 for Current account:");
            int chooseAccount=Convert.ToInt16(Console.ReadLine());

            switch(chooseAccount)
            {
                case 1:
                    svAcc.AccountType = "saving";
                    Console.WriteLine("Enter the account number");
                    svAcc.AccountNumber = Console.ReadLine();
                    CustTransaction();
                    break;
                case 2:
                    svAcc.AccountType = "current";
                    Console.WriteLine("Enter the account number");
                    svAcc.AccountNumber = Console.ReadLine();
                    CustTransaction();
                    break;
            }
        }
        
        public void CustTransaction()
        {
            int choice = 0;
            string Continue;
            do
            {
                Console.WriteLine("Enter 1 to deposit ");
                Console.WriteLine("Enter 2 to Withdraw ");
                Console.WriteLine("Enter 3 to Calcuate Interest ");
                choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        svAcc.deposit();
                        break;
                    case 2:
                        currAcc.withdraw();
                        break;
                    case 3:
                        if (svAcc.AccountType == "saving")
                        {
                            Console.WriteLine("\nTotal saving amount after adding interest:"+svAcc.CalculateInterest());
                        }
                        else
                        {
                            Console.WriteLine("\nTotal saving amount after adding interest" + svAcc.CalculateInterest());
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
                Console.Write("\nDo You Want To Continue? (y/n) :");
                Continue = Console.ReadLine();
            } while (Continue != "N" && Continue != "n");
            return ;
        }

    }

        
    }
