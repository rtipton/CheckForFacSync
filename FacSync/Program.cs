using System;
using System.Collections.Generic;
using System.Text;
using FacSync.FacSyncDSTableAdapters;

namespace FacSync
{
    class Program
    {
        static void Main(string[] args)
        {
            SyncDataTableAdapter ta = new SyncDataTableAdapter();      
            FacSyncDS.SyncDataDataTable dt = ta.GetData();

            foreach (FacSyncDS.SyncDataRow dr in dt) 
            {
                string facBU = dr.businessUnit;
                string facility = dr.facilityName;
                int recCount = dr.RecCount;
                string lastSync = dr.NotSyncSince.ToShortDateString();

                Console.WriteLine("{0}" + " - " + "[{1}]" + " - " + "{2}" + " - " + "{3}", facBU, recCount.ToString("0000"), lastSync, facility);
            }

            Console.ReadLine();
        }
    }
}
