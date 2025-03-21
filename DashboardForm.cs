using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayWynCouriers
{
    public partial class DashboardForm : Form
    {
        private string StaffRole;

        public DashboardForm(string StaffName, string Gender, string StaffRole)
        {
            InitializeComponent();
            lblUsername.Text = StaffName;
            this.StaffRole = StaffRole.Trim().ToLower();  // Ensure lowercase comparison

            // Display correct avatar based on gender
            string genderLower = Gender.Trim().ToLower();
            picBoy.Visible = genderLower == "male";
            picGirl.Visible = genderLower == "female";

            // Debugging step
            MessageBox.Show($"Staff Role: {this.StaffRole}");


        }

        private void MovePanel(Control btn)
        {
            slideBarPanel.Top = btn.Top;
            slideBarPanel.Height = btn.Height;
        }

        //setting date/time label to real time with approved display format//
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        //items when work once dashboard form loads up//
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panelDeliveriesPage.Hide();
            panelClientsPage.Hide();
            panelReportsPage.Hide();
            panelCouriersPage.Hide();
        }

        //log out button click event//
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                var newForm = new LoginForm();
                newForm.Show();
                this.Close();
            }
        }

        //home button click event//
        private void btnHome_Click(object sender, EventArgs e)
        {
            MovePanel(btnHome);
            panelDeliveriesPage.Hide();
            panelClientsPage.Hide();
            panelReportsPage.Hide();
            panelCouriersPage.Hide();
        }
        //client button click event//
        private void btnClients_Click(object sender, EventArgs e)
        {
            if (StaffRole == "courier")
            {
                MessageBox.Show("Access Denied: Couriers do not have access to the Clients page.", "Restricted Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MovePanel(btnClients);
            panelClientsPage.Show();
            panelDeliveriesPage.Hide();
            panelReportsPage.Hide();
            panelCouriersPage.Hide();
            panelAddClients.Hide();
            panelViewClients.Hide();
            panelEditClients.Hide();
        }
        //delivery button click event//
        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            if (StaffRole == "courier")
            {
                MessageBox.Show("Access Denied: Couriers do not have access to the Deliveries page.", "Restricted Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MovePanel(btnDeliveries);
            panelDeliveriesPage.Show();
            panelClientsPage.Hide();
            panelReportsPage.Hide();
            panelCouriersPage.Hide();
        }
        //reports button click event//
        private void btnReports_Click(object sender, EventArgs e)
        {
            if (StaffRole == "courier")
            {
                MessageBox.Show("Access Denied: Couriers do not have access to the Reports page.", "Restricted Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MovePanel(btnReports);
            panelClientsPage.Hide();
            panelDeliveriesPage.Hide();
            panelReportsPage.Show();
            panelCouriersPage.Hide();
        }
        //couriers button click event//
        private void btnCouriers_Click(object sender, EventArgs e)
        {
            if (StaffRole == "admin" || StaffRole == "logisticscoordinator" || StaffRole == "owner/manager")
            {
                MessageBox.Show("Access Denied: You do not have access to the Couriers page.", "Restricted Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MovePanel(btnCouriers);
            panelClientsPage.Hide();
            panelDeliveriesPage.Hide();
            panelReportsPage.Hide();
            panelCouriersPage.Show();
        }

        //opens add clients panel//
        private void btnAddClients_Click(object sender, EventArgs e)
        {
            panelAddClients.Show();
            panelViewClients.Hide();
            panelEditClients.Hide();
        }

        //opens view clients panel//
        private void btnViewClients_Click(object sender, EventArgs e)
        {
            panelAddClients.Hide();
            panelViewClients.Show();
            panelEditClients.Hide();
        }

        //opens edit clients panel//
        private void btnEditClients_Click(object sender, EventArgs e)
        {
            panelAddClients.Hide();
            panelViewClients.Hide();
            panelEditClients.Show();
        }

        //adding new clients//
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            string businessName = txtBoxBusinessName.Text;
            string address = txtBoxAddress.Text;
            string phoneNumber = txtBoxPhoneNumb.Text;
            string email = txtBoxEmail.Text;
            string notes = txtBoxNotes.Text;

            if (string.IsNullOrEmpty(businessName) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the client is contracted or non-contracted
            if (radioButtonContracted.Checked)
            {
                AddContractedClient(businessName, address, phoneNumber, email, notes);
            }
            else if (radioButtonNonContracted.Checked)
            {
                AddNonContractedClient(businessName, address, phoneNumber, email, notes);
            }
            else
            {
                MessageBox.Show("Please select whether the client is Contracted or Non-Contracted.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to add contracted clients//
        private void AddContractedClient(string businessName, string address, string phoneNumber, string email, string notes)
        {
            // SQL connection string
            string connectionString = ConfigurationManager.ConnectionStrings["BayWyn"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Clients (BusinessName, Address, PhoneNumber, Email, Notes) VALUES (@BusinessName, @Address, @PhoneNumber, @Email, @Notes)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BusinessName", businessName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Notes", notes);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Contracted client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxBusinessName.Clear();
                    txtBoxAddress.Clear();
                    txtBoxPhoneNumb.Clear();
                    txtBoxEmail.Clear();
                    txtBoxNotes.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding contracted client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to add non-contracted client (Courier Job)//
        private void AddNonContractedClient(string businessName, string address, string phoneNumber, string email, string notes)
        {
            // SQL connection string
            string connectionString = ConfigurationManager.ConnectionStrings["BayWyn"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CourierJobs (ClientName, Address, PhoneNumber, Email, Notes) VALUES (@ClientName, @Address, @PhoneNumber, @Email, @Notes)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClientName", businessName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Notes", notes);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Non-contracted client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxBusinessName.Clear();
                    txtBoxAddress.Clear();
                    txtBoxPhoneNumb.Clear();
                    txtBoxEmail.Clear();
                    txtBoxNotes.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding non-contracted client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //clear button on add new client panel//
        private void btnClearNewClient_Click(object sender, EventArgs e)
        {
            txtBoxBusinessName.Clear();
            txtBoxAddress.Clear();
            txtBoxPhoneNumb.Clear();
            txtBoxEmail.Clear();
            txtBoxNotes.Clear();
        }
    }
}
