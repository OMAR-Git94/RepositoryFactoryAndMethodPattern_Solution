using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    public class Bike : EntityBase
    {
        public string BikeName { get; set; }
        public string BikeColor { get; set; }
        public decimal BikePrice { get; set; }
    }
}
