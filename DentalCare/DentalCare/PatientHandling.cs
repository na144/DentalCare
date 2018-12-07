using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DentalCare
{
    class PatientHandling
    {
        DataTable dt;
        DataTable dt2;

        DBconn dbConn = new DBconn();
        public void fillPatientList(DataGridView dataGridView)
        {
            dt = new DataTable();
            dt = dbConn.GetPatientList();

            dataGridView.DataSource = dt;

        }

        public void filterPatientList(string num, DataGridView dataGridView)
        {
            dt = new DataTable();
            dt = dbConn.GetPatientByPersonalNumber(num);

            dataGridView.DataSource = dt;
        }

        public Client registerNewPatient(
            Client client, TextBox txtPN, TextBox txtFN, 
            TextBox txtLN, TextBox txtA, TextBox txtC, 
            TextBox txtPC, TextBox txtPHN, TextBox txtE, int id
            )
        {
            client.PersonalNumber = txtPN.Text;
            client.FirstName = txtFN.Text;
            client.LastName = txtLN.Text;
            client.Address = txtA.Text;
            client.City = txtC.Text;
            client.PostCode = txtPC.Text;
            client.PhoneNumber = txtPHN.Text;
            client.Email = txtE.Text;
            client.DentistID = id;

            return client;
        }

        public int GetDentistIDForNewPatient(ComboBox cbxNewPatientDentist)
        {
            string temp = cbxNewPatientDentist.SelectedItem.ToString();
            string[] subStrings = temp.Split(' ');
            int id = Int32.Parse(subStrings[0]);

            return id;
        }

        public Client getClientObjectFromDT(DataTable dt)
        {
            Client client = new Client();

            
                client.ClientId = Int32.Parse(dt.Rows[0][0].ToString());
                client.PersonalNumber = dt.Rows[0][1].ToString();
                client.FirstName = dt.Rows[0][2].ToString();
                client.LastName = dt.Rows[0][3].ToString();
                client.Address = dt.Rows[0][4].ToString();
                client.City = dt.Rows[0][5].ToString();
                client.PostCode = dt.Rows[0][6].ToString();
                client.PhoneNumber = dt.Rows[0][7].ToString();
                client.Email = dt.Rows[0][8].ToString();
                client.DentistID = Int32.Parse(dt.Rows[0][9].ToString());

            
            

            return client;
            
        }

    }
}
