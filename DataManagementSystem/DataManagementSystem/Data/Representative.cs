using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data
{
    public class Representative
    {
        public int RepresentativeId { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  Email { get; set; }

        public string  Address { get; set; }

        public Incubator Incubator { get; set; }

    }
}
