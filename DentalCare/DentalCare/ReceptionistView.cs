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
            
        }

        private void ReceptionistView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchPatientMakeBooking_Click(object sender, EventArgs e)
        {
            string bDate = txtSearchPatientMakeBooking.Text;

        }

        private void btnSubmitMakeBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
