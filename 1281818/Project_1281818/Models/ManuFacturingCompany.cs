using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    public class ManuFacturingCompany : EntityBase
    {
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyEmail { get; set; }
    }
}
