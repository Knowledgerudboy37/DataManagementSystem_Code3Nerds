using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data
{
    public class Company
    {
        public int Id { get; set; }
        public int String { get; set; }
      public ICollection<Faculty> Faculties { get; set; }//reference to faculty

      public ICollection<Address> Addresses { get; set; }

    }
}
