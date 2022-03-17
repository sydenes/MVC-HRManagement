using HRManagement.BLL.Concrete.ResultServiceBLL;
using HRManagement.Model.Entities;
using HRManagement.ViewModel.EmployeeViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.BLL.Abstract
{
    public interface IEmployeeBLL : IBaseBLL<Employee>
    {
        ResultService<SingleEmployeeVM> GetEmployee(int id);
    }
}
