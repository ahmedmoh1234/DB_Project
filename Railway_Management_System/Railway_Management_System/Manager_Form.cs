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
            SuppliersDG.Refresh();

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            //depDateTimePicker.Value.

            DateTime dt = new DateTime(2020, 0, 0, 0, 0, 0);
            dt = dt.AddHours(5d);
            dt.AddMinutes(30d);
            //label35.Text = dt.Hour.ToString();

        }

        private void HireButton_Click(object sender, EventArgs e)
        {

            if (FirstNameTextBox.Text == "" || MinitTextBox.Text == "" || LnameTextBox.Text == "" || SSNTextBox.Text == "" || DOB.Text == "" || PhoneNumberTextBox.Text == "" || SalaryTextBox.Text == "" || UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("The insertion of a new Employee failed (Field cannot be empty)");
                return;
            }
            if (!(SexComboBox.Text == "M" || SexComboBox.Text == "m" || SexComboBox.Text == "F" || SexComboBox.Text == "f"))
            {
                MessageBox.Show("The insertion of a new Employee failed (Sex is neither M or F)");
                return;
            }

            int SSN;
            if (!Int32.TryParse(SSNTextBox.Text, out SSN))
            {
                MessageBox.Show("Invalid SSN");
                return;
            }
            if (SSN < 0)
            {
                MessageBox.Show("Invalid SSN");
                return;

            }
            int Salary;
            if (!Int32.TryParse(SalaryTextBox.Text, out Salary))
            {
                MessageBox.Show("Invalid Salary");
                return;
            }
            if (Salary < 0)
            {
                MessageBox.Show("Invalid Salary");
                return;

            }

            string DOBString = DOB.Value.ToString("yyyy/MM/dd");
            int result = controllerObj.InsertEmployee(FirstNameTextBox.Text, MinitTextBox.Text,
                                        LnameTextBox.Text, Int32.Parse(SSNTextBox.Text), SexComboBox.Text, DOBString,
                                        Int32.Parse(PhoneNumberTextBox.Text), Int32.Parse(ManagersSSNTextBox.Text),
                                        StationComboBox.Text,            //Change station
                                        Int32.Parse(SalaryTextBox.Text),
                                        UsernameTextBox.Text, PasswordTextBox.Text);

            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Employee failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
                employeesDG.DataSource = controllerObj.GetAllEmployees();
                employeesDG.Refresh();
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "" || MinitTextBox.Text == "" || LnameTextBox.Text == "" || SSNTextBox.Text == "" || DOB.Text == "" || PhoneNumberTextBox.Text == "" || SalaryTextBox.Text == "" || UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Field cannot be empty");
                return;
            }
            if (!(SexComboBox.Text == "M" || SexComboBox.Text == "m" || SexComboBox.Text == "F" || SexComboBox.Text == "f"))
            {
                MessageBox.Show("Sex must be M or F");
                return;
            }

            int SSN;
            if (!Int32.TryParse(SSNTextBox.Text, out SSN))
            {
                MessageBox.Show("Invalid SSN");
                return;
            }
            if (SSN < 0)
            {
                MessageBox.Show("Invalid SSN");
                return;

            }
            int Salary;
            if (!Int32.TryParse(SalaryTextBox.Text, out Salary))
            {
                MessageBox.Show("Invalid Salary");
                return;
            }
            if (Salary < 0)
            {
                MessageBox.Show("Invalid Salary");
                return;

            }


            int result = controllerObj.UpdateEmployee(FirstNameTextBox.Text, MinitTextBox.Text, LnameTextBox.Text, SSNTextBox.Text, SexComboBox.Text, DOB.Text, PhoneNumberTextBox.Text, ManagersSSNTextBox.Text, StationComboBox.Text, SalaryTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text);


            if (result == 0)
            {
                MessageBox.Show("Failed to update");
            }
            else
            {
                MessageBox.Show("Succesfully updated !");
            }
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            int SSN;
            if (!Int32.TryParse(SSNTextBox.Text, out SSN))
            {
                MessageBox.Show("Invalid SSN");
                return;
            }
            if (SSN < 0)
            {
                MessageBox.Show("Invalid SSN");
                return;

            }
            int result = controllerObj.GetEmployeeBySSN(SSN);
            if (result == 0)
            {
                MessageBox.Show("This employee does not exist");
                return;
            }
            else
            {
                if (controllerObj.RemoveEmployee(SSN) == 1)
                {
                    MessageBox.Show("Employee Fired");
                    DataTable DT = controllerObj.GetAllEmployees();
                    employeesDG.DataSource = DT;
                    employeesDG.Refresh();
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to fire");
                    return;
                }


            }

        }
    }
}
