using System;

namespace StudentAttendanceSystem
{
    public class AttendanceRecord
    {
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public AttendanceStatus Status { get; set; }
    }
}

