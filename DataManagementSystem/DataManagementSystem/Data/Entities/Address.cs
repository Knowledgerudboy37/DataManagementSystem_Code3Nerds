using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data.Entities
{
    public class Address
    {
        public int AddressId { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Line3 { get; set; }

        public string PostalCode { get; set; }

        public string Suburb { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }

        public Company Company { get; set; }

        public Beneficiary Beneficiary { get; set; }
    }
}
