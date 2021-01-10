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
        int _tripNoRemove;
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

            fillTable_Trips();


        }
        private void addTripButton_Click(object sender, EventArgs e)
        {
            if ( !inputValidation(trip_number_to_add__TextBox) ||
                !inputValidation(EconomicTicketPriceTextBox) ||
                !inputValidation(BusinessTicketPriceTextBox) ||
                !inputValidation(TrainNumberAddTripTextBox)  ||
                !inputValidation(ecoNoTextBox) ||
                !inputValidation(busNoTextBox) )
            {
                MessageBox.Show("Please do not leave a field empty");
                return;
            }

            int tripNo;
            
            TimeSpan depDate = new TimeSpan(depDateTimePicker.Value.Hour,
                depDateTimePicker.Value.Minute, 0);
            string depTime =   depDate.ToString(@"hh\:mm") ;


            TimeSpan arrDate = new TimeSpan(arrDateTimePicker.Value.Hour,
                arrDateTimePicker.Value.Minute, 0);
            string arrTime =  arrDate.ToString(@"hh\:mm") ;

            int ecoPrice;
            int busPrice;
            int trainNo;
            int ecoNo;
            int busNo;

            if ( !Int32.TryParse(trip_number_to_add__TextBox.Text,out tripNo) )
            {
                MessageBox.Show("Please enter a valid trip number");
                return;
            }


            if( !Int32.TryParse(EconomicTicketPriceTextBox.Text, out ecoPrice) )
            {
                MessageBox.Show("Please enter a valid economic ticket price");
                return;
            }

            if (!Int32.TryParse(BusinessTicketPriceTextBox.Text, out busPrice))
            {
                MessageBox.Show("Please enter a valid business ticket price");
                return;
            }

            if (!Int32.TryParse(TrainNumberAddTripTextBox.Text, out trainNo))
            {
                MessageBox.Show("Please enter a valid train number");
                return;
            }

            if (!Int32.TryParse(ecoNoTextBox.Text, out ecoNo))
            {
                MessageBox.Show("Please enter a valid economic seats number");
                return;
            }

            if (!Int32.TryParse(busNoTextBox.Text, out busNo))
            {
                MessageBox.Show("Please enter a valid business seats number");
                return;
            }

            if (tripNo < 0 || ecoPrice < 0 || busPrice < 0 || trainNo < 0 || ecoNo < 0 || busNo < 0)
            {
                MessageBox.Show("Please enter positive numbers");
                return;
            }

            if (controllerObj.InsertTrip(tripNo, depTime, arrTime, ecoPrice, busPrice, busNo, ecoNo, trainNo) == 0)
            {
                MessageBox.Show("Insertion of trip failed");
                return;
            }

            MessageBox.Show("Insertion was successful");
            fillTable_Trips();
            return;
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

        private void remove_tripButton_Click(object sender, EventArgs e)
        {
            if (TripsDG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this trip", "Delete", MessageBoxButtons.YesNo);
            if ( dialogResult == DialogResult.Yes )
            {
                if (controllerObj.RemoveTrip(_tripNoRemove) == 0)
                {
                    MessageBox.Show("Remove failed");
                    return;
                }
                else
                {
                    MessageBox.Show("Remove was successful");
                    fillTable_Trips();
                    return;
                }
            }
            else if ( dialogResult == DialogResult.No )
            {
                return;
            }

            
        }










        private bool inputValidation(TextBox tb)
        {
            //if (dg.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Please select a spare part row from the table");
            //    return false;
            //}


            if (ValidationClass.isTextboxEmpty(tb))
            {
                //if true, then textbox is empty
                //MessageBox.Show("Please enter a number in the amount textbox");
                return false;
            }
            return true;
        }

        private void fillTable_Trips()
        {
            TripsDG.DataSource = controllerObj.GetAllTrips();
            TripsDG.Refresh();
        }

        private void TripsDG_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            instructionsLabel.Visible = false;
            tripNoRemoveLabel.Text = "Trip number : ";


            _tripNoRemove = Int32.Parse(TripsDG.SelectedRows[0].Cells[0].Value.ToString());

            tripNoRemoveLabel.Text += _tripNoRemove.ToString();

            //Adjusting label position
            tripNoRemoveLabel.Left = ((removeTripGroupBox.Width / 2) - (tripNoRemoveLabel.Width / 2));
            

        }
    }
}
