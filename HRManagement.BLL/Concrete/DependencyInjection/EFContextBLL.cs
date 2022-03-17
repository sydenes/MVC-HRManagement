using HRManagement.BLL.Abstract;
using HRManagement.DAL.Concrete.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.BLL.Concrete.DependencyInjection
{
    public static class EFContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopeDAL(); 
            services.AddScoped<IEmployeeBLL, EmployeeService>();
          //services.AddScoped<IPermissionBLL, PermissionService>();
        }
    }
}
