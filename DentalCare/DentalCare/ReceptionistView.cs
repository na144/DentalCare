using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            fillPatientList();         
        }

        private void ReceptionistView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchPatientMakeBooking_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSubmitMakeBooking_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            String bDate = txtSearchPatient.Text;

            if (!String.IsNullOrEmpty(bDate))
            {
                filterPatientList(bDate);
            }
            else
            {
                fillPatientList();
            }

        }

        private void fillPatientList()
        {
            dt = new DataTable();
            dt = dbConn.getPatientList();

            dataGridViewPatientList.DataSource = dt;
        }

        private void filterPatientList(string num)
        {
            dt = new DataTable();
            dt = dbConn.getPatientByPersonalNumber(num);

            //dataGridViewPatientList.Rows.Clear();
            dataGridViewPatientList.DataSource = dt;
        }

        private void pnlNavReceptionist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchPatientMakeBooking_Click_1(object sender, EventArgs e)
        {
            dbConn.getClientInfo(txb, txb2, txb3, txtEmployeeID, txtClientID);
        }

        private void btnSubmitMakeBooking_Click_1(object sender, EventArgs e)
        {
            dbConn.CreateNewBooking(txtDate, txtClientID, txtEmployeeID, txtExaminationType, txtNotes, txtTime);
        }
    }
}
