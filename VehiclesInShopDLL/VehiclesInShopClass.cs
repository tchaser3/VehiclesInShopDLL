/* Title:           Vehicle In Shop Class
 * Date:            7-11-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehiclesInShopDLL
{
    public class VehiclesInShopClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        VehiclesInShopDataSet aVehiclesInShopDataSet;
        VehiclesInShopDataSetTableAdapters.vehiclesinshopTableAdapter aVehiclesInShopTableAdapter;

        FindVehiclesInShopByVehicleIDDataSet aFindVehiclesInShopByVehicleIDDataSet;
        FindVehiclesInShopByVehicleIDDataSetTableAdapters.FindVehiclesInShopByVehicleIDTableAdapter aFindVehiclesInShopByVehicleIDTableAdapter;

        FindVehiclesInShopByVendorIDDataSet aFindVehiclesInShopByVendorIDDataSet;
        FindVehiclesInShopByVendorIDDataSetTableAdapters.FindVehiclesInShopByVendorIDTableAdapter aFindVehiclesInShopByVendorIDTableAdapter;

        FindAllVehiclesInShopDataSet aFindAllVehiclesInShopDataSet;
        FindAllVehiclesInShopDataSetTableAdapters.FindAllVehiclesInShopTableAdapter aFindAllVehiclesInShopTableAdapter;

        InsertVehicleInShopEntryTableAdapters.QueriesTableAdapter aInsertVehicleInShopTableAdapter;

        RemoveVehicleInShopEntryTableAdapters.QueriesTableAdapter aRemoveVehicleInShopEntryTableAdapter;

        FindAllVehicleMainInShopDataSet aFindAllVehicleMainInShopDataSet;
        FindAllVehicleMainInShopDataSetTableAdapters.FindAllVehicleMainInShopTableAdapter aFindAllVehicleMainInShopTableAdpater;

        FindVehicleMainInShopByVehicleIDDataSet aFindVehicleMainInShopByVehicleIDDataSet;
        FindVehicleMainInShopByVehicleIDDataSetTableAdapters.FindVehicleMainInShopByVehicleIDTableAdapter aFindVehicleMainInShopByVehicleIDTableAdapter;

        FindVehicleMainInShopByVendorIDDataSet aFindVehicleMainInShopByVendorIDDataSet;
        FindVehicleMainInShopByVendorIDDataSetTableAdapters.FindVehicleMainInShopByVendorIDTableAdapter aFindVehicleMainInShopByVendorIDTableAdapter;

        FindVehicleInShopByProblemIDDataSet aFindVehicleInShopByProblemIDDataSet;
        FindVehicleInShopByProblemIDDataSetTableAdapters.FindVehicleInShopByProblemIDTableAdapter aFindVehicleInShopByProblemIDTableAdapter;

        UpdateVehicleInShopVendorIDEntryTableAdapters.QueriesTableAdapter aUpdateVehicleInShopVendorIDTableAdapter;

        public bool UpdateVehicleInShopVendorID(int intTransactionID, int intVendorID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleInShopVendorIDTableAdapter = new UpdateVehicleInShopVendorIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleInShopVendorIDTableAdapter.UpdateVehicleInShopVendorID(intTransactionID, intVendorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Update Vehicle In Shop Vendor ID " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindVehicleInShopByProblemIDDataSet FindVehicleInShopByProblemID(int intProblemID)
        {
            try
            {
                aFindVehicleInShopByProblemIDDataSet = new FindVehicleInShopByProblemIDDataSet();
                aFindVehicleInShopByProblemIDTableAdapter = new FindVehicleInShopByProblemIDDataSetTableAdapters.FindVehicleInShopByProblemIDTableAdapter();
                aFindVehicleInShopByProblemIDTableAdapter.Fill(aFindVehicleInShopByProblemIDDataSet.FindVehicleInShopByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle In Shop Class // Find Vehicle In Shop By Problem ID " + Ex.Message);
            }

            return aFindVehicleInShopByProblemIDDataSet;
        }
        public FindVehicleMainInShopByVendorIDDataSet FindVehicleMainInShopByVendorID(int intVendorID)
        {
            try
            {
                aFindVehicleMainInShopByVendorIDDataSet = new FindVehicleMainInShopByVendorIDDataSet();
                aFindVehicleMainInShopByVendorIDTableAdapter = new FindVehicleMainInShopByVendorIDDataSetTableAdapters.FindVehicleMainInShopByVendorIDTableAdapter();
                aFindVehicleMainInShopByVendorIDTableAdapter.Fill(aFindVehicleMainInShopByVendorIDDataSet.FindVehicleMainInShopByVendorID, intVendorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Find Vehicle Main In Shop By Vendor ID " + Ex.Message);
            }

            return aFindVehicleMainInShopByVendorIDDataSet;
        }
        public FindVehicleMainInShopByVehicleIDDataSet FindVehicleMainInShopByVehicleID(int intVehicleID)
        {
            try
            {
                aFindVehicleMainInShopByVehicleIDDataSet = new FindVehicleMainInShopByVehicleIDDataSet();
                aFindVehicleMainInShopByVehicleIDTableAdapter = new FindVehicleMainInShopByVehicleIDDataSetTableAdapters.FindVehicleMainInShopByVehicleIDTableAdapter();
                aFindVehicleMainInShopByVehicleIDTableAdapter.Fill(aFindVehicleMainInShopByVehicleIDDataSet.FindVehicleMainInShopByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Find Vehicle Main In Shop By Vehicle ID " + Ex.Message);
            }

            return aFindVehicleMainInShopByVehicleIDDataSet;
        }
        public FindAllVehicleMainInShopDataSet FindAllVehicleMainInShop()
        {
            try
            {
                aFindAllVehicleMainInShopDataSet = new FindAllVehicleMainInShopDataSet();
                aFindAllVehicleMainInShopTableAdpater = new FindAllVehicleMainInShopDataSetTableAdapters.FindAllVehicleMainInShopTableAdapter();
                aFindAllVehicleMainInShopTableAdpater.Fill(aFindAllVehicleMainInShopDataSet.FindAllVehicleMainInShop);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Find All Vehicles In Shop " + Ex.Message);
            }

            return aFindAllVehicleMainInShopDataSet;
        }
        public bool RemoveVehicleInShop(int intVehicleID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveVehicleInShopEntryTableAdapter = new RemoveVehicleInShopEntryTableAdapters.QueriesTableAdapter();
                aRemoveVehicleInShopEntryTableAdapter.RemoveVehicleInShop(intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Remove Vehicle In Shop " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertVehicleInShop(int intVehicleID, DateTime datTransactionDate, int intVendorID, string strVehicleProblem, int intProblemID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleInShopTableAdapter = new InsertVehicleInShopEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleInShopTableAdapter.InsertVehicleInShop(intVehicleID, datTransactionDate, intVendorID, strVehicleProblem, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle In Shop Class // Insert Vehicle In Shop " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindAllVehiclesInShopDataSet FindAllVehiclesInShop()
        {
            try
            {
                aFindAllVehiclesInShopDataSet = new FindAllVehiclesInShopDataSet();
                aFindAllVehiclesInShopTableAdapter = new FindAllVehiclesInShopDataSetTableAdapters.FindAllVehiclesInShopTableAdapter();
                aFindAllVehiclesInShopTableAdapter.Fill(aFindAllVehiclesInShopDataSet.FindAllVehiclesInShop);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Find All Vehicles In Shop " + Ex.Message);
            }

            return aFindAllVehiclesInShopDataSet;
        }
        public FindVehiclesInShopByVendorIDDataSet FindVehiclesInShopByVendorID(int intVendorID)
        {
            try
            {
                aFindVehiclesInShopByVendorIDDataSet = new FindVehiclesInShopByVendorIDDataSet();
                aFindVehiclesInShopByVendorIDTableAdapter = new FindVehiclesInShopByVendorIDDataSetTableAdapters.FindVehiclesInShopByVendorIDTableAdapter();
                aFindVehiclesInShopByVendorIDTableAdapter.Fill(aFindVehiclesInShopByVendorIDDataSet.FindVehiclesInShopByVendorID, intVendorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle In Shop Class // Find Vehicles In Shop By Vendor ID " + Ex.Message);
            }

            return aFindVehiclesInShopByVendorIDDataSet;
        }
        public FindVehiclesInShopByVehicleIDDataSet FindVehiclesInShopByVehicleID(int intVehicleID)
        {
            try
            {
                aFindVehiclesInShopByVehicleIDDataSet = new FindVehiclesInShopByVehicleIDDataSet();
                aFindVehiclesInShopByVehicleIDTableAdapter = new FindVehiclesInShopByVehicleIDDataSetTableAdapters.FindVehiclesInShopByVehicleIDTableAdapter();
                aFindVehiclesInShopByVehicleIDTableAdapter.Fill(aFindVehiclesInShopByVehicleIDDataSet.FindVehiclesInShopByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Find Vehicles In Shop By Vehicle ID " + Ex.Message);
            }

            return aFindVehiclesInShopByVehicleIDDataSet;
        }
        public VehiclesInShopDataSet GetVehiclesInShopInfo()
        {
            try
            {
                aVehiclesInShopDataSet = new VehiclesInShopDataSet();
                aVehiclesInShopTableAdapter = new VehiclesInShopDataSetTableAdapters.vehiclesinshopTableAdapter();
                aVehiclesInShopTableAdapter.Fill(aVehiclesInShopDataSet.vehiclesinshop);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Get Vehicles In Shop Info " + Ex.Message);
            }

            return aVehiclesInShopDataSet;
        }
        public void UpdateVehiclesInShopDB(VehiclesInShopDataSet aVehiclesInShopDataSet)
        {
            try
            {
                aVehiclesInShopTableAdapter = new VehiclesInShopDataSetTableAdapters.vehiclesinshopTableAdapter();
                aVehiclesInShopTableAdapter.Update(aVehiclesInShopDataSet.vehiclesinshop);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Shop Class // Update Vehicles In Shop DB " + Ex.Message);
            }
        }
    }
}
