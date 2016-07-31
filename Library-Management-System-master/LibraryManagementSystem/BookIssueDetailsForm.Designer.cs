namespace LibraryManagementSystem
{
    partial class BookIssueDetailsForm
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
            this.BookReservationDetailsView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ReservationSearchTextBox = new System.Windows.Forms.TextBox();
            this.ReservationSearchButton = new System.Windows.Forms.Button();
            this.ReservationFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ReservationRefreshButton = new System.Windows.Forms.Button();
            this.ReservationDeleteId = new System.Windows.Forms.Button();
            this.ReservationUpdateButton = new System.Windows.Forms.Button();
            this.BookissueUpdategroupBox = new System.Windows.Forms.GroupBox();
            this.ReservationEditBtn = new System.Windows.Forms.Button();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.IssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IsbnUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lFormDefineLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookIssuedetailsShowButton = new System.Windows.Forms.Button();
            this.PagingPanel = new System.Windows.Forms.Panel();
            this.BookIssuedetailsSearchPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BookissueUpdategroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PagingPanel.SuspendLayout();
            this.BookIssuedetailsSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BookReservationDetailsView
            // 
            this.BookReservationDetailsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader5});
            this.BookReservationDetailsView.Location = new System.Drawing.Point(27, 200);
            this.BookReservationDetailsView.Name = "BookReservationDetailsView";
            this.BookReservationDetailsView.Size = new System.Drawing.Size(1085, 352);
            this.BookReservationDetailsView.TabIndex = 0;
            this.BookReservationDetailsView.UseCompatibleStateImageBehavior = false;
            this.BookReservationDetailsView.View = System.Windows.Forms.View.Details;
            this.BookReservationDetailsView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.BookReservationDetailsView_ColumnClick);
            this.BookReservationDetailsView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.BookReservationDetailsView_ItemCheck);
            this.BookReservationDetailsView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.BookReservationDetailsView_ItemChecked);
            this.BookReservationDetailsView.SelectedIndexChanged += new System.EventHandler(this.BookReservationDetailsView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Department";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Title";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 164;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ISBN";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 138;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Issue Date";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 157;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Return Date";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Days Left";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(150, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By ID";
            // 
            // ReservationSearchTextBox
            // 
            this.ReservationSearchTextBox.Location = new System.Drawing.Point(281, 12);
            this.ReservationSearchTextBox.Multiline = true;
            this.ReservationSearchTextBox.Name = "ReservationSearchTextBox";
            this.ReservationSearchTextBox.Size = new System.Drawing.Size(274, 49);
            this.ReservationSearchTextBox.TabIndex = 2;
            this.ReservationSearchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ReservationSearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReservationSearchTextBox_KeyUp);
            // 
            // ReservationSearchButton
            // 
            this.ReservationSearchButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservationSearchButton.Location = new System.Drawing.Point(580, 12);
            this.ReservationSearchButton.Name = "ReservationSearchButton";
            this.ReservationSearchButton.Size = new System.Drawing.Size(92, 49);
            this.ReservationSearchButton.TabIndex = 4;
            this.ReservationSearchButton.Text = "Search";
            this.ReservationSearchButton.UseVisualStyleBackColor = true;
            this.ReservationSearchButton.Click += new System.EventHandler(this.ReservationSearchButton_Click);
            // 
            // ReservationFilterComboBox
            // 
            this.ReservationFilterComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReservationFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReservationFilterComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationFilterComboBox.FormattingEnabled = true;
            this.ReservationFilterComboBox.Items.AddRange(new object[] {
            "Expired",
            "Unexpired"});
            this.ReservationFilterComboBox.Location = new System.Drawing.Point(179, 13);
            this.ReservationFilterComboBox.Name = "ReservationFilterComboBox";
            this.ReservationFilterComboBox.Size = new System.Drawing.Size(89, 24);
            this.ReservationFilterComboBox.TabIndex = 5;
            this.ReservationFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.ReservationFilterComboBox_SelectedIndexChanged);
            this.ReservationFilterComboBox.DropDownClosed += new System.EventHandler(this.ReservationFilterComboBox_DropDownClosed);
            this.ReservationFilterComboBox.MouseLeave += new System.EventHandler(this.ReservationFilterComboBox_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(103, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter For";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLabel.ForeColor = System.Drawing.Color.Black;
            this.CountLabel.Location = new System.Drawing.Point(519, 17);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(45, 16);
            this.CountLabel.TabIndex = 7;
            this.CountLabel.Text = "label3";
            // 
            // ReservationRefreshButton
            // 
            this.ReservationRefreshButton.Image = global::LibraryManagementSystem.Properties.Resources.refresh;
            this.ReservationRefreshButton.Location = new System.Drawing.Point(36, 10);
            this.ReservationRefreshButton.Name = "ReservationRefreshButton";
            this.ReservationRefreshButton.Size = new System.Drawing.Size(45, 28);
            this.ReservationRefreshButton.TabIndex = 8;
            this.ReservationRefreshButton.TabStop = false;
            this.ReservationRefreshButton.UseVisualStyleBackColor = true;
            this.ReservationRefreshButton.Click += new System.EventHandler(this.ReservationRefreshButton_Click);
            // 
            // ReservationDeleteId
            // 
            this.ReservationDeleteId.Image = global::LibraryManagementSystem.Properties.Resources.icon_delete;
            this.ReservationDeleteId.Location = new System.Drawing.Point(313, 3);
            this.ReservationDeleteId.Name = "ReservationDeleteId";
            this.ReservationDeleteId.Size = new System.Drawing.Size(44, 38);
            this.ReservationDeleteId.TabIndex = 9;
            this.ReservationDeleteId.UseVisualStyleBackColor = true;
            this.ReservationDeleteId.Click += new System.EventHandler(this.ReservationDeleteId_Click);
            // 
            // ReservationUpdateButton
            // 
            this.ReservationUpdateButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.software_update;
            this.ReservationUpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReservationUpdateButton.Location = new System.Drawing.Point(379, 3);
            this.ReservationUpdateButton.Name = "ReservationUpdateButton";
            this.ReservationUpdateButton.Size = new System.Drawing.Size(46, 38);
            this.ReservationUpdateButton.TabIndex = 26;
            this.ReservationUpdateButton.UseVisualStyleBackColor = true;
            this.ReservationUpdateButton.Click += new System.EventHandler(this.ReservationUpdateButton_Click);
            // 
            // BookissueUpdategroupBox
            // 
            this.BookissueUpdategroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.BookissueUpdategroupBox.Controls.Add(this.ReservationEditBtn);
            this.BookissueUpdategroupBox.Controls.Add(this.ReturnDatePicker);
            this.BookissueUpdategroupBox.Controls.Add(this.IssueDatePicker);
            this.BookissueUpdategroupBox.Controls.Add(this.label5);
            this.BookissueUpdategroupBox.Controls.Add(this.label6);
            this.BookissueUpdategroupBox.Controls.Add(this.IsbnUpdateTextBox);
            this.BookissueUpdategroupBox.Controls.Add(this.label3);
            this.BookissueUpdategroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookissueUpdategroupBox.Location = new System.Drawing.Point(27, 130);
            this.BookissueUpdategroupBox.Name = "BookissueUpdategroupBox";
            this.BookissueUpdategroupBox.Size = new System.Drawing.Size(1083, 149);
            this.BookissueUpdategroupBox.TabIndex = 27;
            this.BookissueUpdategroupBox.TabStop = false;
            this.BookissueUpdategroupBox.Text = "Update";
            // 
            // ReservationEditBtn
            // 
            this.ReservationEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReservationEditBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservationEditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReservationEditBtn.Location = new System.Drawing.Point(647, 50);
            this.ReservationEditBtn.Name = "ReservationEditBtn";
            this.ReservationEditBtn.Size = new System.Drawing.Size(113, 46);
            this.ReservationEditBtn.TabIndex = 23;
            this.ReservationEditBtn.Text = "Save";
            this.ReservationEditBtn.UseVisualStyleBackColor = false;
            this.ReservationEditBtn.Click += new System.EventHandler(this.ReservationEditBtn_Click);
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.CustomFormat = "dd-M-yy";
            this.ReturnDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDatePicker.Location = new System.Drawing.Point(381, 106);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ReturnDatePicker.TabIndex = 18;
            // 
            // IssueDatePicker
            // 
            this.IssueDatePicker.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssueDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.IssueDatePicker.CustomFormat = "dd-MM-yy";
            this.IssueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IssueDatePicker.Location = new System.Drawing.Point(381, 67);
            this.IssueDatePicker.Name = "IssueDatePicker";
            this.IssueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.IssueDatePicker.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Return Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Issue Date";
            // 
            // IsbnUpdateTextBox
            // 
            this.IsbnUpdateTextBox.Location = new System.Drawing.Point(381, 19);
            this.IsbnUpdateTextBox.Multiline = true;
            this.IsbnUpdateTextBox.Name = "IsbnUpdateTextBox";
            this.IsbnUpdateTextBox.Size = new System.Drawing.Size(200, 33);
            this.IsbnUpdateTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN No.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeUpdateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(1135, 34);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(1135, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 34);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeUpdateToolStripMenuItem
            // 
            this.closeUpdateToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.close;
            this.closeUpdateToolStripMenuItem.Name = "closeUpdateToolStripMenuItem";
            this.closeUpdateToolStripMenuItem.Size = new System.Drawing.Size(108, 30);
            this.closeUpdateToolStripMenuItem.Text = "Close Update ";
            this.closeUpdateToolStripMenuItem.Click += new System.EventHandler(this.closeUpdateToolStripMenuItem_Click);
            // 
            // lFormDefineLabel
            // 
            this.lFormDefineLabel.AutoSize = true;
            this.lFormDefineLabel.BackColor = System.Drawing.Color.Transparent;
            this.lFormDefineLabel.Location = new System.Drawing.Point(0, 525);
            this.lFormDefineLabel.Name = "lFormDefineLabel";
            this.lFormDefineLabel.Size = new System.Drawing.Size(35, 13);
            this.lFormDefineLabel.TabIndex = 29;
            this.lFormDefineLabel.Text = "label4";
            // 
            // pictureBox1
            // 
           // this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(131, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // BookIssuedetailsShowButton
            // 
            this.BookIssuedetailsShowButton.Location = new System.Drawing.Point(443, 7);
            this.BookIssuedetailsShowButton.Name = "BookIssuedetailsShowButton";
            this.BookIssuedetailsShowButton.Size = new System.Drawing.Size(53, 34);
            this.BookIssuedetailsShowButton.TabIndex = 31;
            this.BookIssuedetailsShowButton.Text = "Details";
            this.BookIssuedetailsShowButton.UseVisualStyleBackColor = true;
            this.BookIssuedetailsShowButton.Click += new System.EventHandler(this.BookIssuedetailsShowButton_Click);
            // 
            // PagingPanel
            // 
            this.PagingPanel.BackColor = System.Drawing.Color.Transparent;
            this.PagingPanel.Controls.Add(this.ReservationRefreshButton);
            this.PagingPanel.Controls.Add(this.BookIssuedetailsShowButton);
            this.PagingPanel.Controls.Add(this.ReservationFilterComboBox);
            this.PagingPanel.Controls.Add(this.label2);
            this.PagingPanel.Controls.Add(this.ReservationDeleteId);
            this.PagingPanel.Controls.Add(this.CountLabel);
            this.PagingPanel.Controls.Add(this.ReservationUpdateButton);
            this.PagingPanel.Location = new System.Drawing.Point(27, 568);
            this.PagingPanel.Name = "PagingPanel";
            this.PagingPanel.Size = new System.Drawing.Size(592, 39);
            this.PagingPanel.TabIndex = 32;
            // 
            // BookIssuedetailsSearchPanel
            // 
            this.BookIssuedetailsSearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.BookIssuedetailsSearchPanel.Controls.Add(this.ReservationSearchTextBox);
            this.BookIssuedetailsSearchPanel.Controls.Add(this.ReservationSearchButton);
            this.BookIssuedetailsSearchPanel.Controls.Add(this.pictureBox1);
            this.BookIssuedetailsSearchPanel.Controls.Add(this.label1);
            this.BookIssuedetailsSearchPanel.Location = new System.Drawing.Point(107, 120);
            this.BookIssuedetailsSearchPanel.Name = "BookIssuedetailsSearchPanel";
            this.BookIssuedetailsSearchPanel.Size = new System.Drawing.Size(717, 76);
            this.BookIssuedetailsSearchPanel.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::LibraryManagementSystem.Properties.Resources.Close3a;
            this.pictureBox3.Location = new System.Drawing.Point(1100, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.library_management_system_1_638;
            this.pictureBox2.Location = new System.Drawing.Point(27, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1083, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // BookIssueDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 696);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BookIssuedetailsSearchPanel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PagingPanel);
            this.Controls.Add(this.lFormDefineLabel);
            this.Controls.Add(this.BookissueUpdategroupBox);
            this.Controls.Add(this.BookReservationDetailsView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookIssueDetailsForm";
            this.Text = "BookIssueDetailsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookIssueDetailsForm_FormClosed);
            this.Load += new System.EventHandler(this.BookReservationDetailsForm_Load);
            this.Resize += new System.EventHandler(this.BookReservationDetailsForm_Resize);
            this.BookissueUpdategroupBox.ResumeLayout(false);
            this.BookissueUpdategroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PagingPanel.ResumeLayout(false);
            this.PagingPanel.PerformLayout();
            this.BookIssuedetailsSearchPanel.ResumeLayout(false);
            this.BookIssuedetailsSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView BookReservationDetailsView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReservationSearchTextBox;
        private System.Windows.Forms.Button ReservationSearchButton;
        private System.Windows.Forms.ComboBox ReservationFilterComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button ReservationRefreshButton;
        private System.Windows.Forms.Button ReservationDeleteId;
        private System.Windows.Forms.Button ReservationUpdateButton;
        private System.Windows.Forms.GroupBox BookissueUpdategroupBox;
        private System.Windows.Forms.TextBox IsbnUpdateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ReturnDatePicker;
        private System.Windows.Forms.DateTimePicker IssueDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReservationEditBtn;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeUpdateToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lFormDefineLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BookIssuedetailsShowButton;
        private System.Windows.Forms.Panel PagingPanel;
        private System.Windows.Forms.Panel BookIssuedetailsSearchPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}