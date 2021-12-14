using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace TinyCollege
{
    public partial class FormCourseRoster : Form
    {
        // create the class objects
        string connectionString;
        SqlConnection conn;
        //int courseId;
        public FormCourseRoster()
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
                "WHERE Course.courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseIDTextBox.Text);
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                if (courseTable.Rows.Count < 1)
                    courseTitleLabel.Text = "No classes found";
                else
                {
                    DataRow dr = courseTable.Rows[0];
                    courseListBox.DataSource = courseTable;
                    courseListBox.DisplayMember = "studentName";
                    courseTitleLabel.Text = courseTable.Rows[0].ItemArray[1].ToString();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
