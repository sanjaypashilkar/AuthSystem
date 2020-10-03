using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using AuthSystem.DataAccess.Repository.Implementation;

namespace AuthSystem.Business
{
    public class EmployeeBL
    {
        EmployeRepository employeRepository = new EmployeRepository();
        public bool IsUserValid(Employee user)
        {
            return employeRepository.IsUserValid(user);
        }
    }
}
