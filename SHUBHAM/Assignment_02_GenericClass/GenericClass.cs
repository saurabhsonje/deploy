using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_GenericClass
{

    class GenericClass<T> : Object
    {

        public static readonly string ADDED_SUCCESSFULLY = "ENTITY SUCCESSFULLY ADDED";
        public static readonly string DELETED_SUCCESSFULLY = "ENTITY SUCCESSFULLY DELETED";
        public static readonly string OPERATION_FAILED= "OPERATION FAILED";
        public static readonly string DISPLAY_LIST = "ENTITIES INSIDE THE LIST";
        public static readonly string EMPTY_LIST = "LIST IS EMPTY";

        private readonly IList<T> list = new List<T>();



        public void AddEntity(T Entity)
        {
            try
            {
                list.Add(Entity);
                Console.WriteLine(ADDED_SUCCESSFULLY); 
            }
            catch (CustomException)
            {
                Console.WriteLine(new CustomException(OPERATION_FAILED)); 
            }
            catch (Exception Ex)
            {
                Console.WriteLine(new Exception(Ex.Message));

            }
        }


        public void DisplayList()
        {
            try
            {
                if (list.Count == 0) 
                   throw new CustomException(EMPTY_LIST);

                   Console.WriteLine(DISPLAY_LIST);
                   foreach (T e in list)
                   Console.Write(e.ToString());
                  
            }
            catch (CustomException Ex)
            {
                Console.WriteLine(Ex.Message);
               
            }

            catch (Exception Ex)
            {
                Console.WriteLine(new Exception(Ex.Message));
               
            }
        }

        public void DeleteEntity(T Id)
        {
            try
            {
                list.Remove(Id);
                Console.WriteLine(DELETED_SUCCESSFULLY); 
            }
            catch (CustomException)
            {
                Console.WriteLine(new CustomException(OPERATION_FAILED));
                
            }
            catch (Exception Ex)
            {
                Console.WriteLine(new Exception(Ex.Message));

            }
        }

    }

}
