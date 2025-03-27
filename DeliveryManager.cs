using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayWynCouriers
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class DeliveryManager
    {   //database connection string//
        private string connectionString = ConfigurationManager.ConnectionStrings["BayWyn"].ConnectionString;

        // Method to load all active deliveries
        public DataTable GetActiveDeliveries()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT DeliveryID, StaffID, DeliveryDate, DeliveryTime, Address, Status FROM Deliveries WHERE Status <> 'Cancelled'";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading deliveries: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        //cancel delivery method//
        public bool CancelDelivery(int deliveryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {   //changes default 'scheduled' status to 'cancelled' when successful//
                    string query = "UPDATE Deliveries SET Status = 'Cancelled' WHERE DeliveryID = @DeliveryID"; 

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DeliveryID", deliveryID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; //returns true if cancellation was successful//
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling delivery: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
