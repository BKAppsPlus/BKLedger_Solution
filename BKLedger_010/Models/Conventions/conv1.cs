using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.Conventions
{
    public class conv1_OneClass
    {
        public int conv1_OneClassId { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
    }
    public class conv1_ManyStudent
    {
        public int conv1_ManyStudentId { get; set; }
        public string StudentName { get; set; }
        public conv1_OneClass THEclass { get; set; }
    }

}
