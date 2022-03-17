using HRManagement.BLL.Concrete.ResultServiceBLL;
using HRManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.BLL.Abstract
{
    public interface IEmployeeBLL : IBaseBLL<Employee>
    {
        ResultService<EmployeVM> GetEmployee(int id);
    }
}
