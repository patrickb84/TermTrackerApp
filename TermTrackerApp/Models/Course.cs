using System;
namespace TermTrackerApp.Models
{
    public enum CourseStatus
    {
        ENROLLED,
        UNENROLLED,
        COMPLETED
    }

    public class CourseInstructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CourseStatus CourseStatus { get; set; }
        public CourseInstructor Instructor { get; set; }
        public string Notes { get; set; }
        public Assessment PerformanceAssessment { get; set; }
        public Assessment ObjectiveAssessment { get; set; }
    }
}
