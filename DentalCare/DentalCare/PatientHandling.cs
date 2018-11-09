using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Forms;

namespace DentalCare
{
    class PatientHandling
    {
        DataTable dt;
        DBconn dbConn = new DBconn();
        public void fillPatientList(DataGridView dataGridView)
        {
            dt = new DataTable();
            dt = dbConn.getPatientList();

            dataGridView.DataSource = dt;

        }

        public void filterPatientList(string num, DataGridView dataGridView)
        {
            dt = new DataTable();
            dt = dbConn.getPatientByPersonalNumber(num);

            dataGridView.DataSource = dt;
        }

        public bool checkPatientPersonalNumber(string number)
        {
            Match match = Regex.Match(number, @"^\d\d\d\d\d\d\d\d-\d\d\d\d$");
            if (match.Success)
            {
                return true;
            }
            return false;
        }
    }
}
