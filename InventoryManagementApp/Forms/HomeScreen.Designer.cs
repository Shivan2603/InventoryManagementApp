using System;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    partial class HomeScreen
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnManagerLogin;
        private Button btnBillPersonLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnManagerLogin = new Button();
            this.btnBillPersonLogin = new Button();
            this.SuspendLayout();

            // btnManagerLogin
            this.btnManagerLogin.Location = new System.Drawing.Point(50, 50);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(150, 50);
            this.btnManagerLogin.Text = "Manager Login";
            this.btnManagerLogin.UseVisualStyleBackColor = true;
            this.btnManagerLogin.Click += new EventHandler(this.btnManagerLogin_Click);

            // btnBillPersonLogin
            this.btnBillPersonLogin.Location = new System.Drawing.Point(50, 120);
            this.btnBillPersonLogin.Name = "btnBillPersonLogin";
            this.btnBillPersonLogin.Size = new System.Drawing.Size(150, 50);
            this.btnBillPersonLogin.Text = "Bill Person Login";
            this.btnBillPersonLogin.UseVisualStyleBackColor = true;
            this.btnBillPersonLogin.Click += new EventHandler(this.btnBillPersonLogin_Click);

            // HomeScreen Form
            this.ClientSize = new System.Drawing.Size(250, 220);
            this.Controls.Add(this.btnBillPersonLogin);
            this.Controls.Add(this.btnManagerLogin);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
        }
    }
}