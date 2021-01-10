﻿using System;
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
    public partial class Passenger_Signup : Form
    {
        Controller ControllerObj;
        Form Myparent;
        string Username;
        long SSN;
        public Passenger_Signup(Form p)
        {
            InitializeComponent();
            Myparent = p;
            this.Location = Myparent.Location;
            this.WindowState = Myparent.WindowState;
            Myparent.Hide();
        }
        private void Sign_Up_label_Click(object sender, EventArgs e)
        {
            Passenger_Signup PS = new Passenger_Signup(this);
            PS.Show();
        }

        private void Back_To_login_Click(object sender, EventArgs e)
        {
            this.Close();
            Myparent.Show();
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
            if (Username_Signup_Text.TextLength < 5)
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

        private void Phone_Number_Text_TextChanged(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            Object obj = ValidationClass.isPositiveInteger(Phone_Number_Text.Text, err);
            if (Phone_Number_Text.TextLength != 11 || obj == null)
            {
                X_Phone_Number.Visible = true;
                Error_phone_Number.Visible = true;
            }
            else
            {
                X_Phone_Number.Visible = false;
                Error_phone_Number.Visible = false;

            }
        }


        private void Sign_Up_Click(object sender, EventArgs e)
        {
            if (X_Fname.Visible == true)
            {
                MessageBox.Show("Please enter valid Fname");
                return;
            }
            if (X_Minit.Visible == true)
            {
                MessageBox.Show("Please enter valid Minit");
                return;
            }
            if (X_Lname.Visible == true)
            {
                MessageBox.Show("Please enter valid Lname");
                return;
            }
            if (X_SSN.Visible == true)
            {
                MessageBox.Show("Please enter valid SSN");
                return;
            }
            if (X_Phone_Number.Visible == true)
            {
                MessageBox.Show("Please enter valid Phone Number");
                return;
            }
            if (X_UserName.Visible == true)
            {
                MessageBox.Show("Please enter valid Username");
                return;
            }
            if (X_Password.Visible == true)
            {
                MessageBox.Show("Please enter valid Password");
                return;
            }
            string str_Bdate = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            int result = ControllerObj.SignUp_Passenger(Fname_Text.Text, Minit_Text.Text, Lname_Text.Text, SSN_Text.Text, Phone_Number_Text.Text, Username_Signup_Text.Text, Password_SignUp_Text.Text, comboBox1.Text, str_Bdate);
            if (result == -2)
            {
                MessageBox.Show("SSN already exists");
                return;
            }
            if (result == -1)
            {
                MessageBox.Show("Username already exists");
                return;
            }
            if (result == 0)
            {
                MessageBox.Show("SignUp was unsuccessful");
                return;
            }
            Username = Username_Signup_Text.Text;
            SSN = Convert.ToInt64(SSN_Text.Text);
            // redirect to passenger
            //Temporary
            MessageBox.Show("You signed up");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Myparent.Show();
        }
    }
}