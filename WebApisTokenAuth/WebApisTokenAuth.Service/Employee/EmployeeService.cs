using ExpressMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Entity;
using WebApisTokenAuth.Core.EntityModel;

namespace WebApisTokenAuth.Service.Employee
{
    public class EmployeeService : IEmployeeService
    {
       
        private AuthenticationEntities _Context = new AuthenticationEntities();
        #region Public_Methods
        public dynamic GetEmployees()
        {
            return _Context.Employees.AsEnumerable().Select(x => new { x.EmloyeeName, Designation = x.Designation.Name, x.Address, x.Salary }).ToList();

        }
        #endregion
    }
}
