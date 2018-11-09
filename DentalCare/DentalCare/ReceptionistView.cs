using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
{
    public partial class ReceptionistView : Form
    {
        DBconn dbConn = new DBconn();
        PatientHandling patientHandling= new PatientHandling();
        DataTable dt;

        public ReceptionistView()
        {
     
            InitializeComponent();
            pnlNavReceptionist.Visible = true;
            pnlAddBooking.Visible = false;
            pnlPatientList.Visible = false;

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddBooking.Visible = true;
            pnlPatientList.Visible = false;
        }

        private void seePatientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddBooking.Visible = false;
            pnlPatientList.Visible = true;
            patientHandling.fillPatientList(dataGridViewPatientList);
            
        }

        private void ReceptionistView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchPatientMakeBooking_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSubmitMakeBooking_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Dentist = txtDentist.Text;
            booking.AppointmentDate = txtNotesMakeBooking.Text;
            booking.ExaminationType = txtExaminationType.Text;
          
            booking.Additionalnotes = txtNotesMakeBooking.Text;
            Boolean answer = dbConn.InsertNewBookingToDB(booking);
            if (answer == true)
            {
                MessageBox.Show("New booking is inserted.");
                cboxAppointmentDate.Items.Clear();
                txtExaminationType.ResetText();
                txtDentist.ResetText();
                txtNotesMakeBooking.ResetText();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            String bDate = txtSearchPatient.Text;

            if (!String.IsNullOrEmpty(bDate))
            {
                if (patientHandling.checkPatientPersonalNumber(bDate))
                {
                    patientHandling.filterPatientList(bDate, dataGridViewPatientList);
                }
                else
                {
                    MessageBox.Show("Not a valid personal number");
                }
                
            }
            else
            {
                patientHandling.fillPatientList(dataGridViewPatientList);
            }
            

        }

        
    }
}
