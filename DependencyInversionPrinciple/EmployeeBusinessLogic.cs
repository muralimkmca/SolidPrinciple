using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = EmployeeDataFactory.GetemployeeDataAccessById();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.getEmployeeDetails(id);
        }

    }
}
