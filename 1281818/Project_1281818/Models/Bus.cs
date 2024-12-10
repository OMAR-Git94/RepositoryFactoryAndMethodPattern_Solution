using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    public class Bus : EntityBase
    {
        public string BusName { get; set; }

        public string BusColor { get; set; }
        public int Seat { get; set; }

    }
}
