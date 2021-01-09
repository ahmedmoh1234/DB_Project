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
            dbMan.ExecuteNonQuery(StoredProcedureName,Parameters);

        }

        public int OrderSparePart(int Part_No, int amount, int SSN, int requestID)
        {
            string StoredProcedureName = StoredProcedures.OrderSpareParts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RequestID", requestID);
            Parameters.Add("@SSN", SSN);
            Parameters.Add("@Part_No", Part_No);
            Parameters.Add("@Amount", amount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetSparePartsInStation(int stationNo)
        {
            string StoredProcedureName = StoredProcedures.SelectSparePartsInStation;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Station_No", stationNo);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int InsertEmployee(string Fname, string Minit, string Lname, string SSN, string Sex, string DOB, string PhoneNumber, string ManagersSSn, string Station, string Salary, string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.InsertEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@SSN", SSN);
            Parameters.Add("@Sex", Sex);
            Parameters.Add("@DOB", DOB);
            Parameters.Add("@Phone_Number", PhoneNumber);
            Parameters.Add("@Manager_SSN", ManagersSSn);
            Parameters.Add("@Salary", Salary);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateEmployee(string Fname, string Minit, string Lname, string SSN, string Sex, string DOB, string PhoneNumber, string ManagersSSn, string Station, string Salary, string Username, string Password)
        {
            return 0;
        }

        public int GetEmployeeBySSN(int SSN)
        {
            string StoredProcedureName = StoredProcedures.CheckEmployeeBySSN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int RemoveEmployee(int SSN)
        {
            string StoredProcedureName = StoredProcedures.RemoveEployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
    }
}
