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
        public DataTable GetActiveDeliveries(bool includeCancelled = false)
        {
            string query = "SELECT DeliveryID, StaffID, DeliveryDate, DeliveryTime, Address, Status FROM Deliveries WHERE Status <> 'Completed'";

            if (includeCancelled)
            {
                query = "SELECT DeliveryID, StaffID, DeliveryDate, DeliveryTime, Address, Status FROM Deliveries";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //cancel delivery method//
        public bool CancelDelivery(int deliveryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Deliveries SET Status = 'Cancelled' WHERE DeliveryID = @DeliveryID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DeliveryID", deliveryID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0; // ✅ Returns true if update was successful
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error canceling delivery: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
