namespace StudentAttendanceSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbClasses = new ComboBox();
            dgvStudents = new DataGridView();
            btnAddClass = new Button();
            btnManageStudents = new Button();
            btnMarkAttendance = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // cmbClasses
            // 
            cmbClasses.AccessibleName = "cmbClasses  ";
            cmbClasses.FormattingEnabled = true;
            cmbClasses.Location = new Point(54, 37);
            cmbClasses.Name = "cmbClasses";
            cmbClasses.Size = new Size(182, 33);
            cmbClasses.TabIndex = 0;
            cmbClasses.SelectedIndexChanged += cmbClasses_SelectedIndexChanged;
            // 
            // dgvStudents
            // 
            dgvStudents.AccessibleName = "dgvStudents  ";
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(54, 96);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(360, 225);
            dgvStudents.TabIndex = 1;
            // 
            // btnAddClass
            // 
            btnAddClass.AccessibleName = "btnAddClass";
            btnAddClass.Location = new Point(54, 358);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(112, 34);
            btnAddClass.TabIndex = 2;
            btnAddClass.Text = "Add Class";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // btnManageStudents
            // 
            btnManageStudents.AccessibleName = "btnManageStudents";
            btnManageStudents.Location = new Point(202, 358);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(112, 34);
            btnManageStudents.TabIndex = 3;
            btnManageStudents.Text = "Manage Students";
            btnManageStudents.UseVisualStyleBackColor = true;
            btnManageStudents.Click += btnManageStudents_Click;
            // 
            // btnMarkAttendance
            // 
            btnMarkAttendance.AccessibleName = "btnMarkAttendance";
            btnMarkAttendance.Location = new Point(359, 358);
            btnMarkAttendance.Name = "btnMarkAttendance";
            btnMarkAttendance.Size = new Size(112, 34);
            btnMarkAttendance.TabIndex = 4;
            btnMarkAttendance.Text = "Mark Attendance";
            btnMarkAttendance.UseVisualStyleBackColor = true;
            btnMarkAttendance.Click += btnMarkAttendance_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMarkAttendance);
            Controls.Add(btnManageStudents);
            Controls.Add(btnAddClass);
            Controls.Add(dgvStudents);
            Controls.Add(cmbClasses);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbClasses;
        private DataGridView dgvStudents;
        private Button btnAddClass;
        private Button btnManageStudents;
        private Button btnMarkAttendance;
    }
}
