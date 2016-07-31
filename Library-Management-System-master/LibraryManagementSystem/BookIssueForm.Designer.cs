namespace LibraryManagementSystem
{
    partial class BookIssueForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BookReservationButton = new System.Windows.Forms.Button();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BorrowDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BookIdTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.sessionDataSet = new LibraryManagementSystem.SessionDataSet();
            this.sessionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new LibraryManagementSystem.SessionDataSetTableAdapters.SessionTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BookReservationButton);
            this.groupBox1.Controls.Add(this.ReturnDatePicker);
            this.groupBox1.Controls.Add(this.BorrowDatePicker);
            this.groupBox1.Controls.Add(this.BookIdTextBox);
            this.groupBox1.Controls.Add(this.DepartmentComboBox);
            this.groupBox1.Controls.Add(this.StudentIdTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue Book";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(368, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "* Required!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(368, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "* Required!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(416, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "* Required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(416, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "* Required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(416, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "* Required";
            // 
            // BookReservationButton
            // 
            this.BookReservationButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BookReservationButton.ForeColor = System.Drawing.Color.White;
            this.BookReservationButton.Location = new System.Drawing.Point(162, 266);
            this.BookReservationButton.Name = "BookReservationButton";
            this.BookReservationButton.Size = new System.Drawing.Size(133, 38);
            this.BookReservationButton.TabIndex = 9;
            this.BookReservationButton.Text = "Reserve";
            this.BookReservationButton.UseVisualStyleBackColor = false;
            this.BookReservationButton.Click += new System.EventHandler(this.BookReservationButton_Click_1);
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.CustomFormat = "dd-M-yy";
            this.ReturnDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDatePicker.Location = new System.Drawing.Point(162, 218);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(200, 24);
            this.ReturnDatePicker.TabIndex = 8;
            // 
            // BorrowDatePicker
            // 
            this.BorrowDatePicker.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BorrowDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.BorrowDatePicker.CustomFormat = "dd-MM-yyyy";
            this.BorrowDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BorrowDatePicker.Location = new System.Drawing.Point(162, 179);
            this.BorrowDatePicker.Name = "BorrowDatePicker";
            this.BorrowDatePicker.Size = new System.Drawing.Size(200, 24);
            this.BorrowDatePicker.TabIndex = 7;
            // 
            // BookIdTextBox
            // 
            this.BookIdTextBox.Location = new System.Drawing.Point(162, 132);
            this.BookIdTextBox.Multiline = true;
            this.BookIdTextBox.Name = "BookIdTextBox";
            this.BookIdTextBox.Size = new System.Drawing.Size(248, 31);
            this.BookIdTextBox.TabIndex = 1;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(162, 83);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(248, 25);
            this.DepartmentComboBox.Sorted = true;
            this.DepartmentComboBox.TabIndex = 6;
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Location = new System.Drawing.Point(162, 32);
            this.StudentIdTextBox.Multiline = true;
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(248, 34);
            this.StudentIdTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Return Day";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Day of Borrow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Id";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // reserveToolStripMenuItem
            // 
            this.reserveToolStripMenuItem.Name = "reserveToolStripMenuItem";
            this.reserveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reserveToolStripMenuItem.Text = "Reserve";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "label11";
            // 
            // sessionDataSet
            // 
            this.sessionDataSet.DataSetName = "SessionDataSet";
            this.sessionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionDataSetBindingSource
            // 
            this.sessionDataSetBindingSource.DataSource = this.sessionDataSet;
            this.sessionDataSetBindingSource.Position = 0;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.sessionDataSetBindingSource;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(234, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "label12";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.Close3a;
            this.pictureBox2.Location = new System.Drawing.Point(572, 8);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // BookIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 387);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookIssueForm";
            this.Text = "BookIssueForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookIssueForm_FormClosed);
            this.Load += new System.EventHandler(this.BookReservationPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker ReturnDatePicker;
        private System.Windows.Forms.DateTimePicker BorrowDatePicker;
        private System.Windows.Forms.TextBox BookIdTextBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BookReservationButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource sessionDataSetBindingSource;
        private SessionDataSet sessionDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private SessionDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}