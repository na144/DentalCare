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
        //string VfileName = "AttachDbFilename = C:\\Users\\veron\\Desktop\\Projekt\\DentalCare\\DentalCare\\DentalCare\\dbDentalCare.mdf;";
        string KfileName = "AttachDbFilename = C:\\USERS\\KARIN\\DESKTOP\\KURSADVPRO\\DENTALCARE\\DENTALCARE\\DENTALCARE\\DBDENTALCARE.MDF;";

        public DBconn()
        {
            myConnection = new SqlConnection();


            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            ///* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";
            /* V- */
            //"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";
            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            /*"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";*/


            myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+KfileName+"Integrated Security=True";
            ///* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";
            ///* V- */"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";
            ///

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

        public bool InsertNewBookingToDB(Booking booking)
        {
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spRegNewBooking";

            SqlParameter workparameter1 = new SqlParameter();
            SqlParameter workparameter2 = new SqlParameter();
            SqlParameter workparameter3 = new SqlParameter();
            SqlParameter workparameter4 = new SqlParameter();
            SqlParameter workparameter5 = new SqlParameter();

            workparameter1 = myCommand.Parameters.Add("@AppointmentDate", SqlDbType.VarChar);
            workparameter1.Value = booking.AppointmentDate;

            workparameter2 = myCommand.Parameters.Add("@ExaminationType", SqlDbType.VarChar);
            workparameter2.Value = booking.ExaminationType;

            workparameter3 = myCommand.Parameters.Add("@Dentist", SqlDbType.VarChar);
            workparameter3.Value = booking.Dentist;

            workparameter4 = myCommand.Parameters.Add("@AdditionalNotes", SqlDbType.VarChar);
            workparameter4.Value = booking.Additionalnotes;

            workparameter5 = myCommand.Parameters.Add("@AntalRader", SqlDbType.Int);
            workparameter5.Direction = ParameterDirection.Output;

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            int svar = Convert.ToInt32(workparameter5.SqlValue.ToString());
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

        //
        public void getClientInfo (TextBox txb, TextBox txb2, TextBox txb3, TextBox txb4, TextBox txb5,
            TextBox txb6, TextBox txb7,TextBox txb8, TextBox txb9)
        {
            String procedName = "spGetClientInfo"; ;
            myConnection.Open();
            myCommand = new SqlCommand(procedName, myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@fldPersonalnumber", (txb.Text));
            SqlDataReader dr;
            dr = myCommand.ExecuteReader();

            if (dr.Read())
            {
                txb2.Text = dr["persNumber"].ToString();
                txb3.Text = dr["fName"].ToString();
                txb4.Text = dr["lName"].ToString();
                txb5.Text = dr["address"].ToString();
                txb6.Text = dr["city"].ToString();
                txb7.Text = dr["postcode"].ToString();
                txb8.Text = dr["phone"].ToString();
                txb9.Text = dr["email"].ToString();
               

            }
            else
            {
                txb2.Text = "";
            }

            myConnection.Close();
        }
    }



    
}
