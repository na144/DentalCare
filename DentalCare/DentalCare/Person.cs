using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    abstract class Person
    {
        private int personId;
        private string personalNumber;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string postCode;
        private string phoneNumber;
        private string email;

        public int PersonId { get; set; }
        public string PersonalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
