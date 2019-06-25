using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanAdairPlumbingAndHeating
{
    class Invoice
    {
        public Invoice(int invoiceNo, Job invJob, float materialCost)
        {
            InvoiceNo = invoiceNo;
            InvJob = invJob;
            MaterialCost = materialCost;
        }

        public int InvoiceNo { get; set; }
        public Job InvJob { get; set; }
        public float MaterialCost { get; set; }


        private float OverallTotal()
        {
            return 0;
        }

        private float VAT()
        {
            return 0;
        }

        private float invoiceTotal()
        {
            return 0;
        }
    }
}
