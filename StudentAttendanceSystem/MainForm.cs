namespace StudentAttendanceSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshClassList();
        }

        private void RefreshClassList()
        {
            cmbClasses.DataSource = null;
            cmbClasses.DataSource = DataStore.Classes.ToList();
        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedClass = cmbClasses.SelectedItem as ClassGroup;

            if (selectedClass != null)
            {
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = selectedClass.Students.ToList();
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter class name:",
                "Add Class",
                "Class 1"
            );

            if (!string.IsNullOrWhiteSpace(name))
            {
                var newClass = new ClassGroup
                {
                    ClassId = Guid.NewGuid().ToString().Substring(0, 8),
                    ClassName = name
                };

                DataStore.Classes.Add(newClass);
                RefreshClassList();
            }
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            var selectedClass = cmbClasses.SelectedItem as ClassGroup;

            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class first.");
                return;
            }

            using (var form = new StudentForm(selectedClass))
            {
                form.ShowDialog();
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = selectedClass.Students.ToList();
            }
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            var selectedClass = cmbClasses.SelectedItem as ClassGroup;

            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class first.");
                return;
            }

            using (var form = new AttendanceForm(selectedClass))
            {
                form.ShowDialog();
            }
        }
    }
}
