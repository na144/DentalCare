using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Booking
    {
        private string appointmentDate;
        private string examinationType;
        private string dentist;
        private string additionalNotes;

        public Booking()
        {
            this.appointmentDate = "";
            this.examinationType = "";
            this.dentist = "";
            this.additionalNotes = "";

        }

        public Booking(string aDate, string eType, string dent, string aNotes)
        {

            this.appointmentDate = aDate;
            this.examinationType = eType;
            this.dentist = dent;
            this.additionalNotes = aNotes;
        }

        public string AppointmentDate
        {
            get
            {
                return this.appointmentDate;
            }
            set
            {
                this.appointmentDate = value;
            }
        }
        public string ExaminationType
        {
            get
            {
                return this.examinationType;
            }
            set
            {
                this.examinationType = value;
            }
        }

        public string Dentist
        {
            get
            {
                return this.dentist;
            }
            set
            {
                this.dentist = value;
            }
        }
        public string Additionalnotes
        {
            get
            {
                return this.additionalNotes;
            }
            set
            {
                this.additionalNotes = value;
            }
        }
    }
}
