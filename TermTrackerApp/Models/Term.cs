using System;
using System.Collections.Generic;

namespace TermTrackerApp.Models
{
    public class Term
    {
        public int TermId { get; set; }
        public string TermTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return $"{TermId} - {TermTitle}: {StartDate:M yyyy} to {EndDate:M yyyyy}";
        }
    }
}
