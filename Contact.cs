using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanAdairPlumbingAndHeating
{
    class Contact
    {
        public Contact(string phone, string email, string address1, string address2, string city, string postcode)
        {

            if (string.IsNullOrWhiteSpace(address1))
            {
                throw new ArgumentException("Missing address information", nameof(address1));
            }

            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("Missing city name", nameof(city));
            }

            if (string.IsNullOrWhiteSpace(postcode))
            {
                throw new ArgumentException("Missing postcode", nameof(postcode));
            }

            Phone = phone;
            Email = email;
            Address1 = address1;
            Address2 = address2;
            City = city;
            Postcode = postcode;
        }

        private static void NewMethod(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Phone number cannot be empty", nameof(phone));
            }
        }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }
}
