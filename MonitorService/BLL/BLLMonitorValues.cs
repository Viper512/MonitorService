using System;
using System.Data;

namespace MonitorService.BLL
{
    internal class BLLMonitorValues
    {
        internal DataTable getAllMonitorValues()
        {
            return DAL.DALMonitorValues.getAllMonitorValues();
        }
    }
}