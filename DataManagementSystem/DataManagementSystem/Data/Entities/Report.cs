using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data.Entities
{
    public class Report
    {
        public int ReportId { get; set; }

        public string Name { get; set; }

        public Programme Programme { get; set; }
    }
}
