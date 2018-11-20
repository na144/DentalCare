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
    public partial class DentistView : Form
    {
        DBconn dbconn = new DBconn();
        PatientHandling patientHandling = new PatientHandling();
        CheckIfValid checkIfValid = new CheckIfValid();
        

        public DentistView()
        {
            InitializeComponent();
            pnlNavReceptionist.Visible = true;
            pnlPatientList.Visible = false;
        }

        private void DentistView_Load(object sender, EventArgs e)
        {
            
        }

        private void seePatientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPatientList.Visible = true;
            patientHandling.fillPatientList(dataGridViewPatientList);
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            string bDate = txtSearchPatient.Text;

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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginView lv = new LoginView();
            lv.ShowDialog();
        }
    }
}
