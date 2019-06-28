using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanAdairPlumbingAndHeating
{
    class Visit
    {
        public Visit(int visitNo, double travel, double timeOnSite, double milage, bool doubleTime, bool timeAndAHalf, DateTime visitDate, Engineer eng)
        {
            VisitNo = visitNo;
            Travel = travel;
            TimeOnSite = timeOnSite;
            Milage = milage;
            DoubleTime = doubleTime;
            TimeAndAHalf = timeAndAHalf;
            VisitDate = visitDate;
            Eng = eng;
        }

        public int VisitNo { get; set; }
        public double Travel { get; set; }
        public double TimeOnSite { get; set; }
        public double Milage { get; set; }
        public bool DoubleTime { get; set; }
        public bool TimeAndAHalf { get; set; }
        public DateTime VisitDate { get; set; }
        public Engineer Eng { get; set; }

        public double getLabourHours()
        {
            double totalHours = Travel + TimeOnSite;

            if (DoubleTime)
            {
                return totalHours * 48;
            }
            else if (TimeAndAHalf)
            {
                return totalHours * 36;
            } 
            else
            {
                return totalHours * 24;
            }
        }

        public double getMilageCost()
        {
            double milageRate = 0.5;
            return Milage * milageRate;
        }

    }
}
