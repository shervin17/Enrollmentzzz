using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace kkjnkhk_
{
    public partial class Form1 : Form
    {
        private Student student;
        List<Enrollment> enrollments;
        private List<Subject> list;

        public Form1(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string year = year_field.Text;
            string sem = sem_field.Text;
            show(year, sem);
            dataGridView1.DataSource = list;

        }
        private void show(string year, string sem)
        {
            int.TryParse(year, out int year_cur);
           
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string sqlquery = "select course.course_code, course_desc, units,year_offered, sem_offered from course inner join ITCuriculum on course.course_code = ITCuriculum.course_code where year_offered = @year and sem_offered =@sem";
                var objparams = new { year = year_cur, sem = sem };
               list= connection.Query<Subject>(sqlquery, objparams).ToList();
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student_id_field.Text = student.Id.ToString();
            first_name_field.Text = student.Firstname;
            last_name_field.Text= student.Lastname;
            program_field.Text = student.program;
            dataGridView1.MultiSelect = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Prompt the user to confirm removal
                if (MessageBox.Show("Remove selected subject?", "Remove?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;

                // Access the selected item from the bound list
                Subject selected = dataGridView1.Rows[e.RowIndex].DataBoundItem as Subject;

                // Remove the selected item from the list
                list.Remove(selected);

                // Update the DataGridView by resetting its DataSource
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Enroll Button
            enrollments = generateEnrollmentList();

            if (enrollments == null || enrollments.Count==0) {
                MessageBox.Show("please add atleast 1 subject");
                return;
            }
            DialogResult confirnation = MessageBox.Show($"Enroll {enrollments.Count} selected subjects?","You are about to enroll",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(confirnation == DialogResult.Cancel) {
                return;
            }

            using (SqlConnection connection = DatabaseConnection.GetConnection()){
               
                    using (var transaction = connection.BeginTransaction())
                    {
                    try {
                        foreach (Enrollment enrollment in enrollments)
                        {
                            EnrollOneSubject(enrollment);
                        }
                        transaction.Commit();
                        MessageBox.Show($" {enrollments.Count} subjects added");
                        
                    }
                    catch(Exception ex) 
                    {
                        transaction.Rollback();
                        MessageBox.Show("an error occured "+ ex.Message);
                    }

                    }
            }
            
        }

        private void EnrollOneSubject(Enrollment enrollment) {

            using (SqlConnection connection = DatabaseConnection.GetConnection()) {

                string query = "insert into enrollment values(@student_id,@course_code,@enrollment_date)";
                connection.Execute(query, new { 
                student_id = enrollment.Student_id,
                course_code= enrollment.Course_code,
                enrollment_date = enrollment.Enrollment_date,
                });
            }
        }




        private void EnrollSubject(Enrollment enrollment) { 
        
        }
        private List <Enrollment> generateEnrollmentList()
        {
            List<Enrollment> myList = new List<Enrollment>();

            foreach(Subject item in list)
            {
                Enrollment enrollment = new Enrollment
                {
                    Student_id = student.Id,
                    Course_code = item.Course_code,
                    Enrollment_date = DateTime.Now,
                };
                myList.Add(enrollment);
                clear();
                new StudentBalanceForm(list,student).ShowDialog();
            }
            return myList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clear fields
            clear();
        }
        private void clear() {
            dataGridView1.DataSource = null;
            list = new List<Subject>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new StudentBalanceForm(list,student).ShowDialog();
        }
    }


    
}