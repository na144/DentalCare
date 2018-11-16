using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace DentalCare
{
    class DBconn
    {
        DataSet ds;
        DataTable dt;
        SqlCommand myCommand;
        SqlDataAdapter adapter;
        SqlConnection myConnection;

        //string VfileName = "AttachDbFilename = C:\\Users\\veron\\Desktop\\Projekt\\DentalCare\\DentalCare\\DentalCare\\dbDentalCare.mdf;";
        //string KfileName = "AttachDbFilename = C:\\USERS\\KARIN\\DESKTOP\\KURSADVPRO\\DENTALCARE\\DENTALCARE\\DENTALCARE\\DBDENTALCARE.MDF;";

        SqlParameter workparameter1;
        SqlParameter workparameter2;
        SqlParameter workparameter3;
        SqlParameter workparameter4;
        SqlParameter workparameter5;
        SqlParameter workparameter6;
        SqlParameter workparameter7;
        SqlParameter workparameter8;
        SqlParameter workparameter9;
        SqlParameter workparameter10; 

        public DBconn()
        {
            myConnection = new SqlConnection();
            myConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Name"].ToString();


            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            ///* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";
            /* V- */
            //"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";
            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            /*"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";*/

            //myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+KfileName+"Integrated Security=True";

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
            workparameter1 = new SqlParameter();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spGetPatientByPersonalNumber";
            workparameter1 = myCommand.Parameters.Add("@fldPersonalNumber", SqlDbType.VarChar);
            workparameter1.Value = number;

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


        public bool InsertNewPatientToDB(Client client)
        {
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spRegisterNewPatient";

            workparameter1 = new SqlParameter("@Personalnumber", SqlDbType.VarChar);
            workparameter2 = new SqlParameter("@Firstname", SqlDbType.VarChar);
            workparameter3 = new SqlParameter("@Lastname", SqlDbType.VarChar);
            workparameter4 = new SqlParameter("@Address", SqlDbType.VarChar);
            workparameter5 = new SqlParameter("@City", SqlDbType.VarChar);
            workparameter6 = new SqlParameter("@Postcode", SqlDbType.VarChar);
            workparameter7 = new SqlParameter("@Phone", SqlDbType.VarChar);
            workparameter8 = new SqlParameter("@Email", SqlDbType.VarChar);
            workparameter9 = new SqlParameter("@EmployeeID", SqlDbType.VarChar);
            workparameter10 = new SqlParameter("@Rows", SqlDbType.Int);

            myCommand.Parameters.Add(workparameter1);
            workparameter1.Value = client.PersonalNumber;

            //workparameter2 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter2);
            workparameter2.Value = client.FirstName;

            //workparameter3 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter3);
            workparameter3.Value = client.LastName;

            //workparameter4 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter4);
            workparameter4.Value = client.Address;

            //workparameter5 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter5);
            workparameter5.Value = client.City;

            //workparameter6 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter6);
            workparameter6.Value = client.PostCode;

            //workparameter7 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter7);
            workparameter7.Value = client.PhoneNumber;

            //workparameter8 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter8);
            workparameter8.Value = client.Email;

            //workparameter9 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter9);
            workparameter9.Value = client.DentistID;

            //workparameter10 = myCommand.Parameters.Add();
            myCommand.Parameters.Add(workparameter10);
            workparameter10.Direction = ParameterDirection.Output;

            myConnection.Open();
            myCommand.ExecuteNonQuery();

            int svar = Convert.ToInt32(workparameter10.SqlValue.ToString());

            myConnection.Close();

            if(svar == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetDentistList()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spGetDentistList";

            adapter.SelectCommand = myCommand;
            adapter.Fill(dt);

            myConnection.Close();

            return dt;
        }

    }



    
}
