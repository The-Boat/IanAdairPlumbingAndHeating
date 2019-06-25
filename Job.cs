using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanAdairPlumbingAndHeating
{
    class Job
    {
        public Job(int jobNo, Customer cust, List<Visit> visits)
        {
            JobNo = jobNo;
            Cust = cust;
            Visits = visits;
        }
        public int JobNo { get; set; }
        internal Customer Cust { get; set; }
        internal List<Visit> Visits { get; set; }
    }
}
