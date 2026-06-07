using System.Collections.Generic;

namespace StudentAttendanceSystem
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public List<AttendanceRecord> AttendanceHistory { get; set; } = new List<AttendanceRecord>();
    }
}
