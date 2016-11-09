using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAngularLearning.Models
{
    public class Employee
    {
        public int empContactId { get; set; }
        public string empFirstName { get; set; }
        public string empLastName { get; set; }
        public string empEmailId { get; set; }
    }
    public class EmpRoleDefinitions
    {
        public int empRoleId { get; set; }
        public int empRoleName { get; set; }
    }
    public class EmpRoles
    {

    }

}