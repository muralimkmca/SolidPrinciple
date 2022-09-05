using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmployeeDataFactory
    {
        public static EmployeeDataAccess GetemployeeDataAccessById()
        {
            return new EmployeeDataAccess();
        }
    }
}
