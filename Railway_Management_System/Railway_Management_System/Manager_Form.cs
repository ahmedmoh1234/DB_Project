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
    public partial class Manager_Form : Form
    {
        Controller controllerObj;
        public Manager_Form()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable DT = controllerObj.GetAllEmployees();
            employeesDG.DataSource = DT;
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = false;
        }

        private void tripsButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = true;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = false;


        }


        private void employeesButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = true;
            TrainsGroupBox.Visible = false;

        }

        private void trainsButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = true;
        }
    }
}
