﻿using System;
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


    }
}
