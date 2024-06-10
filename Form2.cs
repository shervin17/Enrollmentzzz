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
using Dapper;
using kkjnkhk_;

namespace kkjnkhk_
{
    public partial class Form2 : Form
    {
        List<Student> students;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Student";
                students = connection.Query<Student>(query).ToList();
                dataGridView1.DataSource = students;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Student current_student = dataGridView1.SelectedRows[0].DataBoundItem as Student;
            new Form1(current_student).Show();
        }
    }
}

