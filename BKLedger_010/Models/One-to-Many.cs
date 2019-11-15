using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models
{
    public class tst_Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<tst_EmployeeOfCompany> Employees { get; set; }
    }
    public class tst_EmployeeOfCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public tst_Company Company { get; set; }
    }
}
