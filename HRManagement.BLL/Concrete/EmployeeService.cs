using HRManagement.BLL.Abstract;
using HRManagement.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.BLL.Concrete
{
    public class EmployeeService : IEmployeeBLL
    {
        IEmployeeDAL employeeDAL;

        public EmployeeService(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }

        
    }
}
