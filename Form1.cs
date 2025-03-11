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
    }
}
