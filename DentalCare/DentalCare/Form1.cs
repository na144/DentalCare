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
    public partial class Login : Form
    {
        DBconn dbconn = new DBconn();
        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = cmbRole.Text;
            dt = dbconn.Login(username,password,role);
            if (dt.Rows.Count > 0)
            {
                if (role=="Reception")
                {
                    this.Hide();
                    Form r = new ReceptionistView();
                    r.ShowDialog();
                    this.Close();
                }
                if (role == "Admin")
                {
                    MessageBox.Show("Admin View!");
                }
                if (role == "Dentist")
                {
                    MessageBox.Show("Dentist View!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Credentials! Please try again!");
                txtUserName.Focus();
            }
        }

        private void cmdRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
