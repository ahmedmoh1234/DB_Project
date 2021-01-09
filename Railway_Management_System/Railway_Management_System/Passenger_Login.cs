using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Management_System
{
    public partial class Passenger_Login : Form
    {
        Form Myparent;
        public Passenger_Login(Form p)
        {
            InitializeComponent();
            Myparent = p;
            this.Location = Myparent.Location;
            this.WindowState = Myparent.WindowState;
            Myparent.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restore_down_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Sign_Up_label_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void Back_To_login_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void Fname_Text_TextChanged(object sender, EventArgs e)
        {
            if (Fname_Text.TextLength == 0)
            {
                X_Fname.Visible = true;
                Error_Fname.Visible = true;
            }
            else
            {
                X_Fname.Visible = false;
                Error_Fname.Visible = false;
            }
        }

        private void Minit_Text_TextChanged(object sender, EventArgs e)
        {
            if (Minit_Text.TextLength == 0 || Minit_Text.TextLength > 1)
            {
                X_Minit.Visible = true;
                Error_Minit.Visible = true;
            }
            else
            {
                X_Minit.Visible = false;
                Error_Minit.Visible = false;

            }
        }

        private void Lname_Text_TextChanged(object sender, EventArgs e)
        {
            if (Lname_Text.TextLength == 0)
            {
                X_Lname.Visible = true;
                Error_Lname.Visible = true;
            }
            else
            {
                X_Lname.Visible = false;
                Error_Lname.Visible = false;

            }
        }

        private void SSN_Text_TextChanged(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            Object obj = ValidationClass.isPositiveInteger(SSN_Text.Text, err);
            if (SSN_Text.TextLength != 14 || obj == null)
            {
                X_SSN.Visible = true;
                Error_SSN.Visible = true;
            }
            else
            {
                X_SSN.Visible = false;
                Error_SSN.Visible = false;

            }
        }

        private void Username_Signup_Text_TextChanged(object sender, EventArgs e)
        {
            if (Username_Signup_Text.TextLength < 5 )
            {
                X_UserName.Visible = true;
                Error_Username.Visible = true;
            }
            else
            {
                X_UserName.Visible = false;
                Error_Username.Visible = false;

            }
        }

        private void Password_SignUp_Text_TextChanged(object sender, EventArgs e)
        {
            if (Password_SignUp_Text.TextLength < 7)
            {
                X_Password.Visible = true;
                Error_Password.Visible = true;
            }
            else
            {
                X_Password.Visible = false;
                Error_Password.Visible = false;

            }
        }
    }
}
