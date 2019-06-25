using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanAdairPlumbingAndHeating
{
    class Visit
    {
        public Visit(int visitNo, float travel, float timeOnSite, float milage, bool doubleTime, bool timeAndAHalf, DateTime visitDate, Engineer eng)
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
        public float Travel { get; set; }
        public float TimeOnSite { get; set; }
        public float Milage { get; set; }
        public bool DoubleTime { get; set; }
        public bool TimeAndAHalf { get; set; }
        public DateTime VisitDate { get; set; }
        public Engineer Eng { get; set; }


    }
}
