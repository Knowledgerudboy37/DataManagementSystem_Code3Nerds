
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DataManagementSystem.Data
{
    public class DmsContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DmsContext(DbContextOptions<DmsContext> options) : base(options)
        {
                
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Faculty> Faculties{ get; set; }

        public DbSet<Incubator> Incubators { get; set; }

        public DbSet<Programme> Programmes { get; set; }

        public DbSet<Report> Reports{ get; set; }

        public DbSet<Representative> Representatives { get; set; }

        public DbSet<StartUp> StartUps { get; set; }

    }
}
