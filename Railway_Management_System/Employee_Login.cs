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
        int Station_Number;
        long SSN;
        public Employee_Login(Form p)
        {
            InitializeComponent();
            ControllerObj = new Controller();
            Myparent = p;
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
                Message Msg = new Message(this, "You must enter a Username");
                Msg.Show();
                return;
            }
            if (Password_Text.Text == "")
            {
                MessageBox.Show("You must enter a Password");
                return;
            }
            int result = ControllerObj.Sign_in_Employee(Username_Text.Text, Password_Text.Text);
            if (result == 0)
            {
                MessageBox.Show("Username or Password is incorrect");
                return;
            }
            else
            {
                Username = Username_Text.Text;
                DataTable dt = ControllerObj.Get_Employee_Data(Username_Text.Text);
                SSN = (long)dt.Rows[0].ItemArray[0];
                Station_Number = (int)dt.Rows[0].ItemArray[2];
                if (string.IsNullOrEmpty(dt.Rows[0].ItemArray[1].ToString()) == true) // is A Manager
                {
                    Manager_Form MF = new Manager_Form(this, Station_Number, SSN, Username);
                    MF.Location = this.Location;
                    MF.WindowState = this.WindowState;
                    MF.Size = this.Size;
                    this.Hide();
                    MF.Show();
                }
                else // is A Maintenance
                {
                    Employee_Form EF = new Employee_Form(this, Station_Number, SSN, Username);
                    EF.Location = this.Location;
                    EF.WindowState = this.WindowState;
                    EF.Size = this.Size;
                    this.Hide();
                    EF.Show();
                }


            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Myparent.Location = this.Location;
            Myparent.WindowState = this.WindowState;
            Myparent.Size = this.Size;
            this.Close();
            Myparent.Show();
        }
    }
}
