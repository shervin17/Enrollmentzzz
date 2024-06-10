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

namespace kkjnkhk_
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add new student 

            string firstname = fname_field.Text;
            string lastname = fname_field.Text;
            string middlename= midname_field.Text;
            DateTime bday= dateTimePicker1.Value; 
            string address= address_field.Text;
            string program= program_field.Text;

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {

                    string query = "insert into Student values(@fname,@lname,@mid,@bday,@address,@program)";
                    var objparam = new
                    {
                        fname = firstname,
                        lname = lastname,
                        mid = middlename,
                        bday = bday,
                        address = address,
                        program = program,
                    };
                    connection.Execute(query, objparam);
                    MessageBox.Show("record saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured " + ex.Message);
            }
        }
    }
}
