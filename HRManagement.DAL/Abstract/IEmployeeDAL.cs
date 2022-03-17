using HRManagement.Core.DataAccess;
using HRManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DAL.Abstract
{
    public interface IEmployeeDAL:IRepository<Employee>
    {
    }
}
