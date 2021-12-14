using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

// Team 2 Team Cheetah 
//  CISS 311 
// Advanced Agile Software Development
// Nov 24, 2021

namespace TinyCollege
{
    public partial class AllStudents : Form // All Students Form Class 
    {
        string connectionString; // The connection string contains the information needed to establish a connection to the database.
        BindingSource allstudentBindingSource = new BindingSource();  // establishes our binding source.
        SqlDataAdapter adapter; // The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data

        public AllStudents()
        {
            InitializeComponent();
            connectionString =
                ConfigurationManager.ConnectionStrings
                ["TinyCollege.Properties.Settings.TinyCollegeConnectionString"]
                .ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)  // event handler for button (to load all students)
        {
            {
                allStudentsDataGridView.DataSource = allstudentBindingSource; // establishing binding source 
                adapter = new SqlDataAdapter("SELECT * FROM Student", connectionString);  // sql query and connection to retrieve all students
                DataTable StudentTable = new DataTable(); // data table is the course table 
                adapter.Fill(StudentTable); // fill the adapter with the data from the course table  
                allstudentBindingSource.DataSource = StudentTable; // binding 
            }
        }
        private void closeButton_Click(object sender, EventArgs e) // event handler for button (to close)
            {
                Close();
        }
    }
}
