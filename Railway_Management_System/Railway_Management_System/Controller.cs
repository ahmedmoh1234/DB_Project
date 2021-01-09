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

        public void ChangeMaintenanceDay(int Train_Number, DateTime Date)
        {
            string StoredProcedureName = StoredProcedures.ChangeMaintenanceDay;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Train_Number", Train_Number);
            Parameters.Add("@New_Date", Date);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int Sign_in_Employee(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.Check_Login_Employee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);

            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
           

        public int Sign_in_Passenger(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.Check_Login_Passenger;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);

            return (int) dbMan.ExecuteScalar(StoredProcedureName, Parameters);
          
        }

        public int SignUp_Passenger(string Fname, string Minit, string Lname, string SSN, string Phone_Number, string Username, string Password, string gender, string DOB)
        {
            string StoredProcedureName = StoredProcedures.Check_SSN_SignUp_Passenger;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            int Check_SSN = (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            if (Check_SSN == 1)
                return -2;

            StoredProcedureName = StoredProcedures.Check_Username_SignUp_Passenger;
            Dictionary<string, object> Parameters2 = new Dictionary<string, object>();
            Parameters2.Add("@username", Username);
            int Check_Username = (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters2);
            if (Check_Username == 1)
                return -1;

            StoredProcedureName = StoredProcedures.SignUp_Passenger;
            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();
            Parameters3.Add("@Fname", Fname);
            Parameters3.Add("@Minit", Minit);
            Parameters3.Add("@Lname", Lname);
            Parameters3.Add("@Phone_Number", Phone_Number);
            Parameters3.Add("@SSN", SSN);
            Parameters3.Add("@gender", gender);
            Parameters3.Add("@DOB", DOB);
            Parameters3.Add("@Username", Username);
            Parameters3.Add("@Password", Password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters3);

        }
    }
}
