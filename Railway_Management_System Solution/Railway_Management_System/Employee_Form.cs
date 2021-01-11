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
    public partial class Employee_Form : Form
    {
        Controller controller;
        private int _partNo;
        private int _empStationNo;
        private long _empSSN;
        private string _Username;
        //public Employee_Form(string Username)
        //{
        //    InitializeComponent();
        //    controller = new Controller();
        //    _empStationNo = 5;
        //    _empSSN = 12345678;
        //    _Username = Username;
        //}

        public Employee_Form(int empSatationNo, long empSSN, string Username)
        {
            InitializeComponent();
            controller = new Controller();
            _empStationNo = empSatationNo;
            _empSSN = empSSN;
            _Username = Username;

        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            sparePartsGroupBox.Visible = true;
            fillTable();
        }



        private void sparePartsButton_Click(object sender, EventArgs e)
        {
            if (sparePartsGroupBox.Visible == false)
                sparePartsGroupBox.Visible = true;

            if (scheduleGroupBox.Visible == true)
                scheduleGroupBox.Visible = false;

            sparePartDataGridView.DataSource = controller.GetSparePartsInStation(_empStationNo);
            sparePartDataGridView.Refresh();

        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            if (sparePartsGroupBox.Visible == true)
                sparePartsGroupBox.Visible = false;

            if (scheduleGroupBox.Visible == false)
                scheduleGroupBox.Visible = true;

            scheduleDataGridView.DataSource = controller.GetAllTrains();
            scheduleDataGridView.Refresh();
        }



        private void orderButton_Click(object sender, EventArgs e)
        {
            //get requestID from the INVENTORY Table
            int requestID;
            DataTable dt = controller.GetAllRequests();
            if (dt == null)
            {
                requestID = 1;
            }
            else
            {
                requestID = dt.Rows[dt.Rows.Count - 1].Field<int>("Request_ID");
                requestID++;
            }


            //check if part number is not selected
            if (!inputValidation(orderAmountTextBox))
            {
                return;
            }


            int orderAmount;
            if (Int32.TryParse(orderAmountTextBox.Text, out orderAmount))
            {
                if (orderAmount <= 0)
                {
                    MessageBox.Show("Please enter a number bigger than zero");
                    return;
                }

                if (controller.OrderSparePart(_partNo, orderAmount, _empSSN, requestID) == 0)
                    MessageBox.Show("Order failed");
                else
                    MessageBox.Show("Spare Part has been ordered");
            }
            else
            {
                MessageBox.Show("Please enter a valid number in the textbox");
                return;
            }

            fillTable();
        }

        private void decrementButton_Click(object sender, EventArgs e)
        {
            //must select a spare part from datagridview and must enter a number
            // in the textbox
            if (!inputValidation(decAmountTextBox))
            {
                return;
            }

            //Getting the decrement amount from the textbox
            int decAmount;
            if (!Int32.TryParse(decAmountTextBox.Text, out decAmount))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }

            if (decAmount <= 0)
            {
                MessageBox.Show("Please enter a number bigger than zero");
                return;
            }

            //Get amount from database
            int currentAmount = (int)sparePartDataGridView.SelectedRows[0].Cells[1].Value;
            if (currentAmount - decAmount < 0)
            {
                MessageBox.Show("Decrement amount is bigger than current amount", "Error");
                return;
            }

            if (controller.DecSparePart(_empStationNo, _partNo, decAmount) == 0)
            {
                MessageBox.Show("Spare part decrement failed");
            }
            else
            {
                MessageBox.Show("Spare part decrement succeeded");
            }

            fillTable();
        }


        private void sparePartDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //changing part no to be ordered or decremented
            _partNo = Int32.Parse(sparePartDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            //Changing label text
            orderPartNoLabel.Text = "Part Number : ";
            orderPartNoLabel.Text += _partNo.ToString();

            decLabel.Text = "Part Number : ";
            decLabel.Text += _partNo.ToString();

            //Adjusting label position
            orderPartNoLabel.Left = ((orderGroupBox.Width / 2) - (orderPartNoLabel.Width / 2));
            decLabel.Left = ((decGroupBox.Width / 2) - (decLabel.Width / 2));
        }
        private bool inputValidation(TextBox tb)
        {
            if (sparePartDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a spare part row from the table");
                return false;
            }


            if (ValidationClass.isTextboxEmpty(tb))
            {
                //if true, then textbox is empty
                MessageBox.Show("Please enter a number in the amount textbox");
                return false;
            }
            return true;
        }

        private void fillTable()
        {
            sparePartDataGridView.DataSource = controller.GetSparePartsInStation(_empStationNo);
            sparePartDataGridView.Refresh();
        }

        private void changeDateButton_Click(object sender, EventArgs e)
        {
            string New_Date = maintenanceDateTimePicker.Value.ToString("yyyy/MM/dd");
            int Train_Number;
            if (!Int32.TryParse(TrainNumberTextBox.Text, out Train_Number))
            {
                MessageBox.Show("Invalid Train Number");
                return;
            }
            else
            {

                int result = controller.ChangeMaintenanceDate(Train_Number, New_Date);
                if (result == 0)
                {
                    MessageBox.Show("Failed to update Maintenance Date");
                    return;
                }
                else
                {
                    scheduleDataGridView.DataSource = controller.GetAllTrains();
                    scheduleDataGridView.Refresh();
                    MessageBox.Show("Updated Maintenance Date");
                    return;
                }
            }
        }

        private void scheduleDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TrainNumberTextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
