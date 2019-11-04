using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MonitorService.DAL
{
    public static class DALMonitorValues
    {
        internal static DataTable getAllMonitorValues()
        {
            return Util.DBUtil.CreateCommand(@"select MonitorItemValues.MonitorStartTime, Description, Value from [MonitorItemValues]
	inner join (select distinct top 100 
					MonitorStartTime
					from [Monitor].[dbo].[MonitorItemValues] with (nolock)
					order by MonitorStartTime desc) as indextimes on indextimes.MonitorStartTime = MonitorItemValues.MonitorStartTime
	inner join [Monitor].[dbo].[MonitorItem] on MonitorItemID = MonitorItem.ID
order by MonitorItemValues.MonitorStartTime asc
											
                             ");
            //            return Util.DBUtil.CreateCommand(@"    select MonitorStartTime, [PDF],
            //							[TIFF],
            //							[Output],
            //							[IMountain],
            //							[OTFaxStore]
            //							from 
            //  (select  MonitorStartTime, [PDF],
            //							[TIFF],
            //							[Output],
            //							[IMountain],
            //							[OTFaxStore]--, ROW_NUMBER() OVER (ORDER BY MonitorStartTime DESC) AS RowNum

            //									from (select 
            //											MonitorStartTime, Description, Value 
            //											from [Monitor].[dbo].[MonitorItemValues] with (nolock)
            //											inner join [Monitor].[dbo].[MonitorItem] on MonitorItemID = MonitorItem.ID
            //											 ) as subquery
            //pivot (max(Value) for Description in ([PDF],
            //							[TIFF],
            //							[Output],
            //							[IMountain],
            //							[OTFaxStore])) as pivotdata
            //							where MonitorStartTime >= dateadd(day, -1, getdate())
            //) as intt
            //order by MonitorStartTime asc
            //                             ");



        }
    }
}