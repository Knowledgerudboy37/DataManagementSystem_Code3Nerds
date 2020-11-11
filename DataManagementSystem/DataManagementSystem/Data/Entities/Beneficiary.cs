using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data.Entities
{
    public class Beneficiary
    {
        public int BeneficiaryId { get; set; }

        public string FirstName { get; set; }

        public string LastName{ get; set; }

        public DateTime DateOfBirth { get; set; }

        public string IdNo { get; set; }

        public string PassportNo { get; set; }

        public string ImmigrationStatus { get; set; }

        public string CountryOfBirth { get; set; }

        public string HomeLanguage { get; set; }

        public string Gender { get; set; }

        public string Race { get; set; }

        public string Email { get; set; }

        public string CellPhoneNo { get; set; }

        public string AlternativePhoneNo { get; set; }

        public Programme Programme { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
