using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Examination : Booking
    {
        private int examinationId;
        private byte photo1;
        private byte photo2;
        private byte photo3;
        private byte photo4;

        public int ExaminationId { get; set; }
        public byte Photo1 { get; set; }
        public byte Photo2 { get; set; }
        public byte Photo3 { get; set; }
        public byte Photo4 { get; set; }
    }
}
