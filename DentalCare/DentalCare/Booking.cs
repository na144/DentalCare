﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare
{
    class Booking
    {
        private string date;
        private int clientID;
        private int dentist;
        private string type;
        private string notes;
        private string time;

        public Booking()
        {
            this.date = "";
            this.clientID = 0;
            this.dentist = 0;
            this.type = "";
            this.notes = "";
            this.time = "";
        }

        public Booking(string d, int c, int de, string t, string n, string ti)
        {
            this.date = d;
            this.clientID = c;
            this.dentist = de;
            this.type = t;
            this.notes = n;
            this.time = ti;
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public int ClientID
        {
            get
            {
                return this.clientID;
            }
            set
            {
                this.clientID = value;
            }
        }

        public string ExaminationType
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public int Dentist
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
        public string Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                this.notes = value;
            }
        }
        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
    }
}
