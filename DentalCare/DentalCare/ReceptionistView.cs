using System;
using System.Collections;
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
        PatientHandling patientHandling = new PatientHandling();
        CheckIfValid checkIfValid = new CheckIfValid();

        public ReceptionistView()
        {

            InitializeComponent();
            pnlNavReceptionist.Visible = true;
            pnlAddBooking.Visible = false;
            pnlPatientList.Visible = false;
            pnlNewPatient.Visible = false;
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddBooking.Visible = true;
            pnlPatientList.Visible = false;
            pnlNewPatient.Visible = false;
        }

        private void seePatientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddBooking.Visible = false;
            pnlNewPatient.Visible = false;
            pnlPatientList.Visible = true;
            patientHandling.fillPatientList(dataGridViewPatientList);

        }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddBooking.Visible = false;
            pnlNewPatient.Visible = true;
            pnlPatientList.Visible = false;

            FillDentistDropDown();

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
                if (checkIfValid.checkPersonalNumber(bDate))
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



        private void btnNewPatientRegister_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            String bDate = txtNewPatientPersonalNumber.Text;

            if (checkIfValid.checkPersonalNumber(bDate))
            {
                registerNewPatient(client);
                Boolean success = dbConn.InsertNewPatientToDB(client);

                if (success)
                {
                    MessageBox.Show("Patient registration was succesful");
                    ClearTextBoxes(this.Controls);
                }
                else
                {
                    MessageBox.Show("Patient registration failed");
                }
            }
            else
            {
                MessageBox.Show("Not a valid personal number");
            }


        }

        private void btnNewPatientCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);

        }

        private Client registerNewPatient(Client client)
        {
            client.PersonalNumber = txtNewPatientPersonalNumber.Text;
            client.FirstName = txtNewPatientFirstName.Text;
            client.LastName = txtNewPatientLastName.Text;
            client.Address = txtNewPatientAddress.Text;
            client.City = txtNewPatientCity.Text;
            client.PostCode = txtNewPatientPostCode.Text;
            client.PhoneNumber = txtNewPatientPhone.Text;
            client.Email = txtNewPatientEmail.Text;
            client.DentistID = GetDentistIDForNewPatient();

            return client;
        }

        private void ClearTextBoxes(Control.ControlCollection controls)
        {
            foreach (TextBox tb in controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            foreach (Control c in controls)
            {
                ClearTextBoxes(c.Controls);
            }
        }

        private void FillDentistDropDown()
        {
            DataTable dt = new DataTable();
            dt = dbConn.GetDentistList();
            cbxNewPatientDentist.Items.Clear();

            string[] dentists = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dentists[i] = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString();
            }

            foreach (string s in dentists)
            {
                cbxNewPatientDentist.Items.Add(s);
            }
        }

        private int GetDentistIDForNewPatient()
        {
            string temp = cbxNewPatientDentist.SelectedItem.ToString();
            string[] subStrings = temp.Split(' ');
            int id = Int32.Parse(subStrings[0]);

            return id;
        }
    }
      
}
