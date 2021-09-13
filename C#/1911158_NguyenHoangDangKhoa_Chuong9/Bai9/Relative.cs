using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativesList
{
    class Relative : IComparable
    {
        public string Name { get; set; }
        public string Relationship { get; set; }
        public int dobMonth { get; set; }
        public int dobDay { get; set; }
        public int dobYear { get; set; }

        public Relative(string name, string relationship, int month, int day, int year)
        {
            this.Name = name;
            this.Relationship = relationship;
            this.dobMonth = month;
            this.dobDay = day;
            this.dobYear = year;
        }

        public override string ToString()
        {
            return string.Format("Relative Name: {0}\nRelationship: {1}\nBirthdate: {2}",
                this.Name, this.Relationship, this.DisplayBirthday());
        }

        private string _padWithZero(int value, bool needsSlash)
        {
            string result;
            result = (value < 10) ? "0" + value : value.ToString();
            if (needsSlash)
                result += "/";
            return result;
        }

        public string DisplayBirthday()
        {
            string dob = "";

            dob += _padWithZero(this.dobMonth, true);
            dob += _padWithZero(this.dobDay, true);
            dob += _padWithZero(this.dobYear, false);

            return dob;
        }

        public int CompareTo(object obj)
        {
            Relative other = (Relative)obj;

            return this.Name.CompareTo(other.Name);
        }
    }
}