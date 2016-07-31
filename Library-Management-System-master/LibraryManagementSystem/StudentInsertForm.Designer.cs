namespace LibraryManagementSystem
{
    partial class StudentInsertForm
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
            this.StudentAddButton = new System.Windows.Forms.Button();
            this.sessionDataSet = new LibraryManagementSystem.SessionDataSet();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new LibraryManagementSystem.SessionDataSetTableAdapters.SessionTableAdapter();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SessionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentAddForm = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.StuidentImageBox = new System.Windows.Forms.PictureBox();
            this.STudentImageUploadButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LibraryCardNoTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LastPageButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.FirstPageButton = new System.Windows.Forms.Button();
            this.StudentDeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.StudentSearctBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.StudentAddForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuidentImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentAddButton
            // 
            this.StudentAddButton.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentAddButton.Location = new System.Drawing.Point(296, 345);
            this.StudentAddButton.Name = "StudentAddButton";
            this.StudentAddButton.Size = new System.Drawing.Size(244, 40);
            this.StudentAddButton.TabIndex = 0;
            this.StudentAddButton.Text = "Add Student";
            this.StudentAddButton.UseVisualStyleBackColor = true;
            this.StudentAddButton.Click += new System.EventHandler(this.StudentAddButton_Click);
            // 
            // sessionDataSet
            // 
            this.sessionDataSet.DataSetName = "SessionDataSet";
            this.sessionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.sessionDataSet;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepartmentComboBox.DisplayMember = "DepartmentId";
            this.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DepartmentComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(288, 149);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(258, 26);
            this.DepartmentComboBox.TabIndex = 4;
            this.DepartmentComboBox.ValueMember = "DepartmentId";
            this.DepartmentComboBox.DropDownClosed += new System.EventHandler(this.DepartmentComboBox_DropDownClosed);
            this.DepartmentComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DepartmentComboBox_MouseClick);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            // 
            // SessionComboBox
            // 
            this.SessionComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SessionComboBox.DataSource = this.sessionBindingSource;
            this.SessionComboBox.DisplayMember = "SessionName";
            this.SessionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionComboBox.FormattingEnabled = true;
            this.SessionComboBox.Location = new System.Drawing.Point(290, 197);
            this.SessionComboBox.Name = "SessionComboBox";
            this.SessionComboBox.Size = new System.Drawing.Size(256, 26);
            this.SessionComboBox.TabIndex = 5;
            this.SessionComboBox.ValueMember = "SessionId";
            this.SessionComboBox.DropDownClosed += new System.EventHandler(this.SessionComboBox_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Session";
            // 
            // StudentAddForm
            // 
            this.StudentAddForm.BackColor = System.Drawing.Color.Transparent;
            this.StudentAddForm.Controls.Add(this.label17);
            this.StudentAddForm.Controls.Add(this.StuidentImageBox);
            this.StudentAddForm.Controls.Add(this.STudentImageUploadButton);
            this.StudentAddForm.Controls.Add(this.label16);
            this.StudentAddForm.Controls.Add(this.label15);
            this.StudentAddForm.Controls.Add(this.label14);
            this.StudentAddForm.Controls.Add(this.label13);
            this.StudentAddForm.Controls.Add(this.LibraryCardNoTextBox);
            this.StudentAddForm.Controls.Add(this.StudentNameTextBox);
            this.StudentAddForm.Controls.Add(this.label8);
            this.StudentAddForm.Controls.Add(this.label7);
            this.StudentAddForm.Controls.Add(this.StudentIdTextBox);
            this.StudentAddForm.Controls.Add(this.label6);
            this.StudentAddForm.Controls.Add(this.label5);
            this.StudentAddForm.Controls.Add(this.label4);
            this.StudentAddForm.Controls.Add(this.label3);
            this.StudentAddForm.Controls.Add(this.StudentAddButton);
            this.StudentAddForm.Controls.Add(this.label2);
            this.StudentAddForm.Controls.Add(this.DepartmentComboBox);
            this.StudentAddForm.Controls.Add(this.label1);
            this.StudentAddForm.Controls.Add(this.SessionComboBox);
            this.StudentAddForm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentAddForm.Location = new System.Drawing.Point(17, 150);
            this.StudentAddForm.Name = "StudentAddForm";
            this.StudentAddForm.Size = new System.Drawing.Size(1029, 430);
            this.StudentAddForm.TabIndex = 9;
            this.StudentAddForm.TabStop = false;
            this.StudentAddForm.Text = "Add New Student";
            this.StudentAddForm.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(186, 310);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "Student Image";
            // 
            // StuidentImageBox
            // 
            this.StuidentImageBox.Location = new System.Drawing.Point(719, 24);
            this.StuidentImageBox.Name = "StuidentImageBox";
            this.StuidentImageBox.Size = new System.Drawing.Size(142, 126);
            this.StuidentImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StuidentImageBox.TabIndex = 22;
            this.StuidentImageBox.TabStop = false;
            // 
            // STudentImageUploadButton
            // 
            this.STudentImageUploadButton.Location = new System.Drawing.Point(288, 297);
            this.STudentImageUploadButton.Name = "STudentImageUploadButton";
            this.STudentImageUploadButton.Size = new System.Drawing.Size(261, 42);
            this.STudentImageUploadButton.TabIndex = 21;
            this.STudentImageUploadButton.Text = "Brows for Image";
            this.STudentImageUploadButton.UseVisualStyleBackColor = true;
            this.STudentImageUploadButton.Click += new System.EventHandler(this.STudentImageUploadButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(557, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "* Required!";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(555, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "* Required!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Library Card No.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(190, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Student Name";
            // 
            // LibraryCardNoTextBox
            // 
            this.LibraryCardNoTextBox.Location = new System.Drawing.Point(290, 244);
            this.LibraryCardNoTextBox.Multiline = true;
            this.LibraryCardNoTextBox.Name = "LibraryCardNoTextBox";
            this.LibraryCardNoTextBox.Size = new System.Drawing.Size(259, 36);
            this.LibraryCardNoTextBox.TabIndex = 16;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(288, 103);
            this.StudentNameTextBox.Multiline = true;
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(258, 31);
            this.StudentNameTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(557, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "* Required!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(285, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Student Id already exist";
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Location = new System.Drawing.Point(288, 50);
            this.StudentIdTextBox.Multiline = true;
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(258, 33);
            this.StudentIdTextBox.TabIndex = 12;
            this.StudentIdTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StudentIdTextBox_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(555, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "* Required!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(555, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "* Required!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(374, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "* Required!";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(17, 200);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(1029, 394);
            this.StudentGridView.TabIndex = 10;
            this.StudentGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentGridView_CellMouseClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436386534_update1;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshButton.Location = new System.Drawing.Point(253, 603);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(43, 37);
            this.RefreshButton.TabIndex = 18;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LastPageButton
            // 
            this.LastPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436386527_resultset_last;
            this.LastPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LastPageButton.Location = new System.Drawing.Point(189, 603);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.Size = new System.Drawing.Size(43, 37);
            this.LastPageButton.TabIndex = 17;
            this.LastPageButton.UseVisualStyleBackColor = true;
            this.LastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436478826_resultset_next;
            this.NextPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextPageButton.Location = new System.Drawing.Point(136, 603);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(36, 37);
            this.NextPageButton.TabIndex = 16;
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436478790_resultset_previous;
            this.PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PreviousButton.Location = new System.Drawing.Point(79, 603);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(35, 37);
            this.PreviousButton.TabIndex = 15;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // FirstPageButton
            // 
            this.FirstPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436386564_resultset_first;
            this.FirstPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FirstPageButton.Location = new System.Drawing.Point(16, 603);
            this.FirstPageButton.Name = "FirstPageButton";
            this.FirstPageButton.Size = new System.Drawing.Size(43, 37);
            this.FirstPageButton.TabIndex = 14;
            this.FirstPageButton.UseVisualStyleBackColor = true;
            this.FirstPageButton.Click += new System.EventHandler(this.FirstPageButton_Click);
            // 
            // StudentDeleteButton
            // 
            this.StudentDeleteButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.icon_delete;
            this.StudentDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StudentDeleteButton.Location = new System.Drawing.Point(371, 600);
            this.StudentDeleteButton.Name = "StudentDeleteButton";
            this.StudentDeleteButton.Size = new System.Drawing.Size(54, 40);
            this.StudentDeleteButton.TabIndex = 19;
            this.StudentDeleteButton.UseVisualStyleBackColor = true;
            this.StudentDeleteButton.Click += new System.EventHandler(this.StudentDeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(1058, 34);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(1058, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 34);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitAddToolStripMenuItem});
            this.studentToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.add;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(57, 30);
            this.studentToolStripMenuItem.Text = "Add";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "New Student";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // exitAddToolStripMenuItem
            // 
            this.exitAddToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.close_blue;
            this.exitAddToolStripMenuItem.Name = "exitAddToolStripMenuItem";
            this.exitAddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitAddToolStripMenuItem.Text = "Exit Add";
            this.exitAddToolStripMenuItem.Click += new System.EventHandler(this.exitAddToolStripMenuItem_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(658, 153);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(118, 41);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(138, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Search By ID";
            // 
            // StudentSearctBox
            // 
            this.StudentSearctBox.Location = new System.Drawing.Point(305, 153);
            this.StudentSearctBox.Multiline = true;
            this.StudentSearctBox.Name = "StudentSearctBox";
            this.StudentSearctBox.Size = new System.Drawing.Size(347, 41);
            this.StudentSearctBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(797, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "* Please Enter Student  ID ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(876, 603);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(525, 603);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "label12";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.library_management_system_1_638;
            this.pictureBox1.Location = new System.Drawing.Point(17, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::LibraryManagementSystem.Properties.Resources.Close3a;
            this.pictureBox3.Location = new System.Drawing.Point(1023, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // StudentInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 661);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StudentSearctBox);
            this.Controls.Add(this.StudentDeleteButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.LastPageButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.FirstPageButton);
            this.Controls.Add(this.StudentAddForm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StudentGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentInsertForm";
            this.Text = "StudentInsertForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentInsertForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentInsertForm_Load);
            this.Resize += new System.EventHandler(this.StudentInsertForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.StudentAddForm.ResumeLayout(false);
            this.StudentAddForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuidentImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentAddButton;
        private SessionDataSet sessionDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private SessionDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ComboBox SessionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox StudentAddForm;
       // private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
      //  private LibraryDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.Label label7;
   //     private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
      //  private LibraryDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button LastPageButton;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button FirstPageButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StudentDeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAddToolStripMenuItem;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox StudentSearctBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox LibraryCardNoTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button STudentImageUploadButton;
        private System.Windows.Forms.PictureBox StuidentImageBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}