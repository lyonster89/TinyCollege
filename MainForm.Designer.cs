
namespace TinyCollege
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addStudentButton = new System.Windows.Forms.Button();
            this.displayStudentsButton = new System.Windows.Forms.Button();
            this.enrollButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.displayCoursesButton = new System.Windows.Forms.Button();
            this.courseRosterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentCoursesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(156, 129);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(249, 70);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add a Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // displayStudentsButton
            // 
            this.displayStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStudentsButton.Location = new System.Drawing.Point(156, 207);
            this.displayStudentsButton.Margin = new System.Windows.Forms.Padding(4);
            this.displayStudentsButton.Name = "displayStudentsButton";
            this.displayStudentsButton.Size = new System.Drawing.Size(249, 70);
            this.displayStudentsButton.TabIndex = 1;
            this.displayStudentsButton.Text = "Display All Students";
            this.displayStudentsButton.UseVisualStyleBackColor = true;
            this.displayStudentsButton.Click += new System.EventHandler(this.displayStudentsButton_Click);
            // 
            // enrollButton
            // 
            this.enrollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollButton.Location = new System.Drawing.Point(156, 284);
            this.enrollButton.Margin = new System.Windows.Forms.Padding(4);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(249, 70);
            this.enrollButton.TabIndex = 2;
            this.enrollButton.Text = "Enroll Student in Course";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Location = new System.Drawing.Point(548, 129);
            this.addCourseButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(249, 70);
            this.addCourseButton.TabIndex = 3;
            this.addCourseButton.Text = "Add a Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // displayCoursesButton
            // 
            this.displayCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCoursesButton.Location = new System.Drawing.Point(548, 207);
            this.displayCoursesButton.Margin = new System.Windows.Forms.Padding(4);
            this.displayCoursesButton.Name = "displayCoursesButton";
            this.displayCoursesButton.Size = new System.Drawing.Size(249, 70);
            this.displayCoursesButton.TabIndex = 4;
            this.displayCoursesButton.Text = "Display All Courses";
            this.displayCoursesButton.UseVisualStyleBackColor = true;
            this.displayCoursesButton.Click += new System.EventHandler(this.displayCoursesButton_Click);
            // 
            // courseRosterButton
            // 
            this.courseRosterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseRosterButton.Location = new System.Drawing.Point(548, 284);
            this.courseRosterButton.Margin = new System.Windows.Forms.Padding(4);
            this.courseRosterButton.Name = "courseRosterButton";
            this.courseRosterButton.Size = new System.Drawing.Size(249, 70);
            this.courseRosterButton.TabIndex = 5;
            this.courseRosterButton.Text = "Course Roster";
            this.courseRosterButton.UseVisualStyleBackColor = true;
            this.courseRosterButton.Click += new System.EventHandler(this.courseRosterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiny College Course Tracking System";
            // 
            // studentCoursesButton
            // 
            this.studentCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCoursesButton.Location = new System.Drawing.Point(156, 362);
            this.studentCoursesButton.Margin = new System.Windows.Forms.Padding(4);
            this.studentCoursesButton.Name = "studentCoursesButton";
            this.studentCoursesButton.Size = new System.Drawing.Size(249, 70);
            this.studentCoursesButton.TabIndex = 7;
            this.studentCoursesButton.Text = "Student Courses Listing";
            this.studentCoursesButton.UseVisualStyleBackColor = true;
            this.studentCoursesButton.Click += new System.EventHandler(this.studentCoursesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(548, 362);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(249, 70);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 479);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.studentCoursesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseRosterButton);
            this.Controls.Add(this.displayCoursesButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.displayStudentsButton);
            this.Controls.Add(this.addStudentButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button displayStudentsButton;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button displayCoursesButton;
        private System.Windows.Forms.Button courseRosterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button studentCoursesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

