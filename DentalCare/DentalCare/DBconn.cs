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

        public DBconn()
        {
            myConnection = new SqlConnection();

            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            ///* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";
            /* V- */
            //"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";
            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            /*"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";*/

            //myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+VfileName+"Integrated Security=True";
            //myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Git02\DentalCare\DentalCare\DentalCare\dbDentalCare.mdf;Integrated Security=True";
            ///* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";
            ///* V- */"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";
        }

        public DataTable CheckLogin(string username)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter(myCommand);
            myCommand = new SqlCommand
            {
                Connection = myConnection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "spLoginCheck"
            };
            myCommand.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            adapter.SelectCommand = myCommand;
            adapter.Fill(dt);
            myConnection.Close();
            return dt;
        }

        public DataTable getRole(string username)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            myCommand = new SqlCommand
            {
                Connection = myConnection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "spGetRole"
            };
            myCommand.Parameters.Add("@hasuname", SqlDbType.VarChar).Value = username;
            adapter.SelectCommand = myCommand;
            adapter.Fill(dt);
            myConnection.Close();
            return dt;
        }

        public void AddEmployee(Employee employee,Login login)
        {
            myCommand = new SqlCommand
            {
                Connection = myConnection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "spAddEmployee"
            };
            myCommand.Parameters.Add("@uname", SqlDbType.VarChar).Value = login.UserName;
            myCommand.Parameters.Add("@pword", SqlDbType.VarChar).Value = login.Password;
            myCommand.Parameters.Add("@roleid", SqlDbType.Int).Value = employee.RoleId;
            myCommand.Parameters.Add("@loginid", SqlDbType.Int).Value = employee.LoginId;
            myCommand.Parameters.Add("@personnumber", SqlDbType.VarChar).Value = employee.PersonalNumber;
            myCommand.Parameters.Add("@fname", SqlDbType.VarChar).Value = employee.FirstName;
            myCommand.Parameters.Add("@lname", SqlDbType.VarChar).Value = employee.LastName;
            myCommand.Parameters.Add("@address", SqlDbType.VarChar).Value = employee.Address;
            myCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = employee.City;
            myCommand.Parameters.Add("@pcode", SqlDbType.VarChar).Value = employee.PostCode;
            myCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = employee.PhoneNumber;
            myCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = employee.Email;
            myConnection.Open();
            int i = myCommand.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Registration Successful!");
            }
            myConnection.Close();
        }

        public DataTable EmployeesList()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            myCommand = new SqlCommand
            {
                Connection = myConnection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "spEmployeesList"
            };
            adapter.SelectCommand = myCommand;
            adapter.Fill(dt);
            myConnection.Close();
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
    }
}
