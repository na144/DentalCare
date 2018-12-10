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
        AppointmentHandling appointmentHandling = new AppointmentHandling();
        CheckIfValid checkIfValid = new CheckIfValid();
        CheckDate checkDate = new CheckDate();

        public ReceptionistView()
        {

            InitializeComponent();
            HidePanels();
            pnlNavReceptionist.Visible = true;
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlAddBooking.Visible = true;
            pnlNavReceptionist.Visible = true;
        }

        private void seePatientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlPatientList.Visible = true;
            pnlNavReceptionist.Visible = true;
            patientHandling.fillPatientList(dataGridViewPatientList);

        }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlNewPatient.Visible = true;
            pnlNavReceptionist.Visible = true;
            FillDentistDropDown();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlViewAllAppointments.Visible = true;
            pnlNavReceptionist.Visible = true;
            appointmentHandling.FillAppointmentsList(dbConn, dataGridViewAppointments);
            

        }

        private void ReceptionistView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchPatientMakeBooking_Click(object sender, EventArgs e)
        {
            dbConn.getPatientInfo(txb, txb2, txb3, txtClientID, txtDentist);
        }

        private void btnSubmitMakeBooking_Click(object sender, EventArgs e)
        {
            dbConn.CreateNewBooking(txtDate, txtClientID, txtDentist, txtExaminationType, txtNotes, txtTime);
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

        private void btnSearchAppointments_Click(object sender, EventArgs e)
        {
            String bDate = txtSearchAppointments.Text;

            if (!String.IsNullOrEmpty(bDate))
            {
                if (checkIfValid.checkPersonalNumber(bDate))
                {
                    appointmentHandling.FilterAppointmentList(bDate, dbConn, dataGridViewAppointments);
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

            int id = patientHandling.GetDentistIDForNewPatient(cbxNewPatientDentist);

            if (checkIfValid.checkPersonalNumber(bDate))
            {
                patientHandling.registerNewPatient(
                    client, txtNewPatientPersonalNumber, txtNewPatientFirstName, txtNewPatientLastName,
                    txtNewPatientAddress, txtNewPatientCity, txtNewPatientPostCode, txtNewPatientPhone,
                    txtNewPatientEmail, id);
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

        //Recursive method that iterates over all textboxes to empty them
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
                dentists[i] = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();
            }

            foreach (string s in dentists)
            {
                cbxNewPatientDentist.Items.Add(s);
            }
        }

        private void dataGridViewPatientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String selectedPatient = dataGridViewPatientList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            ClientInfoView clientInfoView = new ClientInfoView(/*selectedPatient*/);
            this.Hide();
            clientInfoView.Visible = true;
        }

        private void HidePanels()
        {
            foreach(Panel pnl in this.Controls.OfType<Panel>())
            {
               
                    pnl.Visible = false;
                
                
            }
        }
        private void lblReceptionistUser_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginView lv = new LoginView();
            lv.ShowDialog();

        }
    }
}
