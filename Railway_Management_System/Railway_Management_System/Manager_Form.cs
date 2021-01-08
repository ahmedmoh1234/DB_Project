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
            
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = false;
            SuppliersGroupBox.Visible = false;
            Spare_Parts_GroupBox.Visible = false;
            Statistical_Models_GroupBox.Visible = false;
        }

        private void tripsButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = true;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = false;
            SuppliersGroupBox.Visible = false;
            Spare_Parts_GroupBox.Visible = false;
            Statistical_Models_GroupBox.Visible = false;

            DataTable DT = controllerObj.GetAllTrips();
            TripsDG.DataSource = DT;


        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = true;
            TrainsGroupBox.Visible = false;
            SuppliersGroupBox.Visible = false;
            Spare_Parts_GroupBox.Visible = false;
            Statistical_Models_GroupBox.Visible = false;

            DataTable DT = controllerObj.GetAllEmployees();
            employeesDG.DataSource = DT;

            DT = controllerObj.GetAllStations();
            StationComboBox.DataSource = DT;
            StationComboBox.DisplayMember = "Station_Name";

        }

        private void trainsButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = true;
            SuppliersGroupBox.Visible = false;
            Spare_Parts_GroupBox.Visible = false;
            Statistical_Models_GroupBox.Visible = false;

            DataTable DT = controllerObj.GetAllTrains();
            TrainsDG.DataSource = DT;
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = false;
            SuppliersGroupBox.Visible = true;
            Spare_Parts_GroupBox.Visible = false;
            Statistical_Models_GroupBox.Visible = false;

            DataTable DT = controllerObj.GetAllSuppliers();
            SuppliersDG.DataSource = DT;

        }

        

        private void spare_partsButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = false;
            SuppliersGroupBox.Visible = false;
            Spare_Parts_GroupBox.Visible = true;
            Statistical_Models_GroupBox.Visible = false;

            //ADD REQUESTS IN DATA GRID VIEW            
        }

        private void statistical_modelsButton_Click(object sender, EventArgs e)
        {
            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = false;
            SuppliersGroupBox.Visible = false;
            Spare_Parts_GroupBox.Visible = false;
            Statistical_Models_GroupBox.Visible = true;

            DataTable DT = controllerObj.GetAllStations();
            StationNameComboBox2.DataSource = DT;
            StationNameComboBox2.DisplayMember = "Station_Name";

        }

        private void Change_Date_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
