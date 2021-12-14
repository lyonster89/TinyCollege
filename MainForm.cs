using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Team 2 Team Cheetah 
//  CISS 311 
// Advanced Agile Software Development
// Nov 24, 2021

namespace TinyCollege
{
    public partial class MainForm : Form // Main Form Class
    {
        public MainForm()
        {
            InitializeComponent(); 
        }

        private void exitButton_Click(object sender, EventArgs e) // event handler to close on button click
        {
            Close();
        }

        private void addStudentButton_Click(object sender, EventArgs e) // event handler to open the add a student form on button click
        {
            FormAddAStudent frm = new FormAddAStudent();
            frm.Show();

        }

        private void displayStudentsButton_Click(object sender, EventArgs e) // event handler to open the all students form on button click
        {
            AllStudents frm = new AllStudents();
            frm.Show();
        }

        private void displayCoursesButton_Click(object sender, EventArgs e) // event handler to open the all courses form on button click
        {
            AllCourses frm = new AllCourses();
            frm.Show();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            {
                FormAddCourse addCourseForm = new FormAddCourse();
                addCourseForm.ShowDialog();
            }
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            FormEnroll addFormEnroll = new FormEnroll();
            addFormEnroll.ShowDialog();
        }

        private void courseRosterButton_Click(object sender, EventArgs e)
        {
            FormCourseRoster addFormCourseRoster = new FormCourseRoster();
            addFormCourseRoster.ShowDialog();
        }

        private void studentCoursesButton_Click(object sender, EventArgs e)
        {
            FormStudentEnrolled addFormStudentEnrolled = new FormStudentEnrolled();
            addFormStudentEnrolled.ShowDialog();
        }
    }
}
