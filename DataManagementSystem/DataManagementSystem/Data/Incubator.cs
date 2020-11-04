using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementSystem.Data
{
    public class Incubator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }

        public ICollection<Programme> Programmes { get; set; }

        public ICollection<Incubator> Incubators { get; set; }



    }
}
