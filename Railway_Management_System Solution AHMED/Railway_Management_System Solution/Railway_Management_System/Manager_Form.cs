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
            string New_Date = New_Maintenance_Date.Value.ToString("yyyy/MM/dd");
            int Train_Number;
            if (!Int32.TryParse(TrainNumberTextBox.Text, out Train_Number))
            {
                MessageBox.Show("Invalid Train Number");
                return;
            }
            else
            {

                int result = controllerObj.ChangeMaintenanceDate(Train_Number, New_Date);
                if (result == 0)
                {
                    MessageBox.Show("Failed to update Maintenance Date");
                    return;
                }
                else
                {
                    TrainsDG.DataSource = controllerObj.GetAllTrains();
                    TrainsDG.Refresh();
                    MessageBox.Show("Updated Maintenance Date");
                    return;
                }

            }
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
                MessageBox.Show("Field cannot be empty");
                return;
            }
            if (!(SexComboBox.Text == "M" || SexComboBox.Text == "m" || SexComboBox.Text == "F" || SexComboBox.Text == "f"))
            {
                MessageBox.Show("Sex must be either M or F");
                return;
            }

            long SSN;
            if (!long.TryParse(SSNTextBox.Text, out SSN))
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

            long Phone_Number;
            if (!long.TryParse(PhoneNumberTextBox.Text, out Phone_Number))
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }
            if (Phone_Number < 0)
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }

            if (!controllerObj.CheckUserName(UsernameTextBox.Text))
            {
                MessageBox.Show("Username is already taken");
                return;
            }

            int ManagerSSN;
            if (ManagersSSNTextBox.Text == "")
            {
                ManagerSSN = -1;
                int StationNumber = controllerObj.GetStationNumberFromName(StationComboBox.Text);
                string DOBString = DOB.Value.ToString("yyyy/MM/dd");
                int result = controllerObj.InsertEmployee(FirstNameTextBox.Text, MinitTextBox.Text,
                                            LnameTextBox.Text, Int32.Parse(SSNTextBox.Text), SexComboBox.Text, DOBString,
                                            Int32.Parse(PhoneNumberTextBox.Text), ManagerSSN,
                                            StationNumber, Int32.Parse(SalaryTextBox.Text),
                                            UsernameTextBox.Text, PasswordTextBox.Text);

                if (result == 0)
                {
                    MessageBox.Show("The insertion of a new Employee failed");
                    return;
                }
                else
                {
                    MessageBox.Show("The employee is hired succesfully !");
                    employeesDG.DataSource = controllerObj.GetAllEmployees();
                    employeesDG.Refresh();
                    return;
                }
            }
            if (!Int32.TryParse(ManagersSSNTextBox.Text, out ManagerSSN))
            {
                MessageBox.Show("Invalid Manager's SSN");
                return;
            }
            if (ManagerSSN < 0)
            {
                MessageBox.Show("Invalid Manager's SSN");
                return;
            }
            else
            {
                int StationNumber = controllerObj.GetStationNumberFromName(StationComboBox.Text);
                string DOBString = DOB.Value.ToString("yyyy/MM/dd");
                int result = controllerObj.InsertEmployee(FirstNameTextBox.Text, MinitTextBox.Text,
                                            LnameTextBox.Text, Int32.Parse(SSNTextBox.Text), SexComboBox.Text, DOBString,
                                            Int32.Parse(PhoneNumberTextBox.Text), Int32.Parse(ManagersSSNTextBox.Text),
                                            StationNumber, Int32.Parse(SalaryTextBox.Text),
                                            UsernameTextBox.Text, PasswordTextBox.Text);

                if (result == 0)
                {
                    MessageBox.Show("The insertion of a new Employee failed");
                }
                else
                {
                    MessageBox.Show("The employee is hired succesfully !");
                    employeesDG.DataSource = controllerObj.GetAllEmployees();
                    employeesDG.Refresh();
                }
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
                MessageBox.Show("Sex must be either M or F");
                return;
            }

            long SSN;
            if (!long.TryParse(SSNTextBox.Text, out SSN))
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

            long Phone_Number;
            if (!long.TryParse(PhoneNumberTextBox.Text, out Phone_Number))
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }
            if (Phone_Number < 0)
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }

            int ManagerSSN;
            if (ManagersSSNTextBox.Text == "")
            {
                ManagerSSN = -1;
                int StationNumber = controllerObj.GetStationNumberFromName(StationComboBox.Text);
                string DOBString = DOB.Value.ToString("yyyy/MM/dd");
                int result = controllerObj.UpdateEmployee(FirstNameTextBox.Text, MinitTextBox.Text,
                                            LnameTextBox.Text, Int32.Parse(SSNTextBox.Text), SexComboBox.Text, DOBString,
                                            Int32.Parse(PhoneNumberTextBox.Text), ManagerSSN,
                                            StationNumber, Int32.Parse(SalaryTextBox.Text),
                                            UsernameTextBox.Text, PasswordTextBox.Text);

                if (result == 0)
                {
                    MessageBox.Show("Update failed");
                    return;
                }
                else
                {
                    MessageBox.Show("The employee's data is updated succesfully !");
                    employeesDG.DataSource = controllerObj.GetAllEmployees();
                    employeesDG.Refresh();
                    return;
                }
            }
            if (!Int32.TryParse(ManagersSSNTextBox.Text, out ManagerSSN))
            {
                MessageBox.Show("Invalid Manager's SSN");
                return;
            }
            if (ManagerSSN < 0)
            {
                MessageBox.Show("Invalid Manager's SSN");
                return;
            }
            else
            {
                int StationNumber = controllerObj.GetStationNumberFromName(StationComboBox.Text);
                string DOBString = DOB.Value.ToString("yyyy/MM/dd");
                int result = controllerObj.UpdateEmployee(FirstNameTextBox.Text, MinitTextBox.Text,
                                            LnameTextBox.Text, Int32.Parse(SSNTextBox.Text), SexComboBox.Text, DOBString,
                                            Int32.Parse(PhoneNumberTextBox.Text), Int32.Parse(ManagersSSNTextBox.Text),
                                            StationNumber, Int32.Parse(SalaryTextBox.Text),
                                            UsernameTextBox.Text, PasswordTextBox.Text);

                if (result == 0)
                {
                    MessageBox.Show("Update failed");
                    return;
                }
                else
                {
                    MessageBox.Show("The employee's data is updated succesfully !");
                    employeesDG.DataSource = controllerObj.GetAllEmployees();
                    employeesDG.Refresh();
                }
            }
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            long SSN;
            if (!long.TryParse(SSNTextBox.Text, out SSN))
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


        private void RowHeaderMouseClick_Employees(object sender, DataGridViewCellMouseEventArgs e)
        {
            FirstNameTextBox.Text = employeesDG.SelectedRows[0].Cells[0].Value.ToString();
            MinitTextBox.Text = employeesDG.SelectedRows[0].Cells[1].Value.ToString();
            LnameTextBox.Text = employeesDG.SelectedRows[0].Cells[2].Value.ToString();
            SSNTextBox.Text = employeesDG.SelectedRows[0].Cells[3].Value.ToString();
            SexComboBox.Text = employeesDG.SelectedRows[0].Cells[4].Value.ToString();
            PhoneNumberTextBox.Text = employeesDG.SelectedRows[0].Cells[5].Value.ToString();
            SalaryTextBox.Text = employeesDG.SelectedRows[0].Cells[6].Value.ToString();
            //DOB
            ManagersSSNTextBox.Text = employeesDG.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void RowHeaderMouseClick_Trains(object sender, DataGridViewCellMouseEventArgs e)
        {
            TrainNumberTextBox.Text = TrainsDG.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void RowHeaderMouseClick_Suppliers(object sender, DataGridViewCellMouseEventArgs e)
        {
            Supplier_Number_TextBox.Text = SuppliersDG.SelectedRows[0].Cells[0].Value.ToString();
            SupplierNameTextBox.Text = SuppliersDG.SelectedRows[0].Cells[1].Value.ToString();
            SupplierAddressTextBox.Text = SuppliersDG.SelectedRows[0].Cells[2].Value.ToString();
            SupplierPhoneNumberTextBox.Text = SuppliersDG.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Add_Supplier_Button_Click(object sender, EventArgs e)
        {
            int SupplierNumber;
            long SupplierPhoneNumber;
            if (!Int32.TryParse(Supplier_Number_TextBox.Text, out SupplierNumber))
            {
                MessageBox.Show("Invalid Supplier Number");
                return;
            }
            if (!long.TryParse(SupplierPhoneNumberTextBox.Text, out SupplierPhoneNumber))
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }
            if (SupplierNameTextBox.Text == "" || SupplierAddressTextBox.Text == "")
            {
                MessageBox.Show("Field cannot be empty");
                return;
            }
            int result = controllerObj.AddSupplier(SupplierNumber, SupplierAddressTextBox.Text,
                                                    SupplierNameTextBox.Text, SupplierPhoneNumber);
            if (result == 0)
            {
                MessageBox.Show("Failed to Add Supplier");
                return;
            }
            else
            {
                DataTable DT = controllerObj.GetAllSuppliers();
                SuppliersDG.DataSource = DT;
                SuppliersDG.Refresh();
                MessageBox.Show("Supplier Added succesfully");
                return;
            }

        }

        private void Remove_Supplier_Button_Click(object sender, EventArgs e)
        {
            int SupplierNumber;
            if (!Int32.TryParse(Supplier_Number_TextBox.Text, out SupplierNumber))
            {
                MessageBox.Show("Invalid Supplier Number");
                return;
            }
            else
            {
                int result = controllerObj.RemoveSupplier(SupplierNumber);
                if (result == 0)
                {
                    MessageBox.Show("Failed to Remove Supplier");
                    return;
                }
                else
                {
                    DataTable DT = controllerObj.GetAllSuppliers();
                    SuppliersDG.DataSource = DT;
                    SuppliersDG.Refresh();
                    MessageBox.Show("Supplier Removed Succesfully");
                    return;
                }

            }

        }
    }
}
