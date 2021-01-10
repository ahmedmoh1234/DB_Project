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

        public int OrderSparePart(int Part_No, int amount, long SSN, int requestID)
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

        public int InsertEmployee(string Fname, string Minit, string Lname, long SSN, string Sex,
                        string DOB, long PhoneNumber, int ManagersSSn, int Station_Number,
                        int Salary, string Username, string Password)
        {

            if (ManagersSSn == -1)
            {
                string query = "INSERT INTO EMPLOYEE " +
                    "VALUES ('" + Fname + "', '" + Minit + "', '" + Lname + "', " +
                    SSN.ToString() + ", '" + Sex + "', '" + PhoneNumber.ToString() + "', " + Salary.ToString() +
                    ", '" + DOB + "', NULL,  " + Station_Number.ToString() + ");";
                int result1 = dbMan.ExecuteNonQuery(query);

                string query2 = "INSERT INTO LOGIN_EMPLOYEE " +
                    "VALUES (" + SSN.ToString() + ", '" + Username + "', '" + Password + "');";
                int result2 = dbMan.ExecuteNonQuery(query2);
                return result1 * result2;


            }
            else
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
                Parameters.Add("@Station_Number", Station_Number);

                int result = dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
                string query2 = "INSERT INTO LOGIN_EMPLOYEE " +
                        "VALUES (" + SSN.ToString() + ", '" + Username + "', '" + Password + "');";
                dbMan.ExecuteReader(query2);
                return result;
            }
        }
        public int UpdateEmployee(string Fname, string Minit, string Lname, long SSN, string Sex,
                        string DOB, long PhoneNumber, int ManagersSSN, int Station_Number,
                        int Salary, string Username, string Password)
        {

            if (ManagersSSN == -1)
            {
                string query = "UPDATE EMPLOYEE SET Fname = '" + Fname + "', " +
                    "Minit = '" + Minit + "', Lname = '" + Lname + "'," +
                    "Sex = '" + Sex + "', Phone_Number = " + PhoneNumber.ToString() + ", Salary = " + Salary.ToString() + "," +
                    "DOB = '" + DOB + "', Manager_SSN = NULL, Station_Number = " + Station_Number + " " +
                    "WHERE E_SSN = " + SSN.ToString() + ";";

                int result1 = dbMan.ExecuteNonQuery(query);

                string query2 = "UPDATE LOGIN_EMPLOYEE SET Password = '" + Password + "' " +
                    "WHERE Username = '" + Username + "';";
                int result2 = dbMan.ExecuteNonQuery(query2);
                return result1 * result2;

            }
            else
            {
                string query = "UPDATE EMPLOYEE SET Fname = '" + Fname + "', " +
                     "Minit = '" + Minit + "', Lname = '" + Lname + "'," +
                     "Sex = '" + Sex + "', Phone_Number = " + PhoneNumber.ToString() + ", Salary = " + Salary.ToString() + "," +
                     "DOB = '" + DOB + "', Manager_SSN = " + ManagersSSN.ToString() + ", Station_Number = " + Station_Number + " " +
                     "WHERE E_SSN = " + SSN.ToString() + ";";

                int result1 = dbMan.ExecuteNonQuery(query);

                string query2 = "UPDATE LOGIN_EMPLOYEE SET Password = '" + Password + "' " +
                    "WHERE Username = '" + Username + "';";
                int result2 = dbMan.ExecuteNonQuery(query2);
                return result1 * result2;
            }
        }

        public DataTable GetAllRequests()
        {
            string StoredProcedureName = StoredProcedures.SelectAllRequest;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int DecSparePart(int stationNo, int partNo, int amount)
        {
            string StoredProcedureName = StoredProcedures.DecSparePart;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Station_No", stationNo);
            Parameters.Add("@Part_No", partNo);
            Parameters.Add("@Amount", amount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int RemoveTrip(int tripNo)
        {
            string StoredProcedureName = StoredProcedures.RemoveTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Trip_Num", tripNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertTrip (int tripNo, string depTime, string arrTime, int ecoPrice, int busPrice,
            int busNo, int ecoNo, int trainNo)
        {
            string StoredProcedureName = StoredProcedures.AddTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Trip_Num", tripNo);
            Parameters.Add("@Deprt_Time", depTime);
            Parameters.Add("@Arr_Time", arrTime);
            Parameters.Add("@Eco_Ticket_Price", ecoPrice);
            Parameters.Add("@Buss_Ticket_Price", busPrice);
            Parameters.Add("@Buss_No", busNo);
            Parameters.Add("@Eco_No", ecoNo);
            Parameters.Add("@Train_No", trainNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int GetEmployeeBySSN(long SSN)
        {
            string StoredProcedureName = StoredProcedures.CheckEmployeeBySSN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int RemoveEmployee(long SSN)
        {
            string query = "DELETE FROM LOGIN_EMPLOYEE " +
               "WHERE E_SSN = '" + SSN.ToString() + "';";
            int result1 = dbMan.ExecuteNonQuery(query);
            string StoredProcedureName = StoredProcedures.RemoveEployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            int result2 = dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
            return result1 * result2;

        }

        public int GetStationNumberFromName(string StationName)
        {
            string query = "SELECT Station_Number " +
                "FROM STATION " +
                "WHERE Station_Name = '" + StationName + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public bool CheckUserName(string Username)
        {
            string query = "SELECT * FROM LOGIN_EMPLOYEE " +
                "WHERE Username = '" + Username + "';";
            DataTable Temp = dbMan.ExecuteReader(query);
            if (Temp == null)
                return true;
            return false;
        }

        public int ChangeMaintenanceDate(int Train_Number, string New_Date)
        {
            string StoredProcedureName = StoredProcedures.ChangeMaintenanceDay;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Train_Number", Train_Number);
            Parameters.Add("@New_Date", New_Date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int AddSupplier(int SupplierNumber, string SupplierAdddress,
                                string SupplierName, long PhoneNumber)
        {
            string query = "INSERT INTO SUPPLIER " +
                "VALUES (" + SupplierNumber.ToString() + ", '" + SupplierAdddress + "', " +
                "'" + SupplierName + "', " + PhoneNumber.ToString() + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int RemoveSupplier(int SupplierNumber)
        {
            string query = "DELETE FROM SUPPLIER " +
                "WHERE Supplier_ID = " + SupplierNumber.ToString() + ";";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
