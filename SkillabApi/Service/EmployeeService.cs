using Microsoft.EntityFrameworkCore;
using SkillabApi.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkillabApi.Service
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeContext _employeeContext;

        public EmployeeService(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }



        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee{
                id = 1,
                fullname = "Iacob Robert",
                birthdate = DateTime.Now.AddYears(-29),
                hobby = "programming",
                job = "Software Engineer",
                favouritepicturelink = "https://media.astonmartin.com/wp-content/uploads/2019/02/909497.jpg"
            },
            new Employee{
                id = 2,
                fullname = "Stefan Alexandru",
                birthdate = DateTime.Now.AddYears(-27),
                hobby = "programming",
                job = "Software Developer",
                favouritepicturelink = "https://media.astonmartin.com/wp-content/uploads/2019/02/909497.jpg"
            },
            new Employee{
                id = 3,
                fullname = "Radulescu Andrei",
                birthdate = DateTime.Now.AddYears(-40),
                hobby = "programming",
                job = "Programmer",
                favouritepicturelink = "https://media.astonmartin.com/wp-content/uploads/2019/02/909497.jpg"
            }
        };



        public async Task<List<Employee>> GetEmployees()
        {

            return await _employeeContext.employees.ToListAsync();
        
        }


        public async Task AddHardCodedEmployees()
        {
            _employeeContext.employees.AddRange(Employees);
            await _employeeContext.SaveChangesAsync();
        }
    }
}
