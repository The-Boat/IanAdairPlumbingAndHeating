using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanAdairPlumbingAndHeating
{
    class Engineer : Contact
    {
        public Engineer(int engineerNo, string forename, string surname, string phone, string email, string address1, string address2, string city, string postcode) : base(phone, email, address1, address2, city, postcode)
        {
            if (string.IsNullOrWhiteSpace(forename))
            {
                throw new ArgumentException("Missing forename", nameof(forename));
            }

            this.EngineerNo = engineerNo;
            Forename = forename;

            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException("Missing surname", nameof(surname));
            }

            Surname = surname;
        }

        public int EngineerNo { get; }
        public string Forename { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
