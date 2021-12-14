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

namespace TinyCollege
{
    public partial class FormEnroll : Form
    {
        string connectionString; // The connection string contains the information needed to establish a connection to the database.
        SqlConnection conn;
        BindingSource FormEnrollBindingSource = new BindingSource(); // establishes our binding source.
        public FormEnroll()
        {
            InitializeComponent();
            connectionString =
                ConfigurationManager.ConnectionStrings
                ["TinyCollege.Properties.Settings.TinyCollegeConnectionString"]
                .ConnectionString;
        }
 
        private void FormEnroll_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString)) // opening the sql connection 
            using (SqlDataAdapter adapter = new SqlDataAdapter // new sql data adapter to interprete sql 
            ("SELECT * FROM Student", conn)) // sql query selecting all member from advisor table
            {
                DataTable StudentTable = new DataTable(); // establishing the advisorTable as a new DataTable
                adapter.Fill(StudentTable);
                studentComboBox.DisplayMember = "studentName"; // establishes data to be displayed
                studentComboBox.ValueMember = "stuId"; //  establishes data to be updated in the data column
                studentComboBox.DataSource = StudentTable; // establishes datasource as advisorTable
            }

            using (conn = new SqlConnection(connectionString)) // opening the sql connection 
            using (SqlDataAdapter adapter = new SqlDataAdapter // new sql data adapter to interprete sql 
            ("SELECT * FROM Course", conn)) // sql query selecting all member from advisor table
            {
                DataTable CourseTable = new DataTable(); // establishing the advisorTable as a new DataTable
                adapter.Fill(CourseTable);
                courseComboBox.DisplayMember = "courseName"; // establishes data to be displayed
                courseComboBox.ValueMember = "courseId"; //  establishes data to be updated in the data column
                courseComboBox.DataSource = CourseTable; // establishes datasource as advisorTable
            }


        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            {
                using (conn = new SqlConnection(connectionString)) // establish SQL Connection
                using (SqlCommand comd = new SqlCommand("INSERT INTO Enroll (stuId, courseId) " + // Sql Command to insert into student table.
                    "VALUES (@stuId, @courseId)", conn))
                {
                    conn.Open();
                    comd.Parameters.AddWithValue("@stuId",
                        studentComboBox.SelectedValue);  // turns the entered text data into a student name in the Student Table
                    comd.Parameters.AddWithValue("@courseId",
                       courseComboBox.SelectedValue);  // turns the entered text data into a student name in the Student Table
                    comd.ExecuteScalar(); // method to execute the query 
                    MessageBox.Show("Student Enrolled."); // Message Displaying Student Was Added Successfully 
                }
            }
        }
    }
}
