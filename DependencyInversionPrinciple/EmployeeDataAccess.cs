using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmployeeDataAccess
    {
        public Employee getEmployeeDetails(int id)
        {
            var emp = new Employee()
            {
                EmpId = id,
                Name = "Murali",
                Department = "IT",
                Salary = 80000
            };
            return emp;
        }
    }
}
