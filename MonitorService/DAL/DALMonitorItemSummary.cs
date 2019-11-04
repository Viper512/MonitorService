using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MonitorService.DAL
{
    public static class DALMonitorItemSummary
    {
        internal static DataTable GetMonitorItemSummary()
        {
            return Util.DBUtil.CreateCommand(@"    select Description, MonitorURL, MonitorTime, Value
	                                                from MonitorItem, 
			                                                MonitorItemValues, 		
			                                                (select MonitorItemID as MaxMonitorItemID, max(ID) as MaxID
				                                                from MonitorItemValues 
				                                                group by MonitorItemID) as MaxLookupTable
	                                                where MonitorItemID = MonitorItem.ID
			                                                and MonitorItem.ID = MaxLookupTable.MaxMonitorItemID
			                                                and MonitorItemValues.ID = MaxLookupTable.MaxID
	                                                order by MonitorItem.ID");
        }
    }
}