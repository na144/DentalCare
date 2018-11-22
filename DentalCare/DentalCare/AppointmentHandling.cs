using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
{
    class AppointmentHandling
    {
        DataTable dt;
        public void FillAppointmentsList(DBconn dbConn, DataGridView dataGridView, string sortingParam)
        {
            dt = new DataTable();
            dt = dbConn.GetAppointmentList(sortingParam);

            dataGridView.DataSource = dt;
        }

        public void FilterAppointmentList(String bDate, DBconn dbConn, DataGridView dataGridView)
        {
            dt = new DataTable();
            dt = dbConn.GetAppointmentByPersonalNumber(bDate);

            dataGridView.DataSource = dt;
        }

        
    }
}
