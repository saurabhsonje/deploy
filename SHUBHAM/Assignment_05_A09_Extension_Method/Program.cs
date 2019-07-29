using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_05_A09_Extension_Method
{
    class Program
    {

        public const string ENTER_DATE = "ENTER THE DATE IN FORMAT --->DD/MM/YYYY";
        public const string EMPTY_DATE = "EMPTY DATE STRING IS NOT ACCEPTED ------> ";
        public const string RE_ENTER_DATE = "RE-ENTER THE DATE IN CORRECT FORMAT";
        public const string FOR_DD_MM_YYYY = "1 FOR DD/MM/YYYY";
        public const string FOR_MM_DD_YYYY = "2 FOR MM/DD/YYYY";
        public const string FOR_YYYY_MM_DD = "3 FOR YYYY/MM/DD";
        public const string EXIT = "4 FOR EXIT";
        public const string ENTER_CHOICE = "ENTER CHOICE";
        public const string INVALID_DAY = "INVALID DAY ENTRY";
        public const string INVALID_MONTH = "INVALID MONTH ENTRY";
        public const string INVALID_YEAR = "INVALID YEAR ENTRY";


        static void Main(string[] args)
        {
             Console.ReadLine();
        }


        public static void Initialization()
        {

            int choice = 0;
            Console.WriteLine(ENTER_DATE);
            var dateAsString = Console.ReadLine();

            while (String.IsNullOrEmpty(dateAsString))
            {

                Console.WriteLine(EMPTY_DATE);
                dateAsString = Console.ReadLine();

            }


            while (dateAsString.Length != 10 || !Regex.IsMatch(dateAsString, "[0-9,/]") || ValidateString(dateAsString) != "valid")
            {
                Console.WriteLine(RE_ENTER_DATE);
                dateAsString = Console.ReadLine();
            }



            do
            {
                Console.WriteLine(FOR_DD_MM_YYYY);
                Console.WriteLine(FOR_MM_DD_YYYY);
                Console.WriteLine(FOR_YYYY_MM_DD);
                Console.WriteLine(EXIT);
                Console.WriteLine(ENTER_CHOICE);

                choice = Convert.ToInt32(Console.ReadLine());
                string[] vs = dateAsString.FilterDate();
                switch (choice)
                {
                    case 1:
                        dateAsString.DateInDDMMYYYYFormat(ref vs);
                        break;
                    case 2:
                        dateAsString.DateInMMDDYYFormat(ref vs);

                        break;
                    case 3:
                        dateAsString.DateInYYMMDDFormat(ref vs);
                        break;



                    default:
                        Console.WriteLine(EXIT);
                        System.Environment.Exit(0);
                        break;
                }


            } while (choice != 0);

        }


        public static string ValidateString(string dateAsString)
        {
            
            string[] vs = dateAsString.FilterDate();

            int day = Convert.ToInt16(vs[0]);
            int month = Convert.ToInt16(vs[1]);
            int year = Convert.ToInt16(vs[2]);


            if (day > 31)
            {
                Console.WriteLine(INVALID_DAY);
                return "invalid";
            }
            if (month  > 12)
            {
                Console.WriteLine(INVALID_MONTH);
                return "invalid";
            }
            if (year >  2019)
            {
                Console.WriteLine(INVALID_YEAR);
                return "invalid";
            }
             return "valid";
        }


    }

}
