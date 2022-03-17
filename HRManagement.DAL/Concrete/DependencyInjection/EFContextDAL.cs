using HRManagement.DAL.Abstract;
using HRManagement.DAL.Concrete.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DAL.Concrete.DependencyInjection
{
    public static class EFContextDAL
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {
            //services.AddDbContext<HRManagementDbContext>();
            services.AddScoped<IEmployeeDAL, EmployeeRepository>();
            //services.AddScoped<IPermissionDAL, PermissionRepository>();
        }
    }
}
