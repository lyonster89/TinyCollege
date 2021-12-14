using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace TinyCollege
{
    public partial class FormStudentEnrolled : Form
    {
        // create the class objects
        string connectionString;
        SqlConnection conn;
        //int studentId;
        public FormStudentEnrolled()
        {
            connectionString = ConfigurationManager.ConnectionStrings[
                "TinyCollege.Properties.Settings.TinyCollegeConnectionString"]
                .ConnectionString;
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "SELECT Course.courseId, Course.courseName, Student.studentName " +
                "FROM Enroll " +
                "JOIN Student ON Enroll.stuId = Student.stuId " +
                "JOIN Course on Enroll.courseId = Course.courseId " +
                "WHERE Student.stuId = @studentId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", studentIDTextBox.Text);
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                if (studentTable.Rows.Count < 1)
                    studentNameLabel.Text = "No students found";
                else
                {
                    DataRow dr = studentTable.Rows[0];
                    studentListBox.DataSource = studentTable;
                    studentListBox.DisplayMember = "courseName";
                    studentNameLabel.Text = studentTable.Rows[0].ItemArray[2].ToString();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
