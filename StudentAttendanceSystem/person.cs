using System;

namespace StudentAttendanceSystem
{
    public abstract class Person
    {
        public string Id { get; set; }
        private string _name;
        private string _email;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                _name = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email cannot be empty");
                _email = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Email})";
        }
    }
}
