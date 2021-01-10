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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
   

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee_Login EL = new Employee_Login(this);
            EL.Location = this.Location;
            EL.WindowState = this.WindowState;
            EL.Size = this.Size;
            this.Hide();
            EL.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Passenger_Click(object sender, EventArgs e)
        {
            Passenger_Login PL = new Passenger_Login(this);
            PL.Location = this.Location;
            PL.WindowState = this.WindowState;
            PL.Size = this.Size;
            this.Hide();
            PL.Show();
        }

        private void Restore_down_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void Minimize_click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

  
    }
}
