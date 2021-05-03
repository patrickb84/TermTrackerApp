using System;
namespace TermTrackerApp.Models
{
    public class Assessment
    {
        public int AssessmentId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
