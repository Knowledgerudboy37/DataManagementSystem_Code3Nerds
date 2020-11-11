using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data.Entities
{
    public class StartUp
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int CellPhoneNo { get; set; }

        public int AlternativePhoneNo { get; set; }

        public string StreetAddress { get; set; }

        public Programme startUp { get; set; }
    }
}
