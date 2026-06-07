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
    public partial class AttendanceForm : Form
    {
        private ClassGroup _classGroup;

        public AttendanceForm(ClassGroup classGroup)
        {
            InitializeComponent();
            _classGroup = classGroup;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            lstStudents.DataSource = _classGroup.Students.ToList();

            cmbStatus.Items.Add(AttendanceStatus.Present);
            cmbStatus.Items.Add(AttendanceStatus.Absent);
            cmbStatus.Items.Add(AttendanceStatus.Late);

            cmbStatus.SelectedIndex = 0;
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            var selectedStudent = lstStudents.SelectedItem as Student;

            if (selectedStudent == null)
            {
                MessageBox.Show("Select a student.");
                return;
            }

            var record = new AttendanceRecord
            {
                Student = selectedStudent,
                Date = DateTime.Now,
                Status = (AttendanceStatus)cmbStatus.SelectedItem
            };

            _classGroup.AttendanceRecords.Add(record);

            MessageBox.Show("Attendance saved.");
        }

        private void AttendanceForm_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
