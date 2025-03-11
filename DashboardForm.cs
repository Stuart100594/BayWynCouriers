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
        

        public DashboardForm(string StaffName, string Gender)
        {
            InitializeComponent();
            lblUsername.Text = StaffName;

            // Ensure gender check is case-insensitive//
            string genderLower = Gender.Trim().ToLower();

            // Show or hide the correct avatar based on gender//
            if (genderLower == "male")
            {
                picBoy.Visible = true;
                picGirl.Visible = false;
            }
            else if (genderLower == "female")
            {
                picBoy.Visible = false;
                picGirl.Visible = true;
            }
            else
            {
                picBoy.Visible = false;
                picGirl.Visible = false; // Hide both if gender is unspecified//
            }
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
            MovePanel(btnClients);
            panelClientsPage.Show();
            panelDeliveriesPage.Hide();
            panelReportsPage.Hide();
            panelCouriersPage.Hide();
        }
        //delivery button click event//
        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            MovePanel(btnDeliveries);
            panelDeliveriesPage.Show();
            panelClientsPage.Hide();
            panelReportsPage.Hide();
            panelCouriersPage.Hide();
        }
        //reports button click event//
        private void btnReports_Click(object sender, EventArgs e)
        {
            MovePanel(btnReports);
            panelClientsPage.Hide();
            panelDeliveriesPage.Hide();
            panelReportsPage.Show();
            panelCouriersPage.Hide();
        }
        //couriers button click event//
        private void btnCouriers_Click(object sender, EventArgs e)
        {
            MovePanel(btnCouriers);
            panelClientsPage.Hide();
            panelDeliveriesPage.Hide();
            panelReportsPage.Hide();
            panelCouriersPage.Show();
        }

        
    }
}
