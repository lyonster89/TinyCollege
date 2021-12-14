namespace TinyCollege
{
    partial class EnrollForm
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
            this.enrollButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.enrollmentDataBox = new System.Windows.Forms.GroupBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enrollmentDataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enrollButton
            // 
            this.enrollButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollButton.Location = new System.Drawing.Point(121, 227);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(75, 37);
            this.enrollButton.TabIndex = 0;
            this.enrollButton.Text = "&Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(290, 227);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 37);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Cl&ose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // enrollmentDataBox
            // 
            this.enrollmentDataBox.Controls.Add(this.courseComboBox);
            this.enrollmentDataBox.Controls.Add(this.label2);
            this.enrollmentDataBox.Controls.Add(this.studentComboBox);
            this.enrollmentDataBox.Controls.Add(this.label1);
            this.enrollmentDataBox.Location = new System.Drawing.Point(23, 29);
            this.enrollmentDataBox.Name = "enrollmentDataBox";
            this.enrollmentDataBox.Size = new System.Drawing.Size(432, 192);
            this.enrollmentDataBox.TabIndex = 2;
            this.enrollmentDataBox.TabStop = false;
            this.enrollmentDataBox.Text = "Enrollment Data";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(211, 115);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(176, 21);
            this.courseComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a Course:";
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(211, 54);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(176, 21);
            this.studentComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Student:";
            // 
            // EnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 276);
            this.Controls.Add(this.enrollmentDataBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.enrollButton);
            this.Name = "EnrollForm";
            this.Text = "Enroll a Student In a Course";
            this.enrollmentDataBox.ResumeLayout(false);
            this.enrollmentDataBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox enrollmentDataBox;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.Label label1;
    }
}