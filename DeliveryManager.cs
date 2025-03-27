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
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Modify query to optionally include canceled deliveries
                    string query = @"SELECT d.DeliveryID, s.StaffID, s.StaffName, d.DeliveryDate, 
                                    d.DeliveryTime, d.Address, d.Status 
                             FROM Deliveries d
                             INNER JOIN Staff s ON d.StaffID = s.StaffID";

                    if (!includeCancelled)
                    {
                        query += " WHERE d.Status != 'Cancelled'";  // Exclude cancelled if not requested
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving deliveries: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
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
