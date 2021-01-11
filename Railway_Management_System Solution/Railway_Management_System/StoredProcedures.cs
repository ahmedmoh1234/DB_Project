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
        public static string OrderSpareParts = "ORDER_SPARE_PARTS";
        public static string SelectSparePartsInStation = "VIEW_SPARE_PARTS_IN_STATION";
        public static string InsertEmployee = "INSERT_EMPLOYEE";
        public static string CheckEmployeeBySSN = "CHECK_EMPLOYEE_BY_SSN";
        public static string RemoveEployee = "REMOVE_EMPLOYEE";

        public static string SelectAllRequest = "VIEW_REQUEST";
        public static string DecSparePart = "DEC_SPARE_PARTS";
        public static string RemoveTrip = "REMOVE_TRIP";
        public static string AddTrip = "ADD_TRIP";

        public static string GetNumberTripsOfTrain = "NO_TRAIN_TRIPS";

    }
}
