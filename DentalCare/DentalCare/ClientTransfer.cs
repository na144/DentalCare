using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DentalCare
{
    class ClientTransfer
    {
        DataTable dt;
        DataTable dt2;
        DBconn dbConn = new DBconn();
        PatientHandling patientHandling = new PatientHandling();


        public string TransferPatient(string personalNumber)
        {
            var tuple = GetTransferPatientInfo(personalNumber);

            WritePatientXmlFile(tuple);

            return "Patient has been transfered and deleted from database";

        }

        public Tuple<DataTable, Client> GetTransferPatientInfo(string personalNumber)
        {
            dt = new DataTable();
            dt = dbConn.GetAppointmentByPersonalNumber(personalNumber);

            dt2 = new DataTable();
            dt2 = dbConn.GetClientForTransfer(personalNumber);

            Client client = patientHandling.getClientObjectFromDT(dt2);

            return Tuple.Create(dt, client);



        }

        public void WritePatientXmlFile(Tuple<DataTable, Client> tuple)
        {
            DataTable dt = tuple.Item1;
            dt.TableName = "appointments";
            Client client = tuple.Item2;

            
                string path = Environment.CurrentDirectory.ToString() + "Transfered Clients";

                using (XmlWriter writer = XmlWriter.Create(client.PersonalNumber + ".xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("PatientForTransfer");

                    writer.WriteStartElement("ClientContactInfo");
                    writer.WriteElementString("ID", client.ClientId.ToString());
                    writer.WriteElementString("PersonalNumber", client.PersonalNumber);
                    writer.WriteElementString("FirsttName", client.FirstName);
                    writer.WriteElementString("LastName", client.LastName);
                    writer.WriteElementString("Address", client.Address);
                    writer.WriteElementString("City", client.City);
                    writer.WriteElementString("Postcode", client.PostCode);
                    writer.WriteElementString("PhoneNumber", client.PhoneNumber);
                    writer.WriteElementString("EmailAddress", client.Email);
                    writer.WriteElementString("Dentist", client.DentistID.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("ClientsDentalHistory");
                    
                    dt.WriteXml(writer);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            
        }
    }
}
