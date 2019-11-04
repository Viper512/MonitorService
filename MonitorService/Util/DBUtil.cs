using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MonitorService.Util
{
    public static class DBUtil
    {

        static private string connectionString = ConfigurationManager.AppSettings["connString"];

        public  static DataTable CreateCommand(string queryString)
        {
            DataTable output;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                output = new DataTable();
                output.Load(reader);
            }
            return output;
        }



        //     static private SqlConnection connection = new SqlConnection(connectionString);

        //     static private DataContext dc = new DataContext(connection);
        //     public static IEnumerable<MonitorValue> GetMonitorItems()
        //     {
        //         var MonitorItems = dc.ExecuteQuery<MonitorItem>(
        //             @"  select MonitorStartTime, [PDF],
        //[TIFF],
        //[Output],
        //[IMountain],
        //[OTFaxStore]

        //		from (select MonitorStartTime, Description, Value 
        //				from [Monitor].[dbo].[MonitorItemValues] with (nolock)
        //				inner join [Monitor].[dbo].[MonitorItem] on MonitorItemID = MonitorItem.ID
        //				 ) as subquery
        //                     pivot (max(Value) for Description in ([PDF],
        //                            [TIFF],
        //                            [Output],
        //                            [IMountain],
        //                            [OTFaxStore])) as pivotdata
        //                     ");

        //         return MonitorItems;
        //     }
        //}
    }
}