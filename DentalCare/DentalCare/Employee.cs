using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Employee : Person
    {
        private int employeeId;
        private int roleId;
        private int loginId;

        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public int LoginId { get; set; }
    }
}
