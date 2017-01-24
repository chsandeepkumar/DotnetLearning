using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RSS.EconsultatntManagementWebAPI.Services
{
    public class EmployeeService : IEmployee
    {
        public List<Employee> EmployeeDetails = new List<Employee>();
        public EmployeeService()
        {
            
            EmployeeDetails.Add(new Employee { ID = 1, Name = "sandeep", Place = "Karimnagar" });
            EmployeeDetails.Add(new Employee { ID = 1, Name = "divya", Place = "Nalgonda" });
            EmployeeDetails.Add(new Employee { ID = 1, Name = "Rajesh", Place = "USA" });
        }
        public Employee GetEmployeeDetails(int EmployeeId)
        {

            var employee = EmployeeDetails.First(e => e.ID == EmployeeId);
           return employee;

        }

        public int Saveemployee(int Employeeid, string EmployeeName)
        {
            throw new NotImplementedException();
        }
    }
}