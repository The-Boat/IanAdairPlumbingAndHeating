using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanAdairPlumbingAndHeating
{
    class Customer : Contact
    {
        public Customer(int customerNo, string title, string phone, string email, string address1, string address2, string city, string postcode, int type) : base(phone, email, address1, address2, city, postcode)
        {

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Missing title",nameof(title));
            }

            CustomerNo = customerNo;
            Type = type;
            Title = title;
        }

        public int CustomerNo { get; }
        public int Type { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
