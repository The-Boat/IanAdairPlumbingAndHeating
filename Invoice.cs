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


        private double total()
        {
            List<Visit> visits = InvJob.Visits;

            double result = 0;

            foreach (Visit v in visits)
            {
                result += v.getMilageCost() + v.getLabourHours();
            }

            if(MaterialCost != 0)
            {
                result += MaterialCost;
            }

            return result;

        }

        private double vat()
        {

            return total() * 0.2;

        }

        private double invoiceTotal()
        {

            return total() + vat();

        }
    }
}
