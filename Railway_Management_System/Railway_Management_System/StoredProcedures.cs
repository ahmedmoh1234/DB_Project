using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Management_System
{
    class StoredProcedures
    {
        public static string SelectAllEmployees = "VIEW_EMPLOYEES";
        public static string SelectAllTrips = "VIEW_TRIPS";
        public static string SelectAllTrains = "VIEW_TRAINS";
        public static string SelectAllStations = "VIEW_STATIONS";
        public static string SelectAllSuppliers = "VIEW_SUPPLIERS";
        public static string SelectAllSpareParts = "VIEW_SPARE_PARTS";
        public static string ChangeMaintenanceDay = "CHANGE_TRAIN_MAINTENANCE_DATE";
        //public static string Login_Employee = "TRY_LOGIN_EMPLOYEE";
        //public static string Login_Passenger="TRY_LOGIN_PASSENGER";
        public static string SignUp_Passenger = "SIGNUP_PASSENGER";
        public static string Check_SSN_SignUp_Passenger = "CHECK_SSN_SIGN_UP_PASSENGER";
        public static string Check_Username_SignUp_Passenger = "CHECK_USERNAME_SIGN_UP_PASSENGER";
        public static string Check_Login_Passenger = "CHECK_LOGIN_PASSENGER";
        public static string Check_Login_Employee = "CHECK_LOGIN_EMPLOYEE";
    }
}
