using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data
{
    public class Report
    {
        public int ReportId { get; set; }

        public string Name { get; set; }

        public Programme Programme { get; set; }
    }
}
