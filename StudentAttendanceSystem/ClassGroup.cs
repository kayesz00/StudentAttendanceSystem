using System.Collections.Generic;

namespace StudentAttendanceSystem
{
    public class ClassGroup
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();

        public override string ToString()
        {
            return $"{ClassName} ({ClassId})";
        }
    }
}
