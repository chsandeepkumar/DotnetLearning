using System.Collections.Generic;
using System.Web.Http;
using RSS.EconsultatntManagementWebAPI.Services;
using System.Collections;
using Newtonsoft.Json;

namespace RSS.EconsultatntManagementWebAPI.Controllers
{
    public class EmpoyeeController : ApiController
    {
        // GET: api/Empoyee
        //public IEnumerable GetEmployeeDetails(int EmployeeId)
        //{
        //    //return new string[] { "value1", "value2" };
        //    IEmployee employeeService = new EmployeeService();
        //    return employeeService.GetEmployeeDetails(EmployeeId);

        //}

        // GET: api/Empoyee/5
        public string Get(int id)
        {
            return  "Rajesh";
        }

        // POST: api/Empoyee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Empoyee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Empoyee/5
        public void Delete(int id)
        {
        }
    }
}
