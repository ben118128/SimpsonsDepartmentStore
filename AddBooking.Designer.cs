﻿namespace SimpsonsDepartmentStore
{
    partial class AddBooking
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(138, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(138, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booking Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(138, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Booking Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(138, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Booking Contents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(138, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Assigned Staff";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(241, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Treatment Room 1",
            "Treatment Room 2",
            "Treatment Room 3",
            "Nail Bar"});
            this.comboBox2.Location = new System.Drawing.Point(241, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(241, 301);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(321, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Create a new booking";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.button1.Location = new System.Drawing.Point(344, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(242, 244);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(98, 49);
            this.checkedListBox1.TabIndex = 14;
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBooking";
            this.Text = "AddBooking";
            this.Load += new System.EventHandler(this.AddBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}