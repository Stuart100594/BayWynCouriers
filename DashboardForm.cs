using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void MovePanel (Control btn)
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

        
    }
}
