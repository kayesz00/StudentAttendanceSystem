namespace StudentAttendanceSystem
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstStudents = new ListBox();
            txtStudentName = new TextBox();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 25;
            lstStudents.Location = new Point(90, 65);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(180, 129);
            lstStudents.TabIndex = 0;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(90, 225);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(150, 31);
            txtStudentName.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(90, 321);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(112, 34);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new Point(239, 321);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(112, 34);
            btnRemoveStudent.TabIndex = 3;
            btnRemoveStudent.Text = "Remove Student";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(txtStudentName);
            Controls.Add(lstStudents);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstStudents;
        private TextBox txtStudentName;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
    }
}