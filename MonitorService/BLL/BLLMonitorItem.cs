using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MonitorService.BLL
{
    public class BLLMonitorItem
    {
        public Models.MonitorItem getMonitorItem(int MonitorItemID)
        {
            Models.MonitorItem output = new Models.MonitorItem();

            if (MonitorItemID == 1)
            {
                output.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC1.benesure.com\EmailWorkingFolder\PDF");
                output.Description = "PDF Directory";
                output.MinValue = 0;
                output.MinValue = 100;
                output.MonitorTime = System.DateTime.Now;
            }
            else if (MonitorItemID == 2)
            {
                output.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC1.benesure.com\EmailWorkingFolder\Tiff");
                output.Description = "TIFF Directory";
                output.MinValue = 0;
                output.MinValue = 100;
                output.MonitorTime = System.DateTime.Now;
            }
            else if (MonitorItemID == 3)
            {
                output.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC1.benesure.com\EmailWorkingFolder\Output");
                output.Description = "Output Directory";
                output.MinValue = 0;
                output.MinValue = 100;
                output.MonitorTime = System.DateTime.Now;
            }
            else if (MonitorItemID == 4)
            {
                output.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC1.benesure.com\C$\IMountain");
                output.Description = "IMountain Directory";
                output.MinValue = 0;
                output.MinValue = 10;
                output.MonitorTime = System.DateTime.Now;
            }
            else if (MonitorItemID == 5)
            {
                output.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC3.benesure.com\OTFaxStore");
                output.Description = "OTFaxStore Directory";
                output.MinValue = 0;
                output.MinValue = 50;
                output.MonitorTime = System.DateTime.Now;
            }

            return output;
        }

        internal DataTable getAllMonitorItems()
        {
            DataTable output = new DataTable();
            output.Columns.Add(new DataColumn("Label"));
            output.Columns.Add(new DataColumn("Value"));

            DataRow RowToAdd = output.NewRow();

            Models.MonitorItem monitorItem = new Models.MonitorItem();

            for (int i = 1; i < 6; i++)
            {
                if (i == 1)
                {
                    monitorItem.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC1.benesure.com\EmailWorkingFolder\PDF");
                    monitorItem.Description = "PDF";
                    monitorItem.MinValue = 0;
                    monitorItem.MinValue = 100;
                    monitorItem.MonitorTime = System.DateTime.Now;
                }
                else if (i == 2)
                {
                    monitorItem.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC1.benesure.com\EmailWorkingFolder\Tiff");
                    monitorItem.Description = "TIFF";
                    monitorItem.MinValue = 0;
                    monitorItem.MinValue = 100;
                    monitorItem.MonitorTime = System.DateTime.Now;
                }
                else if (i == 3)
                {
                    monitorItem.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC1.benesure.com\EmailWorkingFolder\Output");
                    monitorItem.Description = "Output";
                    monitorItem.MinValue = 0;
                    monitorItem.MinValue = 100;
                    monitorItem.MonitorTime = System.DateTime.Now;
                }
                else if (i == 4)
                {
                    monitorItem.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC1.benesure.com\C$\IMountain");
                    monitorItem.Description = "IMountain";
                    monitorItem.MinValue = 0;
                    monitorItem.MinValue = 10;
                    monitorItem.MonitorTime = System.DateTime.Now;
                }
                else if (i == 5)
                {
                    monitorItem.CurrentValue = FileUtil.FileCount(@"\\CLSWVIAFRDPPFC3.benesure.com\OTFaxStore");
                    monitorItem.Description = "OTFaxStore";
                    monitorItem.MinValue = 0;
                    monitorItem.MinValue = 50;
                    monitorItem.MonitorTime = System.DateTime.Now;
                }

                RowToAdd = output.NewRow();

                RowToAdd["Label"] = monitorItem.Description;
                RowToAdd["Value"] = monitorItem.CurrentValue;

                output.Rows.Add(RowToAdd);
            }

            return output;
        }
    }
}