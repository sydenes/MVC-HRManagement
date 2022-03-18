using HRManagement.BLL.Abstract;
using HRManagement.BLL.Concrete.ResultServiceBLL;
using HRManagement.DAL.Abstract;
using HRManagement.Model.Entities;
using HRManagement.ViewModel.EmployeeViewModels;
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

        public ResultService<SingleEmployeeVM> GetEmployee(int id)
        {
            ResultService<SingleEmployeeVM> result = new ResultService<SingleEmployeeVM>();
            Employee emp=employeeDAL.Get(a => a.ID == id);
            if (emp == null)
            {
                result.AddError("Null hatası", "id ile uyumlu employee yok");
            }
            result.Data = new SingleEmployeeVM()
            {
                Address = emp.Address,
                BirthDay = emp.BirthDay,
                Email = emp.Email,
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                PhoneNumber = emp.PhoneNumber,
                Photo = emp.Photo,
                StartDate = emp.StartDate
            };
            return result;
        }
    }
}
