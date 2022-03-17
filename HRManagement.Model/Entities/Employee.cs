using HRManagement.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Model.Entities
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            Permissions = new HashSet<Permission>();
        }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime StartDate { get; set; } 
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
