using RegistrationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    interface IRegistration
    {
        
        Register GetEmployeeById(int id);
    }
}
