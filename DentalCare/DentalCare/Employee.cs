using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Employee : Person
    {
        private string employeeId;
        private string role;

        public string EmployeeId { get; set; }
        public string Role { get; set; }
    }
}
