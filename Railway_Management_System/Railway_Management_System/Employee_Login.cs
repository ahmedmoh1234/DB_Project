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
    public partial class Employee_Login : Form
    {
        Form Myparent;
        Controller ControllerObj;
        string Username;
        long SSN;
        public Employee_Login(Form p)
        {
            InitializeComponent();
            ControllerObj = new Controller();
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

        private void Sign_In_Click(object sender, EventArgs e)
        {
            if (Username_Text.Text == "")
            {
                MessageBox.Show("You must enter a Username");
                return;
            }
            if (Password_Text.Text == "")
            {
                MessageBox.Show("You must enter a Password");
                return;
            }
            int result = ControllerObj.Sign_in_Employee(Username_Text.Text, Password_Text.Text);
                if (result==0)
            {
                MessageBox.Show("Username or Password is incorrect");
                return;
            }
            else
            {
                Username = Username_Text.Text;
                //Redirect to employee
                //temporary
                MessageBox.Show("Signed In successfully");
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Myparent.Show();
        }
    }
}
