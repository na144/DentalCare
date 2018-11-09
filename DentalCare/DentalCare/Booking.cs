using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Booking
    {
        private int bookingId;
        private string appointmentDate;
        private string examinationType;
        private string dentist;
        private string additionalnotes;

        public int BookingId { get; set; }
        public string AppointmentDate { get; set; }
        public string ExaminationType { get; set; }
        public string Dentist { get; set; }
        public string Additionalnotes { get; set; }

        public Booking()
        {
            this.AppointmentDate = "";
            this.ExaminationType = "";
            this.Dentist = "";
            this.Additionalnotes = "";
        }

        public Booking(string aDate, string eType, string dent, string aNotes)
        {

            this.AppointmentDate = aDate;
            this.ExaminationType = eType;
            this.Dentist = dent;
            this.Additionalnotes = aNotes;
        }
    }
}
