using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
{
    public partial class AdminView : Form
    {
        DBconn dbconn = new DBconn();
        DataTable dt = new DataTable();

        public AdminView()
        {
            InitializeComponent();
            pnlEmployeeList.Visible = false;
            pnlAddEmployee.Visible = false;
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            dataGridViewEmployeeList.DataSource = dbconn.EmployeesList();
        }

        private void employeesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddEmployee.Visible = false;
            pnlEmployeeList.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginView lv = new LoginView();
            lv.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEmployeeList.Visible = false;
            pnlAddEmployee.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()) && !string.IsNullOrEmpty(cmbRole.Text.Trim()) &&
                !string.IsNullOrEmpty(txtPN.Text.Trim()) && !string.IsNullOrEmpty(txtFN.Text.Trim()) && !string.IsNullOrEmpty(txtLN.Text.Trim()) &&
                !string.IsNullOrEmpty(txtAddress.Text.Trim()) && !string.IsNullOrEmpty(txtCity.Text.Trim()) && !string.IsNullOrEmpty(txtPost.Text.Trim()) &&
                !string.IsNullOrEmpty(txtPhone.Text.Trim()) && !string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                Regex regex = new Regex(@"\d+");
                Match match = regex.Match(cmbRole.Text);
                Employee emp = new Employee();
                Login log = new Login();
                var h = new Hasher();
                log.UserName = txtUsername.Text;
                log.Password = h.Encrypt(txtPassword.Text);
                emp.RoleId = int.Parse(match.Value);
                emp.PersonalNumber = txtPN.Text;
                emp.FirstName = txtFN.Text;
                emp.LastName = txtLN.Text;
                emp.Address = txtAddress.Text; 
                emp.City = txtCity.Text;
                emp.PostCode = txtPost.Text;
                emp.PhoneNumber = txtPhone.Text;
                emp.Email = txtEmail.Text;
                dbconn.AddEmployee(emp, log);
                txtUsername.Clear();
                txtPassword.Clear();
                txtPN.Clear();
                txtFN.Clear();
                txtLN.Clear();
                txtAddress.Clear();
                txtCity.Clear();
                txtPost.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                cmbRole.ResetText();
            }
            else
            {
                MessageBox.Show("Empty required fields not allowed!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtPN.Clear();
            txtFN.Clear();
            txtLN.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtPost.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cmbRole.ResetText();
        }
    }
}
