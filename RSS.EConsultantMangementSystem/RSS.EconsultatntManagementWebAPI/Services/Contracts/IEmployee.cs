using System.Collections;
using System.Collections.Generic;

namespace RSS.EconsultatntManagementWebAPI
{
    interface IEmployee
    {
        Employee GetEmployeeDetails(int EmployeeId);
        int Saveemployee(int Employeeid, string EmployeeName);
    }
}
