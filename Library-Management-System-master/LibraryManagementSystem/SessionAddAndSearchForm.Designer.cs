namespace LibraryManagementSystem
{
    partial class SessionAddAndSearchForm
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
            this.sessionAddBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SessionTextBox = new System.Windows.Forms.TextBox();
            this.SessionAddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionDataSet = new LibraryManagementSystem.SessionDataSet();
            this.sessionTableAdapter = new LibraryManagementSystem.SessionDataSetTableAdapters.SessionTableAdapter();
            this.SessionDeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sessionAddBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionAddBox
            // 
            this.sessionAddBox.BackColor = System.Drawing.Color.White;
            this.sessionAddBox.Controls.Add(this.label7);
            this.sessionAddBox.Controls.Add(this.label6);
            this.sessionAddBox.Controls.Add(this.label5);
            this.sessionAddBox.Controls.Add(this.SessionTextBox);
            this.sessionAddBox.Controls.Add(this.SessionAddButton);
            this.sessionAddBox.Controls.Add(this.label4);
            this.sessionAddBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sessionAddBox.ForeColor = System.Drawing.Color.Black;
            this.sessionAddBox.Location = new System.Drawing.Point(46, 164);
            this.sessionAddBox.Name = "sessionAddBox";
            this.sessionAddBox.Size = new System.Drawing.Size(840, 193);
            this.sessionAddBox.TabIndex = 4;
            this.sessionAddBox.TabStop = false;
            this.sessionAddBox.Text = "Add Session";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(632, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "* Invalid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(259, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "* Session already exist!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(632, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "* Required!";
            // 
            // SessionTextBox
            // 
            this.SessionTextBox.Location = new System.Drawing.Point(250, 53);
            this.SessionTextBox.Multiline = true;
            this.SessionTextBox.Name = "SessionTextBox";
            this.SessionTextBox.Size = new System.Drawing.Size(376, 35);
            this.SessionTextBox.TabIndex = 2;
            this.SessionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SessionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SessionTextBox_KeyUp);
            // 
            // SessionAddButton
            // 
            this.SessionAddButton.BackColor = System.Drawing.Color.White;
            this.SessionAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SessionAddButton.ForeColor = System.Drawing.Color.White;
            this.SessionAddButton.Location = new System.Drawing.Point(250, 106);
            this.SessionAddButton.Name = "SessionAddButton";
            this.SessionAddButton.Size = new System.Drawing.Size(177, 42);
            this.SessionAddButton.TabIndex = 1;
            this.SessionAddButton.Text = "Add Session";
            this.SessionAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SessionAddButton.UseVisualStyleBackColor = false;
            this.SessionAddButton.Click += new System.EventHandler(this.SessionAddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Session";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIdDataGridViewTextBoxColumn,
            this.sessionNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 356);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // sessionIdDataGridViewTextBoxColumn
            // 
            this.sessionIdDataGridViewTextBoxColumn.DataPropertyName = "SessionId";
            this.sessionIdDataGridViewTextBoxColumn.HeaderText = "SessionId";
            this.sessionIdDataGridViewTextBoxColumn.Name = "sessionIdDataGridViewTextBoxColumn";
            this.sessionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionNameDataGridViewTextBoxColumn
            // 
            this.sessionNameDataGridViewTextBoxColumn.DataPropertyName = "SessionName";
            this.sessionNameDataGridViewTextBoxColumn.HeaderText = "SessionName";
            this.sessionNameDataGridViewTextBoxColumn.Name = "sessionNameDataGridViewTextBoxColumn";
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.sessionDataSet;
            // 
            // sessionDataSet
            // 
            this.sessionDataSet.DataSetName = "SessionDataSet";
            this.sessionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // SessionDeleteButton
            // 
            this.SessionDeleteButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.icon_delete;
            this.SessionDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SessionDeleteButton.Location = new System.Drawing.Point(416, 526);
            this.SessionDeleteButton.Name = "SessionDeleteButton";
            this.SessionDeleteButton.Size = new System.Drawing.Size(57, 37);
            this.SessionDeleteButton.TabIndex = 6;
            this.SessionDeleteButton.UseVisualStyleBackColor = true;
            this.SessionDeleteButton.Click += new System.EventHandler(this.SessionDeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(894, 34);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(894, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 34);
            this.menuStrip1.TabIndex = 8;
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSessionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.addToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.add;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(57, 30);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addSessionToolStripMenuItem
            // 
            this.addSessionToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.add;
            this.addSessionToolStripMenuItem.Name = "addSessionToolStripMenuItem";
            this.addSessionToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addSessionToolStripMenuItem.Text = "Add Session";
            this.addSessionToolStripMenuItem.Click += new System.EventHandler(this.addSessionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.close_blue;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.library_management_system_1_638;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::LibraryManagementSystem.Properties.Resources.Close3a;
            this.pictureBox3.Location = new System.Drawing.Point(858, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // SessionAddAndSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 577);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SessionDeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sessionAddBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionAddAndSearchForm";
            this.Text = "SessionAddAndSearchForm";
            this.AutoSizeChanged += new System.EventHandler(this.SessionAddAndSearchForm_AutoSizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SessionAddAndSearchForm_FormClosed);
            this.Load += new System.EventHandler(this.SessionAddAndSearchForm_Load);
            this.Resize += new System.EventHandler(this.SessionAddAndSearchForm_Resize);
            this.sessionAddBox.ResumeLayout(false);
            this.sessionAddBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sessionAddBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SessionTextBox;
        private System.Windows.Forms.Button SessionAddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SessionDataSet sessionDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private SessionDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SessionDeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}