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
   
    

    public partial class ClientInfoView : Form
    {
        DBconn dbcon = new DBconn();
        

        public ClientInfoView()
        {
            InitializeComponent();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            dbcon.getClientInfo(txbSearchClient, txbPersNum, txbFname, txbLname, txbAdr, 
                txbCity, txbPcode, txbPhNum, txbEmail);

        }

        private void btnTransferPatient_Click(object sender, EventArgs e)
        {
            ClientTransfer clientTransfer = new ClientTransfer();
            string result = clientTransfer.TransferPatient(txbPersNum.Text);
            MessageBox.Show(result);
        }
    }
}
