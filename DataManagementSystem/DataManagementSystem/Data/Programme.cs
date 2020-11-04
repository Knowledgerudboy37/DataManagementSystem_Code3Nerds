using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data
{
    public class Programme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Funder { get; set; }
        public int NoOfApplication { get; set; }
        public string Purpose { get; set; }

        public bool Active { get; set; }
        public string PartnershipAgreement { get; set; }

   

        public Incubator Incubator { get; set; }//foreign key

        public ICollection<StartUp> StartUps { get; set; }//

        public ICollection<Beneficiary> Beneficiaries { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}
