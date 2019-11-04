using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitorService.Models
{
    public class MonitorItem
    {
        public String Description { get; set; }
        public int CurrentValue { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public DateTime MonitorTime { get; set; }
    }
}