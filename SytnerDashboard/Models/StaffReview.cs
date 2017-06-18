using System;

namespace SytnerDashboard.Models
{
    public class StaffReview
    {
        public int ID { get; set; }
        public string Forename { get; set; }
        public string Surenamename { get; set; }
        public int Productivity { get; set; }
        public int WorkQuality { get; set; }
        public int TechnicalSkills { get; set; }
        public int Creativity{ get; set; }
        public int Attendance { get; set; }
        public int CommunicationSkills{ get; set; }
        public DateTime DateOfReview { get; set; }
    }
}
