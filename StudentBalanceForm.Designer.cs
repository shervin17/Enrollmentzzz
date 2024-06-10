namespace kkjnkhk_
{
    partial class StudentBalanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_field = new System.Windows.Forms.TextBox();
            this.fname_field = new System.Windows.Forms.TextBox();
            this.program_field = new System.Windows.Forms.TextBox();
            this.lastname_field = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combobox1payment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rate_per_unit_field = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.miscellaneous_field = new System.Windows.Forms.TextBox();
            this.balance_field = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.sy_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.units_field = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compute Tuition";
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Location = new System.Drawing.Point(38, 102);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(72, 16);
            this.ss.TabIndex = 1;
            this.ss.Text = "First name ";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(353, 102);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(69, 16);
            this.la.TabIndex = 2;
            this.la.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Program";
            // 
            // id_field
            // 
            this.id_field.Location = new System.Drawing.Point(127, 71);
            this.id_field.Name = "id_field";
            this.id_field.Size = new System.Drawing.Size(175, 22);
            this.id_field.TabIndex = 5;
            // 
            // fname_field
            // 
            this.fname_field.Location = new System.Drawing.Point(127, 102);
            this.fname_field.Name = "fname_field";
            this.fname_field.Size = new System.Drawing.Size(175, 22);
            this.fname_field.TabIndex = 6;
            // 
            // program_field
            // 
            this.program_field.Location = new System.Drawing.Point(432, 71);
            this.program_field.Name = "program_field";
            this.program_field.Size = new System.Drawing.Size(173, 22);
            this.program_field.TabIndex = 7;
            // 
            // lastname_field
            // 
            this.lastname_field.Location = new System.Drawing.Point(432, 102);
            this.lastname_field.Name = "lastname_field";
            this.lastname_field.Size = new System.Drawing.Size(173, 22);
            this.lastname_field.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 223);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // combobox1payment
            // 
            this.combobox1payment.FormattingEnabled = true;
            this.combobox1payment.Items.AddRange(new object[] {
            "FULL_PAYMENT",
            "MONTHLY"});
            this.combobox1payment.Location = new System.Drawing.Point(161, 503);
            this.combobox1payment.Name = "combobox1payment";
            this.combobox1payment.Size = new System.Drawing.Size(121, 24);
            this.combobox1payment.TabIndex = 11;
            this.combobox1payment.SelectedIndexChanged += new System.EventHandler(this.combobox1payment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "mode of payment";
            // 
            // rate_per_unit_field
            // 
            this.rate_per_unit_field.Location = new System.Drawing.Point(157, 431);
            this.rate_per_unit_field.Name = "rate_per_unit_field";
            this.rate_per_unit_field.Size = new System.Drawing.Size(175, 22);
            this.rate_per_unit_field.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rate per unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Miscellaneous";
            // 
            // miscellaneous_field
            // 
            this.miscellaneous_field.Location = new System.Drawing.Point(161, 466);
            this.miscellaneous_field.Name = "miscellaneous_field";
            this.miscellaneous_field.Size = new System.Drawing.Size(165, 22);
            this.miscellaneous_field.TabIndex = 16;
            // 
            // balance_field
            // 
            this.balance_field.Location = new System.Drawing.Point(161, 553);
            this.balance_field.Name = "balance_field";
            this.balance_field.Size = new System.Drawing.Size(121, 22);
            this.balance_field.TabIndex = 17;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(91, 559);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(57, 16);
            this.Balance.TabIndex = 18;
            this.Balance.Text = "Balance";
            // 
            // sy_cb
            // 
            this.sy_cb.FormattingEnabled = true;
            this.sy_cb.Location = new System.Drawing.Point(157, 396);
            this.sy_cb.Name = "sy_cb";
            this.sy_cb.Size = new System.Drawing.Size(169, 24);
            this.sy_cb.TabIndex = 19;
            this.sy_cb.SelectedIndexChanged += new System.EventHandler(this.sy_cb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Select School year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "units";
            // 
            // units_field
            // 
            this.units_field.Location = new System.Drawing.Point(540, 393);
            this.units_field.Name = "units_field";
            this.units_field.Size = new System.Drawing.Size(94, 22);
            this.units_field.TabIndex = 22;
            // 
            // StudentBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 643);
            this.Controls.Add(this.units_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sy_cb);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.balance_field);
            this.Controls.Add(this.miscellaneous_field);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rate_per_unit_field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combobox1payment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lastname_field);
            this.Controls.Add(this.program_field);
            this.Controls.Add(this.fname_field);
            this.Controls.Add(this.id_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.la);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.label1);
            this.Name = "StudentBalanceForm";
            this.Text = "StudentBalanceForm";
            this.Load += new System.EventHandler(this.StudentBalanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_field;
        private System.Windows.Forms.TextBox fname_field;
        private System.Windows.Forms.TextBox program_field;
        private System.Windows.Forms.TextBox lastname_field;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combobox1payment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rate_per_unit_field;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox miscellaneous_field;
        private System.Windows.Forms.TextBox balance_field;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.ComboBox sy_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox units_field;
    }
}