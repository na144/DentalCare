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
        public DentistView()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginView lv = new LoginView();
            lv.ShowDialog();
        }
    }
}
