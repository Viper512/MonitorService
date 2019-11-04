using MonitorService.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MonitorService.BLL
{
    public static class BLLMonitorItemSummary
    {
        internal static DataTable GetMonitorItemSummary()
        {
            return DALMonitorItemSummary.GetMonitorItemSummary();
        }
    }
}