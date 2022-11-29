using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    internal class HREmployee : Employee
    {
        public string subdivision { get; set; }
        public string project { get; set; }
        public string jobdesk { get; set; }
    }
}
