namespace LibraryManagementSystem
{
    partial class DepartmentAddForm
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
            this.departmentAddBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Department_Full_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Department_Sgort_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.DepartmentAddButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DepartmentDeleteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.LastPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.FirstPageButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.departmentAddBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentAddBox
            // 
            this.departmentAddBox.BackColor = System.Drawing.Color.Transparent;
            this.departmentAddBox.Controls.Add(this.label9);
            this.departmentAddBox.Controls.Add(this.label8);
            this.departmentAddBox.Controls.Add(this.label3);
            this.departmentAddBox.Controls.Add(this.label2);
            this.departmentAddBox.Controls.Add(this.Department_Full_Name_Text_Box);
            this.departmentAddBox.Controls.Add(this.label1);
            this.departmentAddBox.Controls.Add(this.Department_Sgort_Name_Text_Box);
            this.departmentAddBox.Controls.Add(this.DepartmentAddButton);
            this.departmentAddBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentAddBox.ForeColor = System.Drawing.Color.Black;
            this.departmentAddBox.Location = new System.Drawing.Point(12, 150);
            this.departmentAddBox.Name = "departmentAddBox";
            this.departmentAddBox.Size = new System.Drawing.Size(840, 242);
            this.departmentAddBox.TabIndex = 0;
            this.departmentAddBox.TabStop = false;
            this.departmentAddBox.Text = "Add Department";
            this.departmentAddBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(264, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(341, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "*  Department Full Name already exist";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(264, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "* Department Short Name already exist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(701, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "* Required!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department Full Name";
            // 
            // Department_Full_Name_Text_Box
            // 
            this.Department_Full_Name_Text_Box.Location = new System.Drawing.Point(236, 109);
            this.Department_Full_Name_Text_Box.Multiline = true;
            this.Department_Full_Name_Text_Box.Name = "Department_Full_Name_Text_Box";
            this.Department_Full_Name_Text_Box.Size = new System.Drawing.Size(459, 39);
            this.Department_Full_Name_Text_Box.TabIndex = 3;
            this.Department_Full_Name_Text_Box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Department_Full_Name_Text_Box_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department Short Name";
            // 
            // Department_Sgort_Name_Text_Box
            // 
            this.Department_Sgort_Name_Text_Box.Location = new System.Drawing.Point(236, 49);
            this.Department_Sgort_Name_Text_Box.Multiline = true;
            this.Department_Sgort_Name_Text_Box.Name = "Department_Sgort_Name_Text_Box";
            this.Department_Sgort_Name_Text_Box.Size = new System.Drawing.Size(215, 39);
            this.Department_Sgort_Name_Text_Box.TabIndex = 1;
            // 
            // DepartmentAddButton
            // 
            this.DepartmentAddButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DepartmentAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DepartmentAddButton.ForeColor = System.Drawing.Color.White;
            this.DepartmentAddButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DepartmentAddButton.Location = new System.Drawing.Point(256, 184);
            this.DepartmentAddButton.Name = "DepartmentAddButton";
            this.DepartmentAddButton.Size = new System.Drawing.Size(171, 40);
            this.DepartmentAddButton.TabIndex = 0;
            this.DepartmentAddButton.Text = "Add Department";
            this.DepartmentAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DepartmentAddButton.UseVisualStyleBackColor = false;
            this.DepartmentAddButton.Click += new System.EventHandler(this.DepartmentAddButton_Click);
            this.DepartmentAddButton.MouseLeave += new System.EventHandler(this.DepartmentAddButton_MouseLeave);
            this.DepartmentAddButton.MouseHover += new System.EventHandler(this.DepartmentAddButton_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 371);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // DepartmentDeleteButton
            // 
            this.DepartmentDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DepartmentDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DepartmentDeleteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentDeleteButton.ForeColor = System.Drawing.SystemColors.Info;
            this.DepartmentDeleteButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DepartmentDeleteButton.Location = new System.Drawing.Point(496, 577);
            this.DepartmentDeleteButton.Name = "DepartmentDeleteButton";
            this.DepartmentDeleteButton.Size = new System.Drawing.Size(138, 33);
            this.DepartmentDeleteButton.TabIndex = 9;
            this.DepartmentDeleteButton.Text = "Delete Selected Item";
            this.DepartmentDeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DepartmentDeleteButton.UseVisualStyleBackColor = false;
            this.DepartmentDeleteButton.Click += new System.EventHandler(this.DepartmentDeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RefreshButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshButton.Location = new System.Drawing.Point(453, 582);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(30, 23);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NextPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.metro_icon_right___Copy;
            this.NextPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextPageButton.Location = new System.Drawing.Point(323, 582);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(35, 23);
            this.NextPageButton.TabIndex = 7;
            this.NextPageButton.UseVisualStyleBackColor = false;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // LastPageButton
            // 
            this.LastPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LastPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.metro_icon_last;
            this.LastPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LastPageButton.Location = new System.Drawing.Point(391, 582);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.Size = new System.Drawing.Size(36, 23);
            this.LastPageButton.TabIndex = 6;
            this.LastPageButton.UseVisualStyleBackColor = false;
            this.LastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PreviousPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.metro_icon_left;
            this.PreviousPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PreviousPageButton.Location = new System.Drawing.Point(256, 582);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(35, 23);
            this.PreviousPageButton.TabIndex = 5;
            this.PreviousPageButton.UseVisualStyleBackColor = false;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // FirstPageButton
            // 
            this.FirstPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FirstPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.metro_icon_first;
            this.FirstPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FirstPageButton.Location = new System.Drawing.Point(185, 582);
            this.FirstPageButton.Name = "FirstPageButton";
            this.FirstPageButton.Size = new System.Drawing.Size(36, 23);
            this.FirstPageButton.TabIndex = 4;
            this.FirstPageButton.UseVisualStyleBackColor = false;
            this.FirstPageButton.Click += new System.EventHandler(this.FirstPageButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(864, 34);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(864, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 34);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDepartmentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.addToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.add;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(57, 30);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewDepartmentToolStripMenuItem
            // 
            this.addNewDepartmentToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.add;
            this.addNewDepartmentToolStripMenuItem.Name = "addNewDepartmentToolStripMenuItem";
            this.addNewDepartmentToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addNewDepartmentToolStripMenuItem.Text = "Add New Department";
            this.addNewDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addNewDepartmentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.close_blue;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.library_management_system_1_638;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::LibraryManagementSystem.Properties.Resources.Close3a;
            this.pictureBox3.Location = new System.Drawing.Point(828, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // DepartmentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 629);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DepartmentDeleteButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.LastPageButton);
            this.Controls.Add(this.PreviousPageButton);
            this.Controls.Add(this.FirstPageButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.departmentAddBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DepartmentAddForm";
            this.Text = "DepartmentAddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentAddForm_FormClosed);
            this.Load += new System.EventHandler(this.DepartmentInsertForm_Load);
            this.Resize += new System.EventHandler(this.DepartmentInsertForm_Resize);
            this.departmentAddBox.ResumeLayout(false);
            this.departmentAddBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox departmentAddBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Department_Full_Name_Text_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Department_Sgort_Name_Text_Box;
        private System.Windows.Forms.Button DepartmentAddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FirstPageButton;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.Button LastPageButton;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DepartmentDeleteButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}