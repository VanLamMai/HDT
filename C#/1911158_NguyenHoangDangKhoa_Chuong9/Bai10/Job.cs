using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Job
    {
        private string _description;
        private double _hours;
        private double _hourlyRate;
        private double _totalFee;

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public double Hours
        {
            get
            {
                return this._hours;
            }
            set
            {
                this._hours = value;
                this._totalFee = this.Hours * this.HourlyRate;
            }
        }

        public double HourlyRate
        {
            get
            {
                return this._hourlyRate;
            }
            set
            {
                this._hourlyRate = value;
                this._totalFee = this.Hours * this.HourlyRate;
            }
        }

        public double TotalFee
        {
            get
            {
                return this._totalFee;
            }
        }

        public Job(string description, double hours, double rate)
        {
            this.Description = description;
            this.Hours = hours;
            this.HourlyRate = rate;
        }

        public static Job operator +(Job j1, Job j2)
        {
            return new Job(
                j1.Description + " and " + j2.Description,
                j1.Hours + j2.Hours,
                ((j1.HourlyRate * (j1.Hours / (j1.Hours + j2.Hours)) + j2.HourlyRate * (j2.Hours / (j1.Hours + j2.Hours))))
                );
        }

        public override string ToString()
        {
            return string.Format("Job Description: {0}\nHours Required: {1}\nHourly Rate: {2:C}\nTotal Pay: {3:C}",
                this.Description, this.Hours, this.HourlyRate, this.TotalFee);
        }
    }
}
