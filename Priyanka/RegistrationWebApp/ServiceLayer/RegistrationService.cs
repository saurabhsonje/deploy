using RegistrationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class RegistrationService:IRegistration
    {



        AppDbContext dbContext = new AppDbContext();


        

        public Register GetEmployeeById(int id)
        {
            return dbContext.registerModel.Where(x => x.empId == id).FirstOrDefault();
        }


    }
}
