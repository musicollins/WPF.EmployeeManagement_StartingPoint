using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.EmployeeManagement.UI.Model;

namespace WPF.EmployeeManagement.DataAccess
{
    public static class DataSeedClass
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, Firstname = "Rafael", Lastname = "Milanes", Email = "johnny@gmail.com", Department = Department.IT },
            new Employee { Id = 2, Firstname = "Johnny", Lastname = "Cage", Email = "Juan@gmail.com", Department = Department.IT },
            new Employee { Id = 3, Firstname = "Anna", Lastname = "Lindgren", Email = "Anna@gmail.com", Department = Department.Agriculture },
            new Employee { Id = 4, Firstname = "Juanete", Lastname = "Pérez", Email = "John@gmail.com", Department = Department.Education },
            new Employee { Id = 5, Firstname = "New", Lastname = "SuperNew", Email = "new@gmail.com", Department = Department.Education }
            );
        }
    }
}
