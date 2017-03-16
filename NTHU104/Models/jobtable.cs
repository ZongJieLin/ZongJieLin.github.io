using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webtesting.Models
{
    public class jobtable
    {
        private string jobcat;
        private string jobname;
        private string location;
        private int years;
        private string date;
        private string postdate;

        public jobtable() { }

        public jobtable(string jc, string jn, string lo, int y, string _date, string pd)
        {
            this.jobcat = jc;
            this.jobname = jn;
            this.location = lo;
            this.years = y;
            this.date = _date;
            this.postdate = pd;
        }

        public string Jobcat
        {
            get { return jobcat; }
            set { jobcat = value; }
        }

        public string Jobname
        {
            get { return jobname; }
            set { jobname = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Years
        {
            get { return years; }
            set { years = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Postdate
        {
            get { return postdate; }
            set { postdate = value; }
        }
    }
}