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
            this.picBoxMini = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Text = "BayWynCouriers © 2025 - All Rights Reserved";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1924, 1052);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBoxMini);
            this.Controls.Add(this.picBoxClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMini;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

