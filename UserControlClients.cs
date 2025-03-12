using BayWynCouriers.BayWynCouriers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayWynCouriers
{
    public partial class UserControlClients : UserControl
    {
        private Clients clientManager = new Clients(); //Create an instance of the Clients class//

        public UserControlClients()
        {
            InitializeComponent();
        }


        //Add Client Button Click Event//
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string BusinessName = txtBoxBusinessName.Text;
            string Address = txtBoxAddress.Text;
            string PhoneNumber = txtBoxPhoneNo.Text;
            string Email = txtBoxEmail.Text;
            string Notes = txtBoxNotes.Text;

            int newClientID;
            if (clientManager.AddClient(BusinessName, Address, PhoneNumber, Email, Notes, out newClientID))
            {
                MessageBox.Show($"Client added successfully! Assigned ClientID: {newClientID}");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add client.");
            }
        }

        //Clear Input Fields after successful client addition//
        private void ClearFields()
        {
            txtBoxBusinessName.Clear();
            txtBoxAddress.Clear();
            txtBoxPhoneNo.Clear();
            txtBoxEmail.Clear();
            txtBoxNotes.Clear();
        }
    }
}
