using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Client : Person
    {
        private int clientId;
        private int dentistId;

        public int DentistID { get; set; }

        public int ClientId { get; set; }
    }
}
