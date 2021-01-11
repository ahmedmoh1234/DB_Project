using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Railway_Management_System
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable GetAllEmployees()
        {
            string StoredProcedureName = StoredProcedures.SelectAllEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
          
        }

        public DataTable GetAllTrips()
        {
            string StoredProcedureName = StoredProcedures.SelectAllTrips;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllTrains()
        {
            string StoredProcedureName = StoredProcedures.SelectAllTrains;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllStations()     
        {
            string StoredProcedureName = StoredProcedures.SelectAllStations;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllSuppliers()
        {
            string StoredProcedureName = StoredProcedures.SelectAllSuppliers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllSpareParts()
        {
            string StoredProcedureName = StoredProcedures.SelectAllSpareParts;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int ChangeMaintenanceDay(int Train_Number, DateTime Date)
        {
            string StoredProcedureName = StoredProcedures.ChangeMaintenanceDay;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Train_Number", Train_Number);
            Parameters.Add("@New_Date", Date);
            return dbMan.ExecuteNonQuery(StoredProcedureName,Parameters);

        }

        public int InsertTrip(string trip_date, int PSSN,int tripNo, string status, string type) //payment method?
        {
            string StoredProcedureName = StoredProcedures.InsertTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassengerId",PSSN);
            Parameters.Add("@TripNo",tripNo);
            Parameters.Add("@TripDate",trip_date);
            Parameters.Add("@TypeB_E",type);
            Parameters.Add("@status",status);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        // update trip bete3mel ehh?

        public int Deletetrip(string trip_date, int PSSN, int tripNo)
        {

            string StoredProcedureName = StoredProcedures.CancelTRIP;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassengerId", PSSN);
            Parameters.Add("@TripNo", tripNo);
            Parameters.Add("@TripDate", trip_date);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewPreviousTripinTable(int id)
        {
            string StoredProcedureName = StoredProcedures.ViewpREVIOUSTripsinTable;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassengerId", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int BusinessSeats(string trip_date, int tripNo)
        {

            String query = "SELECT Count(Trip_date)  " +
               "FROM Bookings " +
               "where Type = 'Business' and Trip_Date = '" + trip_date +"' and trip_Number = '"+ tripNo +"'";

            return (int)dbMan.ExecuteScalar(query);
        }

        public int EconomicSeats(string trip_date, int tripNo)
        {

            String query = "SELECT Count(Trip_date)  " +
               "FROM Bookings " +
               "where Type = 'Economic' and Trip_Date = '" + trip_date + "' and trip_Number = " + tripNo + "";

            return (int)dbMan.ExecuteScalar(query);
        }

        public int Hasbooking(int id,string trip_date, int tripNo)
        {

            String query = "SELECT Count(Trip_date)  " +
               "FROM Bookings " +
               "where Status = 'Upcoming' and P_SSN = '" + id + "'";

            return (int)dbMan.ExecuteScalar(query);
        }


        public DataTable ViewpREVIOUSTripsinTextBox(int id, string trip_date, int tripNo)
        {
            string StoredProcedureName = StoredProcedures.ViewpREVIOUSTripsinTextBox;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassengerId", id);
            Parameters.Add("@TripNo", tripNo);
            Parameters.Add("@TripDate", trip_date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable ViewAvailableTrip(TimeSpan time) // benesta3mel el time ezay
        {
            //string StoredProcedureName = StoredProcedures.ViewAllTrips;
            //Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@currenttime", time);
            //return dbMan.ExecuteReader(StoredProcedureName, Parameters);

            String query = "SELECT distinct TRIP.Trip_Number, S1.Station_Name, S2.Station_Name, Departure_Time,Arrival_Time, Business, Business_Ticket_Price, Economic, Economic_Ticket_Price FROM  TRIP, FROM_TO, STATION AS S1, STATION AS S2" +
                " WHERE TRIP.Trip_Number = FROM_TO.Trip_Number AND Station_Number1 = S1.Station_Number AND Station_Number2 = S2.Station_Number AND Departure_Time > = '" + time +"'";

            return dbMan.ExecuteReader(query);
        }


        public DataTable ViewAllstations() // benesta3mel el time ezay
        {
            String query = "SELECT Station_Name " +
                "FROM STATION";

            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewSpecificTrip(TimeSpan time, string to, string from) // benesta3mel el time ezay
        {
            String query = "SELECT distinct TRIP.Trip_Number, S1.Station_Name, S2.Station_Name, Departure_Time,Arrival_Time, Business, Business_Ticket_Price, Economic, Economic_Ticket_Price " +
                "FROM  TRIP, FROM_TO, STATION AS S1, STATION AS S2" +
                " WHERE TRIP.Trip_Number = FROM_TO.Trip_Number AND Station_Number1 = S1.Station_Number AND Station_Number2 = S2.Station_Number AND S1.Station_Name = '"+ from +"' AND S2.Station_Name = '" + to + "' AND Departure_Time > = '" + time + "'";

            return dbMan.ExecuteReader(query);
        }

        public void InsertFeedback(int PSSN, int tripNo, int rating, string comment, string trip_date)
        {
            if (comment.Length > 0)
            {
                string StoredProcedureName = StoredProcedures.INSERTRating_Comment;
                Dictionary<string, object> Parameters = new Dictionary<string, object>();
                Parameters.Add("@PassengerId", PSSN);
                Parameters.Add("@TripNo", tripNo);
                Parameters.Add("@TripDate", trip_date);
                Parameters.Add("@Comment", comment);
                Parameters.Add("@Rating", rating);
                dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
            }
            else
            {
                string StoredProcedureName = StoredProcedures.INSERTrating;
                Dictionary<string, object> Parameters = new Dictionary<string, object>();
                Parameters.Add("@PassengerId", PSSN);
                Parameters.Add("@TripNo", tripNo);
                Parameters.Add("@TripDate", trip_date);
                Parameters.Add("@Rating", rating);
                dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
            }
        }

        public DataTable ViewTrainInfo(int tripNo) // betraga3 ehh
        {
            string StoredProcedureName = StoredProcedures.ViewTrainInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TripNo", tripNo);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable ViewBookedTripInfo(int PassengerId) // betraga3 ehh?  status beta5od values?
        {
            string StoredProcedureName = StoredProcedures.ViewUpcomingTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassengerId", PassengerId);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int ChangeTripType(int PassengerId, string type)
        {
            string StoredProcedureName = StoredProcedures.changeTripType;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassengerId", PassengerId);
            Parameters.Add("@TRIPClassNew", type);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        
    }

}
