using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BayWynCouriers
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //minimize appears when hovered over button//
        private void picBoxMini_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxMini, "Minimize");
        }

        //close appears when hovered over button//
        private void picBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxClose, "Close");
        }

        //closes application when close button clicked//
        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //minimizes application when minimize button clicked//
        private void picBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //hide password appears when hovered over icon//
        private void picBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxHide, "Hide Password");
        }

        //show password appears when hovered over icon//
        private void picBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxShow, "Show Password");
        }

        //when hide icon clicked, will hide the hide icon and show character inside password field, then show the show icon//
        private void picBoxHide_Click(object sender, EventArgs e)
        {
            picBoxHide.Hide();
            txtBoxPass.UseSystemPasswordChar = true;
            picBoxShow.Show();
        }

        //when show icon clicked, will hide show icon and characters inside password field, then show hide icon//
        private void picBoxShow_Click(object sender, EventArgs e)
        {
            picBoxShow.Hide();
            txtBoxPass.UseSystemPasswordChar = false;
            picBoxHide.Show();
        }

        //opens dashboard page when username/password successful//
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUname.Text;
            string password = txtBoxPass.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["BayWyn"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT StaffID, StaffName, Gender, StaffRole FROM Staff WHERE Uname = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())  // If user exists
                    {
                        int courierID = Convert.ToInt32(reader["StaffID"]);  // Get StaffID
                        string StaffName = reader["StaffName"].ToString();
                        string Gender = reader["Gender"].ToString();
                        string StaffRole = reader["StaffRole"].ToString().Trim().ToLower();

                        reader.Close();


                        // Open DashboardForm and pass all required parameters
                        var dashboardForm = new DashboardForm(courierID, StaffName, Gender, StaffRole);
                        dashboardForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                        txtBoxUname.Clear();
                        txtBoxPass.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
