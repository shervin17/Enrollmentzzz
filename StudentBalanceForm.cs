using Dapper;
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

namespace kkjnkhk_
{
    public partial class StudentBalanceForm : Form
    {
        private List<Subject> forComputation;
        private Student student;
        private List<Charges> charges;
        Charges selected_charges;
        private decimal current_rate_per_unit;
        private decimal misc;
        private int total_units;
        private decimal balance;

        public StudentBalanceForm(List<Subject> forComputation , Student student)
        {
            InitializeComponent();
            this.student = student;
            this.forComputation = forComputation;
        }

        private void StudentBalanceForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = forComputation;

            using (SqlConnection sqlConn = DatabaseConnection.GetConnection()) {

                string query = "select * from Charges";
                charges =sqlConn.Query<Charges>(query).ToList();
            }
            sy_cb.DataSource = charges;
            computeTotalUnits();

            id_field.Text = student.Id.ToString();
            fname_field.Text= student.Firstname.ToString();
            lastname_field.Text=  student.Lastname.ToString();
            program_field.Text = student.program;
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
                forComputation.Remove(selected);

                // Update the DataGridView by resetting its DataSource
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = forComputation;
                computeTotalUnits();
                balance= 0;
                balance_field.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //compute

        }

        private void sy_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_charges = sy_cb.SelectedItem as Charges;

            rate_per_unit_field.Text = selected_charges.Rate_per_units.ToString();
            miscellaneous_field.Text= selected_charges.Miscellaneous_fee.ToString();

            current_rate_per_unit = selected_charges.Rate_per_units;
            misc = selected_charges.Miscellaneous_fee;

        }
        private void computeTotalUnits()
        {   
            total_units = 0;
            forComputation.ForEach(subject => total_units+= subject.Units);
            units_field.Text= total_units.ToString();
        }

        private void combobox1payment_SelectedIndexChanged(object sender, EventArgs e)
        {

            string mode_of_payment = combobox1payment.SelectedItem.ToString();

            if (mode_of_payment == "FULL_PAYMENT")
            {
                balance = total_units * selected_charges.Rate_per_units + selected_charges.Miscellaneous_fee;
            }
            else if (mode_of_payment == "MONTHLY")
            {
                balance = (total_units * selected_charges.Rate_per_units + selected_charges.Miscellaneous_fee) * 1.10m;
            }
            balance_field.Text = balance.ToString();
        }

    }
}
