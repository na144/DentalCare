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
    public partial class LoginView : Form
    {
        DBconn dbconn = new DBconn();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                var h = new Hasher();
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                dt2 = dbconn.CheckLogin(username);
                string getpas = dt2.Rows[0][1].ToString();
                var match = h.CompareStringToHash(password, getpas);
                dt = dbconn.getRole(username);
                if (match == true)
                {
                    if (dt.Rows[0].Field<string>(1) == "Receptionist")
                    {
                        this.Hide();
                        ReceptionistView rv = new ReceptionistView();
                        rv.lblReceptionistUser.Text = username;
                        rv.ShowDialog();
                        this.Close();
                    }
                    if (dt.Rows[0].Field<string>(1) == "Dentist")
                    {
                        this.Hide();
                        DentistView dv = new DentistView();
                        dv.lblDentistUser.Text = username;
                        dv.ShowDialog();
                        this.Close();
                    }
                    if (dt.Rows[0].Field<string>(1) == "Admin")
                    {
                        this.Hide();
                        AdminView av = new AdminView();
                        av.lblAdminUser.Text = username;
                        av.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials! Please try again!");
                }
            }
            else
                MessageBox.Show("Empty UserName or Password!");
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
            txtUserName.ForeColor = Color.Black;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = Color.Black;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
