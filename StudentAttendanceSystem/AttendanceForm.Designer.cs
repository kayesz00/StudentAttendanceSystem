namespace StudentAttendanceSystem
{
    partial class AttendanceForm
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
            cmbStatus = new ComboBox();
            btnSaveAttendance = new Button();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 25;
            lstStudents.Location = new Point(51, 46);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(180, 129);
            lstStudents.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(51, 211);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 33);
            cmbStatus.TabIndex = 1;
            cmbStatus.Click += cmbStatus_Click;
            // 
            // btnSaveAttendance
            // 
            btnSaveAttendance.Location = new Point(51, 288);
            btnSaveAttendance.Name = "btnSaveAttendance";
            btnSaveAttendance.Size = new Size(112, 34);
            btnSaveAttendance.TabIndex = 2;
            btnSaveAttendance.Text = "Save Attendance";
            btnSaveAttendance.UseVisualStyleBackColor = true;
            btnSaveAttendance.Click += btnSaveAttendance_Click;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveAttendance);
            Controls.Add(cmbStatus);
            Controls.Add(lstStudents);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            Load += AttendanceForm_Load;
            Click += AttendanceForm_Click;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstStudents;
        private ComboBox cmbStatus;
        private Button btnSaveAttendance;
    }
}