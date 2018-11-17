using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DentalCare
{
    class DBconn
    {
        DataSet ds;
        DataTable dt;
        SqlCommand myCommand;
        SqlDataAdapter adapter;
        SqlConnection myConnection;
        SqlParameter parameter1 = new SqlParameter();
        SqlParameter parameter2 = new SqlParameter();
        SqlParameter parameter3 = new SqlParameter();
        SqlParameter parameter4 = new SqlParameter();
        SqlParameter parameter5 = new SqlParameter();
        SqlParameter parameter6 = new SqlParameter();
        SqlParameter parameter7 = new SqlParameter();
        //string VfileName = "AttachDbFilename = C:\\Users\\veron\\Desktop\\Projekt\\DentalCare\\DentalCare\\DentalCare\\dbDentalCare.mdf;";
        string LfileName = "AttachDbFilename=C:\\Users\\linav\\Desktop\\Projects\\DentalCare\\DentalCare\\DentalCare\\dbDentalCare.mdf;";

        public DBconn()
        {
            myConnection = new SqlConnection();

            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            //* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";
            /* V- */
            //"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";
            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            /*"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";*/

            myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+LfileName+"Integrated Security=True";
            //* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";
            //* V- */"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";
        }

        public DataTable Login(string username,string password,string role)
        {

            myCommand = new SqlCommand("select L.fldUsername,L.fldPassword,U.fldRole from tblLogin L inner join tblUser U on L.fldLoginId=U.fldLoginId where fldUserName='" + username 
                                        + "'and fldPassword='" + password + "'and fldRole='" + role + "'",myConnection);

            dt = new DataTable();
            adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getPatientList()

        {
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            myCommand = new SqlCommand();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spGetPatientList";

            adapter.SelectCommand = myCommand;
            adapter.Fill(dt);

            myConnection.Close();
            return dt;
        }

        public DataTable getPatientByPersonalNumber(string number)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            myCommand = new SqlCommand();
            parameter1 = new SqlParameter();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spGetPatientByPersonalNumber";
            parameter1 = myCommand.Parameters.Add("@fldPersonalNumber", SqlDbType.VarChar);
            parameter1.Value = number;

            adapter.SelectCommand = myCommand;
            adapter.Fill(dt);

            myConnection.Close();
            return dt;
        }

        public void getClientInfo(TextBox txb, TextBox txb2, TextBox txb3, TextBox txtEmployeeID, TextBox txtClientID)
        {
            String conString = myConnection.ConnectionString;
            myConnection = new SqlConnection(conString);
            String procedName = "spGetClientInfo";
            myConnection.Open();
            myCommand = new SqlCommand(procedName, myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("fldPersonalnumber", (txb.Text));
            SqlDataReader dr;
            dr = myCommand.ExecuteReader();

            if (dr.Read())
            {
                txb2.Text = dr["fName"].ToString();
                txb3.Text = dr["lName"].ToString();
                txtEmployeeID.Text = dr["eID"].ToString();
                txtClientID.Text = dr["cID"].ToString();
            }
            else
            {
                txb2.Text = "";
                txb3.Text = "";
                txtEmployeeID.Text = "";
                txtClientID.Text = "";
            }
            myConnection.Close();
        }

        public void CreateNewBooking(TextBox txtDate, TextBox txtClientID, TextBox txtEmployeeID, TextBox txtExaminationType, TextBox txtNotes, TextBox txtTime)
        {
            Booking booking = new Booking();
            booking.Date = txtDate.Text;
            booking.ClientID = Convert.ToInt32(txtClientID.Text);
            booking.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            booking.ExaminationType = txtExaminationType.Text;
            booking.Notes = txtNotes.Text;
            booking.Time = txtTime.Text;
            Boolean answer = InsertNewBooking(booking);
            if (answer == true)
            {
                txtDate.ResetText();
                txtClientID.ResetText();
                txtEmployeeID.ResetText();
                txtExaminationType.ResetText();
                txtNotes.ResetText();
                txtTime.ResetText();  
                MessageBox.Show("New booking is inserted.");
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        public bool InsertNewBooking(Booking booking)
        {
            myCommand = new SqlCommand();
            parameter1 = new SqlParameter();
            parameter2 = new SqlParameter();
            parameter3 = new SqlParameter();
            parameter4 = new SqlParameter();
            parameter5 = new SqlParameter();
            parameter6 = new SqlParameter();
            parameter7 = new SqlParameter();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spRegNewBooking";

            parameter1 = myCommand.Parameters.Add("@Date", SqlDbType.VarChar);
            parameter1.Value = booking.Date;

            parameter2 = myCommand.Parameters.Add("@ClientID", SqlDbType.Int);
            parameter2.Value = Convert.ToInt32(booking.ClientID);

            parameter3 = myCommand.Parameters.Add("@EmployeeID", SqlDbType.Int);
            parameter3.Value = Convert.ToInt32(booking.EmployeeID);

            parameter4 = myCommand.Parameters.Add("@ExaminationType", SqlDbType.VarChar);
            parameter4.Value = booking.ExaminationType;

            parameter5 = myCommand.Parameters.Add("@Notes", SqlDbType.VarChar);
            parameter5.Value = booking.Notes;

            parameter6 = myCommand.Parameters.Add("@Time", SqlDbType.VarChar);
            parameter6.Value = booking.Time;

            parameter7 = myCommand.Parameters.Add("@Rows", SqlDbType.Int);
            parameter7.Direction = ParameterDirection.Output;

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            int svar = Convert.ToInt32(parameter7.SqlValue.ToString());

            myConnection.Close();
            
            if (svar == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
