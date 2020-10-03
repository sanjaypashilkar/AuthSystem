using AuthSystem.DataAccess.DBModels;
using AuthSystem.DataAccess.Repository.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem.DataAccess.Repository.Implementation
{
    public class EmployeRepository : IEmployeRepository
    {
        EmployeeDBContext _dbContext = new EmployeeDBContext();
        public bool IsUserValid(Models.Employee user)
        {
            bool IsValidUser = _dbContext.Employees
                .Any(u => u.Username.ToLower() == user
                .UserName.ToLower() && user
                .Password == user.Password);

            return IsValidUser;
        }
    }
}
