using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem.DataAccess.Repository.Interface
{
    interface IEmployeRepository
    {
        bool IsUserValid(Employee user);
    }
}
