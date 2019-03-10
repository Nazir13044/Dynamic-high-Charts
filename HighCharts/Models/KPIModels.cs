using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighCharts.Models
{
    public class KPIModels
    {
        //public long? Id { get; set; }
        public long? kpiId { get; set; }
        public string KPIName { get; set; }
        public decimal? Target { get; set; }
        public string Actual { get; set; }
    }
}