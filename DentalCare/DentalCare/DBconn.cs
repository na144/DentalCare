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
        string VfileName = "AttachDbFilename = C:\\Users\\veron\\Desktop\\Projekt\\DentalCare\\DentalCare\\DentalCare\\dbDentalCare.mdf;";

        public DBconn()
        {
            myConnection = new SqlConnection();
            myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+VfileName+"Integrated Security=True";
            ///* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";
            ///* V- */"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";
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

    }
}
