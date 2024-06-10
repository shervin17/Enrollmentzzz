namespace kkjnkhk_
{
    partial class StudentForm
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
            this.zz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fname_field = new System.Windows.Forms.TextBox();
            this.midname_field = new System.Windows.Forms.TextBox();
            this.lastname_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address_field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.program_field = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // zz
            // 
            this.zz.AutoSize = true;
            this.zz.Location = new System.Drawing.Point(40, 74);
            this.zz.Name = "zz";
            this.zz.Size = new System.Drawing.Size(72, 16);
            this.zz.TabIndex = 0;
            this.zz.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Middle name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // fname_field
            // 
            this.fname_field.Location = new System.Drawing.Point(133, 74);
            this.fname_field.Name = "fname_field";
            this.fname_field.Size = new System.Drawing.Size(196, 22);
            this.fname_field.TabIndex = 3;
            // 
            // midname_field
            // 
            this.midname_field.Location = new System.Drawing.Point(133, 102);
            this.midname_field.Name = "midname_field";
            this.midname_field.Size = new System.Drawing.Size(196, 22);
            this.midname_field.TabIndex = 4;
            // 
            // lastname_field
            // 
            this.lastname_field.Location = new System.Drawing.Point(133, 132);
            this.lastname_field.Name = "lastname_field";
            this.lastname_field.Size = new System.Drawing.Size(196, 22);
            this.lastname_field.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "birth date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "address";
            // 
            // address_field
            // 
            this.address_field.Location = new System.Drawing.Point(449, 108);
            this.address_field.Name = "address_field";
            this.address_field.Size = new System.Drawing.Size(196, 22);
            this.address_field.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "program";
            // 
            // program_field
            // 
            this.program_field.Location = new System.Drawing.Point(449, 138);
            this.program_field.Name = "program_field";
            this.program_field.Size = new System.Drawing.Size(196, 22);
            this.program_field.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "add student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(37, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Register Student";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(449, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.program_field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname_field);
            this.Controls.Add(this.midname_field);
            this.Controls.Add(this.fname_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zz);
            this.Name = "StudentForm";
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fname_field;
        private System.Windows.Forms.TextBox midname_field;
        private System.Windows.Forms.TextBox lastname_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox program_field;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}