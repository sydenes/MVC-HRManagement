using HRManagement.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DAL.Concrete.Context.EmployeeConfiguration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a=>a.ID);
            builder.Property(a => a.ID);

            builder.Property(a => a.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.BirthDay)
                .IsRequired();
            builder.Property(a => a.StartDate)
                .IsRequired();

            builder.Property(a => a.Photo);

            builder.Property(a => a.Email)
                .HasMaxLength(50)
                .IsRequired();
            builder.HasIndex(a => a.Email)
                .IsUnique();

            builder.Property(a => a.Password)
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(a => a.PhoneNumber)
                .HasMaxLength(13)
                .IsRequired();
            builder.Property(a => a.Address)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasData(new Employee
            {
                ID = 1,
                FirstName = "İnci",
                LastName = "Adıyaman",
                Email ="inci.adiyaman@hotmail.com",
                Password ="123",
                Address ="İstanbul",
                BirthDay = Convert.ToDateTime(1995 / 15 / 03),
                PhoneNumber ="05070698292",
                Photo ="...",
                StartDate= Convert.ToDateTime(2022 / 12 / 12),
            });
        }
    }
}
