using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayWynCouriers
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
    using System.Net;

    namespace BayWynCouriers
    {
        public class Clients
        {
            private string connectionString = ConfigurationManager.ConnectionStrings["BayWyn"].ConnectionString;

            //Add Client Method//
            public bool AddClient(string BusinessName, string Address, string PhoneNumber, string Email, string Notes, out int newClientID)
            {
                newClientID = 0; //Default value//
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Clients (BusinessName, Address, PhoneNumber, Email, Notes) " +
                                       "OUTPUT INSERTED.ClientID " +  //Retrieve the new ClientID after insertion//
                                       "VALUES (@BusinessName, @Address, @PhoneNumber, @Email, @Notes)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@BusinessName", BusinessName);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Notes", Notes);

                        connection.Open();
                        object result = command.ExecuteScalar(); // Get the new ClientID
                        if (result != null)
                        {
                            newClientID = Convert.ToInt32(result); // Assign the new ClientID
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding client: " + ex.Message);
                }
                return false;
            }


            
        }
    }

}
