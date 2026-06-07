// This form manages adding and removing students from a class
// It loads the student list and updates it when changes are made
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class StudentForm : Form
    {
        private ClassGroup _classGroup;

        public StudentForm(ClassGroup classGroup)
        {
            InitializeComponent();
            _classGroup = classGroup;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // Load the list of students when the form opens
            RefreshStudentList();
        }

        private void RefreshStudentList()
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = _classGroup.Students.ToList();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a student name.");
                return;
            }

            var student = new Student
            {
                StudentId = Guid.NewGuid().ToString().Substring(0, 8),
                Name = name
            };

            _classGroup.Students.Add(student);
            txtStudentName.Clear();
            RefreshStudentList();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            var selected = lstStudents.SelectedItem as Student;

            if (selected == null)
            {
                MessageBox.Show("Select a student to remove.");
                return;
            }

            _classGroup.Students.Remove(selected);
            RefreshStudentList();
        }
    }
}

