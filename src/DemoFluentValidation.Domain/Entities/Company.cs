using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFluentValidation.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public ICollection<Partner> Partners { get; set; }
        public ICollection<Revenues> Revenues { get; set; }
    }
}
