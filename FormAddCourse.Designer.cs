
namespace TinyCollege
{
    partial class FormAddCourse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSemesterOffered = new System.Windows.Forms.TextBox();
            this.txtNewCourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSemesterOffered);
            this.groupBox1.Controls.Add(this.txtNewCourseName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Course Data";
            // 
            // txtSemesterOffered
            // 
            this.txtSemesterOffered.Location = new System.Drawing.Point(354, 187);
            this.txtSemesterOffered.Name = "txtSemesterOffered";
            this.txtSemesterOffered.Size = new System.Drawing.Size(346, 22);
            this.txtSemesterOffered.TabIndex = 4;
            // 
            // txtNewCourseName
            // 
            this.txtNewCourseName.Location = new System.Drawing.Point(348, 76);
            this.txtNewCourseName.Name = "txtNewCourseName";
            this.txtNewCourseName.Size = new System.Drawing.Size(346, 22);
            this.txtNewCourseName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semesters Offered:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Title:";
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(193, 323);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(131, 45);
            this.addCourseButton.TabIndex = 1;
            this.addCourseButton.Text = "A&dd Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(438, 323);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(132, 45);
            this.Close.TabIndex = 2;
            this.Close.Text = "Cl&ose";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // FormAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddCourse";
            this.Text = "Add A Course";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSemesterOffered;
        private System.Windows.Forms.TextBox txtNewCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button Close;
    }
}