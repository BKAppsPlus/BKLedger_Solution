using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.IsolatedSamples
{
    public class O2M_Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<O2M_EmployeeOfCompany> Employees { get; set; }
    }
    public class O2M_EmployeeOfCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public O2M_Company Company { get; set; }
    }
}
