using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Conference : IComparable
    {
        public string GrpName { get; set; }
        public string StartDate { get; set; }
        public int NumAttendees { get; set; }

        public Conference(string grp, string startDate, int attendees)
        {
            this.GrpName = grp;
            this.StartDate = startDate;
            this.NumAttendees = attendees;
        }

        public int CompareTo(object obj)
        {
            Conference other = (Conference)obj;

            if (this.NumAttendees > other.NumAttendees)
                return 1;
            else if (this.NumAttendees == other.NumAttendees)
                return 0;
            else
                return -1;
        }

        public override string ToString()
        {
            return string.Format("Conference Group Name: {0}\nStart Date: {1}\nNumber of Attendees: {2}",
                this.GrpName, this.StartDate, this.NumAttendees);
        }
    }
}
