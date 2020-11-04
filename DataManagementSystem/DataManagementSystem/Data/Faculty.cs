using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data
{
    public class Faculty
    {
        public int Id { get; set; }
        public string TradeName { get; set; }
        public string RegisteredName { get; set; }
        public string OfficeName { get; set; }

        public Company Company { get; set; }

        public ICollection<Incubator> Incubators{ get; set; }
}
}
