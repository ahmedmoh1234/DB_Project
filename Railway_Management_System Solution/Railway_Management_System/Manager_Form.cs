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
        public Manager_Form(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();

            TripsGroupBox.Visible = false;
            EmployeesGroupBox.Visible = false;
            TrainsGroupBox.Visible = false;
            SuppliersGroupBox.Visible = false;
            Spare_Parts_GroupBox.Visible = false;
            Statistical_Models_GroupBox.Visible = false;
            _tripNoRemove = -1;
            HelloMessageLabel.Text = "Hello " + Username;
            HelloMessageLabel.BringToFront();
            //HelloMessageLabel.Top = this.Height / 2 - HelloMessageLabel.Height / 2;
            //HelloMessageLabel.Left = (this.Width - tripsButton.Width) / 2 - HelloMessageLabel.Width+tripsButton.Width;
            HelloMessageLabel.Left = 380;
            HelloMessageLabel.Top = 200;
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
            HelloMessageLabel.Hide();


        }
        private void addTripButton_Click(object sender, EventArgs e)
        {
            if (!inputValidation(trip_number_to_add__TextBox) ||
                !inputValidation(EconomicTicketPriceTextBox) ||
                !inputValidation(BusinessTicketPriceTextBox) ||
                !inputValidation(TrainNumberAddTripTextBox) ||
                !inputValidation(ecoNoTextBox) ||
                !inputValidation(busNoTextBox))
            {
                MessageBox.Show("Please do not leave a field empty");
                return;
            }

            int tripNo;

            TimeSpan depDate = new TimeSpan(depDateTimePicker.Value.Hour,
                depDateTimePicker.Value.Minute, 0);
            string depTime = depDate.ToString(@"hh\:mm");


            TimeSpan arrDate = new TimeSpan(arrDateTimePicker.Value.Hour,
                arrDateTimePicker.Value.Minute, 0);
            string arrTime = arrDate.ToString(@"hh\:mm");

            int ecoPrice;
            int busPrice;
            int trainNo;
            int ecoNo;
            int busNo;

            if (!Int32.TryParse(trip_number_to_add__TextBox.Text, out tripNo))
            {
                MessageBox.Show("Please enter a valid trip number");
                return;
            }


            if (!Int32.TryParse(EconomicTicketPriceTextBox.Text, out ecoPrice))
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

            RequestsDG.DataSource = controllerObj.GetAllRequests();
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

        private void remove_tripButton_Click(object sender, EventArgs e)
        {
            if (_tripNoRemove == -1)
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this trip", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                    tripNoRemoveLabel.Text = "Please select a trip to remove";
                    instructionsLabel.Text = "Select from the table ablove";
                    instructionsLabel.Visible = true;
                    //Adjusting label position
                    tripNoRemoveLabel.Left = ((removeTripGroupBox.Width / 2) - (tripNoRemoveLabel.Width / 2));
                    instructionsLabel.Left = ((removeTripGroupBox.Width / 2) - (instructionsLabel.Width / 2));
                    _tripNoRemove = -1;
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
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

            if (Int32.TryParse(TripsDG.SelectedRows[0].Cells[0].Value.ToString(), out _tripNoRemove))
            {

                instructionsLabel.Visible = false;
                tripNoRemoveLabel.Text = "Trip number : ";


                tripNoRemoveLabel.Text += _tripNoRemove.ToString();

                //Adjusting label position
                tripNoRemoveLabel.Left = ((removeTripGroupBox.Width / 2) - (tripNoRemoveLabel.Width / 2));
            }
            else
            {
                tripNoRemoveLabel.Text = "Please select a trip to remove";
                instructionsLabel.Text = "Select from the table ablove";
                instructionsLabel.Visible = true;
                //Adjusting label position
                tripNoRemoveLabel.Left = ((removeTripGroupBox.Width / 2) - (tripNoRemoveLabel.Width / 2));
                instructionsLabel.Left = ((removeTripGroupBox.Width / 2) - (instructionsLabel.Width / 2));
                _tripNoRemove = -1;
            }
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

        private void Accept_Request_Button_Click(object sender, EventArgs e)
        {
            int Request_ID;
            if (!Int32.TryParse(Request_ID_TextBox.Text, out Request_ID))
            {
                MessageBox.Show("Invalid Request ID");
                return;
            }
            else
            {
                int result = controllerObj.AcceptRequest(Request_ID);
                if (result == 1)
                {
                    MessageBox.Show("Request Accepted Succesfully");
                    return;
                }
                else
                {
                    MessageBox.Show("Request couldn't be Accepted");
                    return;
                }
            }
        }

        private void Reject_Request_Button_Click(object sender, EventArgs e)
        {
            int Request_ID;
            if (!Int32.TryParse(Request_ID_TextBox.Text, out Request_ID))
            {
                MessageBox.Show("Invalid Request ID");
                return;
            }
            else
            {
                int result = controllerObj.RejectRequest(Request_ID);
                if (result == 1)
                {
                    MessageBox.Show("Request Rejected Succesfully");
                    return;
                }
                else
                {
                    MessageBox.Show("Request couldn't be Rejected");
                    return;
                }
            }
        }

        private void GetCountAndSalary_Click(object sender, EventArgs e)
        {
            Number_of_emps_working_station_label.Text = controllerObj.GetEmployeesCount(StationNameComboBox2.Text).ToString();
            Salary_Label.Text = controllerObj.GetAvgSalaryByStation(StationNameComboBox2.Text).ToString();
        }

        private void GetPassCountButton_Click(object sender, EventArgs e)
        {
            PassengerWithMostTripsLabel.Text = controllerObj.GetPassWithMostTrips().ToString();
        }

        private void GetIncomefromTripButton_Click(object sender, EventArgs e)
        {
            int Trip_Number;
            if (!Int32.TryParse(GetIncomeFromTripTextBox.Text, out Trip_Number) || Trip_Number <= 0)
            {
                MessageBox.Show("Invalid Trip Number");
                return;
            }
            IncomeFromTripLabel.Text = controllerObj.GetIncomeTrip(Trip_Number).ToString();
            return;
        }

        private void GeetTrainsCountButton_Click(object sender, EventArgs e)
        {
            int Train_Number;
            if (!Int32.TryParse(TrainNumberTextBox2.Text, out Train_Number) || Train_Number <= 0)
            {
                MessageBox.Show("Invalid Train Number");
                return;
            }
            Number_of_trips_Train_made_label.Text = controllerObj.GetNumberTripsOfTrain(Train_Number).ToString();
        }

        private void CountForCertainTrip_Click(object sender, EventArgs e)
        {
            int Trip_Number;
            if (!Int32.TryParse(CountBooksTrip.Text, out Trip_Number) || Trip_Number <= 0)
            {
                MessageBox.Show("Invalid Trip Number");
                return;
            }
            CountBooksTripLabel.Text = controllerObj.CountBooingsByTrip(Trip_Number).ToString();
        }

        private void GetIncomeTimePeriodButton_Click(object sender, EventArgs e)
        {

            DateTime StartDate, EndDate;
            StartDate = StartDatePicker.Value;
            EndDate = EndDatePicker.Value;
            if (EndDate.CompareTo(StartDate) <= 0)
            {
                MessageBox.Show("End Date cannot be earlier than Start Date");
                return;
            }
            IncomeTimePeriodLabel.Text = controllerObj.GetIncomeTimePeriod(StartDate, EndDate).ToString();

        }
    }
}
