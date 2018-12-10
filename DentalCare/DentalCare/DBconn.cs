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

        //string KfileName = "AttachDbFilename = C:\\USERS\\KARIN\\DESKTOP\\KURSADVPRO\\DENTALCARE\\DENTALCARE\\DENTALCARE\\DBDENTALCARE.MDF;";
        string LfileName = "AttachDbFilename = C:\\Users\\linav\\Desktop\\AdvProj\\DentalCare\\DentalCare\\DentalCare\\dbDentalCare.mdf;";
        
        //string VfileName = "AttachDbFilename = C:\\Users\\veron\\Desktop\\Projekt\\DentalCare\\DentalCare\\DentalCare\\dbDentalCare.mdf;";

        
        public DBconn()
        {
            myConnection = new SqlConnection();
            //myConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Name"].ToString();

            //myConnection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=dbDentalCare;Trusted_Connection=True;";
            ///* G- */"Integrated Security=true;database=dbDentalCare;Data Source=LAPTOP-7DKPE6B0\\SQLEXPRESS14";

            //"Server=Laptop-B0P8Q1VE\\SQLEXPRESS;Database=dbDentalCare;Trusted_Connection=True;";

            //myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+KfileName+"Integrated Security=True";

            //myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+VfileName+"Integrated Security=True";
            //myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Git02\DentalCare\DentalCare\DentalCare\dbDentalCare.mdf;Integrated Security=True";

            myConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" + LfileName + "Integrated Security=True";
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

        public DataTable GetPatientList()

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

        public DataTable GetPatientByPersonalNumber(string number)
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

        public void CreateNewBooking(TextBox txtDate, TextBox txtClientID, TextBox txtDentist, TextBox txtExaminationType, TextBox txtNotes, TextBox txtTime)
        {
            Booking booking = new Booking();
            booking.Date = txtDate.Text;
            booking.ClientID = Convert.ToInt32(txtClientID.Text);
            booking.Dentist= Convert.ToInt32(txtDentist.Text);
            booking.ExaminationType = txtExaminationType.Text;
            booking.Notes = txtNotes.Text;
            booking.Time = txtTime.Text;
            Boolean answer = InsertNewBooking(booking);
            if (answer == true)
            {
                txtDate.ResetText();
                txtClientID.ResetText();
                txtDentist.ResetText();
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
            workparameter1 = new SqlParameter("@Date", SqlDbType.VarChar);
            workparameter2 = new SqlParameter();
            workparameter3 = new SqlParameter();
            workparameter4 = new SqlParameter();
            workparameter5 = new SqlParameter();
            workparameter6 = new SqlParameter();
            workparameter7 = new SqlParameter();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spRegNewBooking";

            workparameter1 = myCommand.Parameters.Add("@Date", SqlDbType.VarChar);
            workparameter1.Value = booking.Date;

            workparameter2 = myCommand.Parameters.Add("@ClientID", SqlDbType.Int);
            workparameter2.Value = Convert.ToInt32(booking.ClientID);

            workparameter3 = myCommand.Parameters.Add("@EmployeeID", SqlDbType.Int);
            workparameter3.Value = Convert.ToInt32(booking.Dentist);

            workparameter4 = myCommand.Parameters.Add("@ExaminationType", SqlDbType.VarChar);
            workparameter4.Value = booking.ExaminationType;

            workparameter5 = myCommand.Parameters.Add("@Notes", SqlDbType.VarChar);
            workparameter5.Value = booking.Notes;

            workparameter6 = myCommand.Parameters.Add("@Time", SqlDbType.VarChar);
            workparameter6.Value = booking.Time;

            workparameter7 = myCommand.Parameters.Add("@Rows", SqlDbType.Int);
            workparameter7.Direction = ParameterDirection.Output;

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            int svar = Convert.ToInt32(workparameter7.SqlValue.ToString());

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

            myCommand.Parameters.Add(workparameter2);
            workparameter2.Value = client.FirstName;

            myCommand.Parameters.Add(workparameter3);
            workparameter3.Value = client.LastName;
 

            myCommand.Parameters.Add(workparameter4);
            workparameter4.Value = client.Address;

            myCommand.Parameters.Add(workparameter5);
            workparameter5.Value = client.City;

            myCommand.Parameters.Add(workparameter6);
            workparameter6.Value = client.PostCode;

            myCommand.Parameters.Add(workparameter7);
            workparameter7.Value = client.PhoneNumber;

            myCommand.Parameters.Add(workparameter8);
            workparameter8.Value = client.Email;

            myCommand.Parameters.Add(workparameter9);
            workparameter9.Value = client.DentistID;

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

        public DataTable GetAppointmentList()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spGetAppointmentList";
            adapter.SelectCommand = myCommand;
            adapter.Fill(dt);

            myConnection.Close();
            return dt;
        }

        public DataTable GetAppointmentByPersonalNumber(string bDate)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            myCommand = new SqlCommand();
            workparameter1 = new SqlParameter();
           
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spGetAppointmentByPersonalNumber";
            workparameter1 = myCommand.Parameters.Add("@Personalnumber", SqlDbType.VarChar);
            workparameter1.Value = bDate;

            adapter.SelectCommand = myCommand;
            adapter.Fill(dt);

            myConnection.Close();
            return dt;
        }


        public void getPatientInfo(TextBox txb, TextBox txb2, TextBox txb3, TextBox txtClientID, TextBox txtDentist)
        {
            String conString = myConnection.ConnectionString;
            myConnection = new SqlConnection(conString);
            String procedName = "spGetPatientInfo";
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
                txtDentist.Text = dr["eID"].ToString();
                txtClientID.Text = dr["cID"].ToString();
            }
            else
            {
                txb2.Text = "";
                txb3.Text = "";
                txtDentist.Text = "";
                txtClientID.Text = "";
            }
            myConnection.Close();
        }
    }




}
