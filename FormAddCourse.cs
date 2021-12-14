using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class FormAddCourse : Form
    {

        string connectionString;
        SqlConnection conn;

        public FormAddCourse()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.TinyCollegeConnectionString"]
                .ConnectionString;
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        { 
                using (conn = new SqlConnection(connectionString)) // establish SQL Connection
                using (SqlCommand comd = new SqlCommand("INSERT INTO Course (courseName, semesterOffered) " + // Sql Command to insert into student table.
                    "VALUES (@courseName, @semesterOffered)", conn))
            {
                    conn.Open();
                    comd.Parameters.AddWithValue("@courseName",
                        txtNewCourseName.Text);  // turns the entered text data into a student name in the Student Table
                    comd.Parameters.AddWithValue("@semesterOffered",
                       txtSemesterOffered.Text);  // turns the entered text data into a student name in the Student Table
                    comd.ExecuteScalar(); // method to execute the query 
                    MessageBox.Show("Course Added."); // Message Displaying Student Was Added Successfully 
                }
            }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}
