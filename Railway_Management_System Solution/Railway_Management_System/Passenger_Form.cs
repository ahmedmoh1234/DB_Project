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

    public partial class Passenger_Form : Form
    {
        Controller controllerObj;
        public Passenger_Form()
        {
            InitializeComponent();
            controllerObj = new Controller();
            Book_TripsGroupBox.Visible = false;
            UpdateTripGroupBox.Visible = false;
            PreviousgroupBox.Visible = false;
            CancelBookgroupBox.Visible = false;
            Upcoming_groupBox.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void Book_Trips_Click(object sender, EventArgs e)
        {
            Book_TripsGroupBox.Visible = true;
            UpdateTripGroupBox.Visible = false;
            PreviousgroupBox.Visible = false;
            CancelBookgroupBox.Visible = false;
            Upcoming_groupBox.Visible = false;

            DataTable dt = controllerObj.GetAllStations();
            Booktrip_From.DataSource = dt;
            DataTable dt1 = controllerObj.GetAllStations();
            Booktrip_From.DisplayMember = "Station_Name";
            Booktrip_to.DataSource = dt1;
            Booktrip_to.DisplayMember = "Station_Name";


        }

        private void Change_Trips_Button_Click_1(object sender, EventArgs e)
        {
            Book_TripsGroupBox.Visible = false;
            PreviousgroupBox.Visible = false;
            CancelBookgroupBox.Visible = false;
            Upcoming_groupBox.Visible = false;
            UpdateTripGroupBox.Visible = true;
            UPdate_Date.Enabled = false;

            DataTable Upcoming = controllerObj.ViewBookedTripInfo(2);
            if (Upcoming != null)
            {
                Update__arrival.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[9]);
                Update_departure.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[8]);
                Update_from.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[18]);
                Update_to.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[23]);
                string Tripdate = Convert.ToString(Upcoming.Rows[0].ItemArray[2]);
                UPdate_Date.Value = Convert.ToDateTime(Tripdate);
                Update_tripNo.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[1]);
                string type = Convert.ToString(Upcoming.Rows[0].ItemArray[3]);
                if (type == "Business")
                {
                    Business_Updatebutton.BackColor = Color.Navy;
                }
                else
                {
                    Economic_Updatebutton.BackColor = Color.Navy;
                }
                string BusinessPrice = Convert.ToString(Upcoming.Rows[0].ItemArray[11]);

                string EconomicPrice = Convert.ToString(Upcoming.Rows[0].ItemArray[10]);

                if (type == "Business")
                {
                    Update_price.Text = BusinessPrice;
                }
                else
                {
                    Update_price.Text = EconomicPrice;
                }
            }
            else
            {
                Book_TripsGroupBox.Visible = false;
                PreviousgroupBox.Visible = false;
                CancelBookgroupBox.Visible = false;
                Upcoming_groupBox.Visible = false;
                UpdateTripGroupBox.Visible = false;
                UPdate_Date.Enabled = false;
                MessageBox.Show("no upcoming trip");
            }

        }

        private void CancelTripsButton_Click(object sender, EventArgs e)
        {
            Book_TripsGroupBox.Visible = false;
            UpdateTripGroupBox.Visible = false;
            PreviousgroupBox.Visible = false;
            CancelBookgroupBox.Visible = true;
            Upcoming_groupBox.Visible = false;

            DataTable Upcoming = controllerObj.ViewBookedTripInfo(2);
            if (Upcoming != null)
            {
                Cancel_ArrivaltextBox.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[9]);
                Cancel_DeparturetextBox.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[8]);
                Cancel_FromtextBox.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[18]);
                Cancel_TotextBox.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[23]);
                string Tripdate = Convert.ToString(Upcoming.Rows[0].ItemArray[2]);
                Cancel_TripDatetextBox.Value = Convert.ToDateTime(Tripdate);
                Cancel_TripNotextBox.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[1]);
                Cancel_TypetextBox.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[3]);

                string BusinessPrice = Convert.ToString(Upcoming.Rows[0].ItemArray[11]);

                string EconomicPrice = Convert.ToString(Upcoming.Rows[0].ItemArray[10]);

                if (Upcoming_Type.Text == "Business")
                {
                    Cancel_PricetextBox.Text = BusinessPrice;
                }
                else
                {
                    Cancel_PricetextBox.Text = EconomicPrice;
                }
            }
            else
            {
                Book_TripsGroupBox.Visible = false;
                PreviousgroupBox.Visible = false;
                CancelBookgroupBox.Visible = false;
                Upcoming_groupBox.Visible = false;
                UpdateTripGroupBox.Visible = false;
                UPdate_Date.Enabled = false;
                MessageBox.Show("no upcoming trip");
            }

        }

        private void Upcoming_Trips_Click_1(object sender, EventArgs e)
        {
            Book_TripsGroupBox.Visible = false;
            UpdateTripGroupBox.Visible = false;
            PreviousgroupBox.Visible = false;
            CancelBookgroupBox.Visible = false;
            Upcoming_groupBox.Visible = true;

            DataTable Upcoming = controllerObj.ViewBookedTripInfo(2);
            if (Upcoming != null)
            {
                Upcoming_Train_No_TextBox.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[14]);
                Upcoming_Arrival.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[9]);
                Upcoming_Departure.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[8]);
                Upcoming_From.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[18]);
                Upcoming_To.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[23]);
                string Tripdate = Convert.ToString(Upcoming.Rows[0].ItemArray[2]);
                Upcoming_Tripdate.Value = Convert.ToDateTime(Tripdate);
                Upcoming_TripNo.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[1]);
                Upcoming_Type.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[3]);

                Upcoming_BusinessPrice.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[11]);
                Upcoming_businessSeatsLeft.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[12]);
                Upcoming_EconomicPrice.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[10]);
                Upcoming_EconomicSeatsLeft.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[13]);
                if (Upcoming_Type.Text == "Business")
                {
                    Upcoming_price.Text = Upcoming_BusinessPrice.Text;
                }
                else
                {
                    Upcoming_price.Text = Upcoming_EconomicPrice.Text;
                }
            }
            else
            {
                Book_TripsGroupBox.Visible = false;
                PreviousgroupBox.Visible = false;
                CancelBookgroupBox.Visible = false;
                Upcoming_groupBox.Visible = false;
                UpdateTripGroupBox.Visible = false;
                UPdate_Date.Enabled = false;
                MessageBox.Show("no upcoming trip");
            }
            //string date = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //Previous_tripDate.Value = Convert.ToDateTime(date);

            //Previous_to_Textbox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //Previous_From_Textbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Previous_Trips_Click_1(object sender, EventArgs e)
        {
            Book_TripsGroupBox.Visible = false;
            UpdateTripGroupBox.Visible = false;
            PreviousgroupBox.Visible = true;
            CancelBookgroupBox.Visible = false;
            Upcoming_groupBox.Visible = false;
            
            DataTable previous = controllerObj.ViewPreviousTripinTable(1);
            dataGridView1.DataSource = previous;
            dataGridView1.Refresh();
            //DataTable previousTextbox = controllerObj.ViewpREVIOUSTripsinTextBox(1, dateprevious, 5);
            
            //Previous_From_Textbox.Text = Convert.ToString(previous.Rows[0].ItemArray[0]);
            //Previous_From_Textbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            
            //DataTable previousTextbox = controllerObj.ViewpREVIOUSTripsinTextBox(1, dateprevious,5);
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
            if (Business_Updatebutton.BackColor == Color.CadetBlue)
            {
                int done = controllerObj.ChangeTripType(2,"Economic");
                if (done == 1)
                {
                    MessageBox.Show("done");
                }
            }
            else
            {
                int done = controllerObj.ChangeTripType(2,"Business");
                if (done == 1)
                {
                    MessageBox.Show("done");
                }
            }
        }

        private void Business_Updatebutton_Click(object sender, EventArgs e)
        {
            Business_Updatebutton.BackColor = Color.Navy;
            Economic_Updatebutton.BackColor = Color.CadetBlue;

            DataTable Upcoming = controllerObj.ViewBookedTripInfo(2);
            if (Upcoming != null)
            {
                string type = "Business";

                string BusinessPrice = Convert.ToString(Upcoming.Rows[0].ItemArray[11]);

                string EconomicPrice = Convert.ToString(Upcoming.Rows[0].ItemArray[10]);

                if (type == "Business")
                {
                    Update_price.Text = BusinessPrice;
                }
                else
                {
                    Update_price.Text = EconomicPrice;
                }
            }
        }

        private void Economic_Updatebutton_Click(object sender, EventArgs e)
        {
            Business_Updatebutton.BackColor = Color.CadetBlue;
            Economic_Updatebutton.BackColor = Color.Navy;

            DataTable Upcoming = controllerObj.ViewBookedTripInfo(2);
            if (Upcoming != null)
            {
                string type = "Economic";
                
                string BusinessPrice = Convert.ToString(Upcoming.Rows[0].ItemArray[11]);

                string EconomicPrice = Convert.ToString(Upcoming.Rows[0].ItemArray[10]);

                if (type == "Business")
                {
                    Update_price.Text = BusinessPrice;
                }
                else
                {
                    Update_price.Text = EconomicPrice;
                }
            }
        }

        private void AddFeedbackButton_Click(object sender, EventArgs e)
        {
            if(RatingCombo.Text.Length>0 )
            {
                string date = Previous_tripDate.Value.ToString("yyyy-MM-dd");
                controllerObj.InsertFeedback(1, Convert.ToInt32(Previous_tripNo.Text),Convert.ToInt32(RatingCombo.Text),CommentTextBox.Text, date);
                DataTable previous = controllerObj.ViewPreviousTripinTable(1);
                dataGridView1.DataSource = previous;
                dataGridView1.Refresh();
                
            }
            
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Previous_tripNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string date = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Previous_tripDate.Value = Convert.ToDateTime(date);

            Previous_to_Textbox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Previous_From_Textbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            DataTable previousTextbox = controllerObj.ViewpREVIOUSTripsinTextBox(1, Previous_tripDate.Value.ToString("yyyy/MM/dd"), Convert.ToInt32(Previous_tripNo.Text));


            Previous_Departure.Text = Convert.ToString(previousTextbox.Rows[0].ItemArray[8]);
            Previous_Arrival.Text = Convert.ToString(previousTextbox.Rows[0].ItemArray[9]);
            Previous_Type.Text = Convert.ToString(previousTextbox.Rows[0].ItemArray[3]);
            if (Previous_Type.Text == "Business")
            {
                Previous_Price.Text = Convert.ToString(previousTextbox.Rows[0].ItemArray[11]);
            }
            else
            {
                Previous_Price.Text = Convert.ToString(previousTextbox.Rows[0].ItemArray[10]);
            }


        }

        private void BookMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Booktrip_TripNoTextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Booktrip_From.Text = scheduleDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Booktrip_to.Text = scheduleDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Booktrip_DeparturetextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Booktrip_ArrivaltextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            if (Booktrip_Businessbutton.BackColor == Color.Navy)
            {
                Booktrip_PriceTextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                Booktrip_SeatsLeftTextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            }
            else if(Booktrip_Economicbutton.BackColor == Color.Navy)
            {
                Booktrip_PriceTextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                Booktrip_SeatsLeftTextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            }
            //string date = scheduleDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            //Previous_tripDate.Value = Convert.ToDateTime(date);

            //Previous_to_Textbox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //Previous_From_Textbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Cancel_ContinueButton_Click(object sender, EventArgs e)
        {
            int done = controllerObj.Deletetrip(Cancel_TripDatetextBox.Value.ToString("yyyy/MM/dd"),2,Convert.ToInt32(Cancel_TripNotextBox.Text));
            if(done == 1)
            { MessageBox.Show("deleted"); }
            Book_TripsGroupBox.Visible = false;
            UpdateTripGroupBox.Visible = false;
            PreviousgroupBox.Visible = false;
            CancelBookgroupBox.Visible = false;
            Upcoming_groupBox.Visible = false;
        }

        private void Cancel_CancelButton_Click(object sender, EventArgs e)
        {
            Book_TripsGroupBox.Visible = false;
            UpdateTripGroupBox.Visible = false;
            PreviousgroupBox.Visible = false;
            CancelBookgroupBox.Visible = false;
            Upcoming_groupBox.Visible = false;
        }

        private void Booktrip_BookButton_Click(object sender, EventArgs e)
        {
            if(controllerObj.Hasbooking(2,Booktrip_TripDate.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(Booktrip_TripNoTextBox.Text)) == 0)
            {
                if (Booktrip_TripNoTextBox.TextLength > 0 && Convert.ToInt32(Booktrip_SeatsLeftTextBox.Text) > 0)
                {
                    if (Booktrip_Businessbutton.BackColor == Color.CadetBlue)
                    {
                        int done = controllerObj.InsertTrip(Booktrip_TripDate.Value.ToString("yyyy-MM-dd"), 2, Convert.ToInt32(Booktrip_TripNoTextBox.Text), "Upcoming", "Economic");
                        if (done == 1)
                        {

                            MessageBox.Show("done");
                            Booktrip_Economicbutton_Click(sender, e);
                        }
                    }
                    else if(Booktrip_Businessbutton.BackColor == Color.Navy)
                    {
                        int done = controllerObj.InsertTrip(Booktrip_TripDate.Value.ToString("yyyy-MM-dd"), 2, Convert.ToInt32(Booktrip_TripNoTextBox.Text), "Upcoming", "Business");
                        if (done == 1)
                        {
                            
                            MessageBox.Show("done");
                            Booktrip_Businessbutton_Click(sender, e);
                        }
                    }
                    

                }
                else
                {
                    MessageBox.Show("Please select any trip");
                }
            }
            else 
            {
                MessageBox.Show("You cant book more than one trip at a time");
            }
        }

        private void Booktrip_Show_All_Available_Tripsbutton_Click(object sender, EventArgs e)
        {
            TimeSpan currenttime = DateTime.Now.TimeOfDay;
            scheduleDataGridView.DataSource = controllerObj.ViewAvailableTrip(currenttime);
            scheduleDataGridView.Refresh();
        }

        private void Booktrip_SearchButton_Click(object sender, EventArgs e)
        {
            TimeSpan currenttime = DateTime.Now.TimeOfDay;
            scheduleDataGridView.DataSource = controllerObj.ViewSpecificTrip(currenttime, Booktrip_From.Text, Booktrip_to.Text);
            scheduleDataGridView.Refresh();
        }

        private void Booktrip_Businessbutton_Click(object sender, EventArgs e)
        {
            if (Booktrip_TripNoTextBox.TextLength > 0)
            {
                int business_seats = controllerObj.BusinessSeats(Booktrip_TripDate.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(Booktrip_TripNoTextBox.Text));

                int totalBusinessSeats = Convert.ToInt32(scheduleDataGridView.SelectedRows[0].Cells[5].Value.ToString());
                Booktrip_Businessbutton.BackColor = Color.Navy;
                Booktrip_Economicbutton.BackColor = Color.CadetBlue;
                Booktrip_PriceTextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                Booktrip_SeatsLeftTextBox.Text = Convert.ToString(totalBusinessSeats - business_seats);
            }
        }

        private void Booktrip_Economicbutton_Click(object sender, EventArgs e)
        {
            if (Booktrip_TripNoTextBox.TextLength > 0)
            {
                int Economic_seats = controllerObj.EconomicSeats(Booktrip_TripDate.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(Booktrip_TripNoTextBox.Text));

                int totalEconomicSeats = Convert.ToInt32(scheduleDataGridView.SelectedRows[0].Cells[7].Value.ToString());
                Booktrip_Businessbutton.BackColor = Color.CadetBlue;
                Booktrip_Economicbutton.BackColor = Color.Navy;
                Booktrip_PriceTextBox.Text = scheduleDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                Booktrip_SeatsLeftTextBox.Text = Convert.ToString(totalEconomicSeats - Economic_seats);
            }
        }

        private void UpdateTrainInfoButton_Click(object sender, EventArgs e)
        {
            DataTable Upcoming = controllerObj.ViewBookedTripInfo(2);
            Upcoming_BusinessPrice.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[11]);
            Upcoming_businessSeatsLeft.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[12]);
            Upcoming_EconomicPrice.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[10]);
            Upcoming_EconomicSeatsLeft.Text = Convert.ToString(Upcoming.Rows[0].ItemArray[13]);
        }


    }
}
