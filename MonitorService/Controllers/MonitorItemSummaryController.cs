using MonitorService.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MonitorService.Controllers
{
    public class MonitorItemSummaryController : ApiController
    {
        // GET: MonitorItemSummary
        public IHttpActionResult Get()
        {
            return Ok(BLLMonitorItemSummary.GetMonitorItemSummary());
        }
    }
}