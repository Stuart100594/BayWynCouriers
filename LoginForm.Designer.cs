namespace BayWynCouriers
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxUname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxHide = new System.Windows.Forms.PictureBox();
            this.picBoxShow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxMini = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 971);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BayWynCouriers © 2024 - All Rights Reserved";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtBoxPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtBoxUname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picBoxHide);
            this.groupBox1.Controls.Add(this.picBoxShow);
            this.groupBox1.Location = new System.Drawing.Point(292, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 487);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(141, 225);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(296, 30);
            this.txtBoxPass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(226, 279);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 52);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxUname
            // 
            this.txtBoxUname.Location = new System.Drawing.Point(141, 142);
            this.txtBoxUname.Name = "txtBoxUname";
            this.txtBoxUname.Size = new System.Drawing.Size(296, 30);
            this.txtBoxUname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // picBoxHide
            // 
            this.picBoxHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxHide.Image = global::BayWynCouriers.Properties.Resources.eyeClose;
            this.picBoxHide.Location = new System.Drawing.Point(437, 222);
            this.picBoxHide.Name = "picBoxHide";
            this.picBoxHide.Size = new System.Drawing.Size(30, 30);
            this.picBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxHide.TabIndex = 5;
            this.picBoxHide.TabStop = false;
            this.picBoxHide.Click += new System.EventHandler(this.picBoxHide_Click);
            this.picBoxHide.MouseHover += new System.EventHandler(this.picBoxHide_MouseHover);
            // 
            // picBoxShow
            // 
            this.picBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShow.Image = global::BayWynCouriers.Properties.Resources.eyeOpen;
            this.picBoxShow.Location = new System.Drawing.Point(437, 222);
            this.picBoxShow.Name = "picBoxShow";
            this.picBoxShow.Size = new System.Drawing.Size(30, 30);
            this.picBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxShow.TabIndex = 4;
            this.picBoxShow.TabStop = false;
            this.picBoxShow.Click += new System.EventHandler(this.picBoxShow_Click);
            this.picBoxShow.MouseHover += new System.EventHandler(this.picBoxShow_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BayWynCouriers.Properties.Resources.BayWynLogo;
            this.pictureBox1.Location = new System.Drawing.Point(820, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxMini
            // 
            this.picBoxMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMini.Image = global::BayWynCouriers.Properties.Resources.minimise;
            this.picBoxMini.Location = new System.Drawing.Point(1803, 14);
            this.picBoxMini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxMini.Name = "picBoxMini";
            this.picBoxMini.Size = new System.Drawing.Size(50, 50);
            this.picBoxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMini.TabIndex = 3;
            this.picBoxMini.TabStop = false;
            this.picBoxMini.Click += new System.EventHandler(this.picBoxMini_Click);
            this.picBoxMini.MouseHover += new System.EventHandler(this.picBoxMini_MouseHover);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxClose.Image = global::BayWynCouriers.Properties.Resources.close_window;
            this.picBoxClose.Location = new System.Drawing.Point(1861, 14);
            this.picBoxClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(50, 50);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxClose.TabIndex = 2;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.picBoxClose_Click);
            this.picBoxClose.MouseHover += new System.EventHandler(this.picBoxClose_MouseHover);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1924, 1052);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBoxMini);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMini;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBoxShow;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxUname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxHide;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

