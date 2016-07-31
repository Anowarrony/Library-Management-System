namespace LibraryManagementSystem
{
    partial class BookSearchForm
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
            this.BooksGridView = new System.Windows.Forms.DataGridView();
            this.BookSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BookSearctBox = new System.Windows.Forms.TextBox();
            this.updateBox = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SelfTextBox = new System.Windows.Forms.TextBox();
            this.UpdateSaveButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.EditionTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LibraryTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookDeleteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LastPageButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.FirstPageButton = new System.Windows.Forms.Button();
            this.BookSearchFormPanel = new System.Windows.Forms.Panel();
            this.bookdetailsButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).BeginInit();
            this.BookSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.updateBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.BookSearchFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksGridView
            // 
            this.BooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGridView.Location = new System.Drawing.Point(12, 240);
            this.BooksGridView.Name = "BooksGridView";
            this.BooksGridView.Size = new System.Drawing.Size(1051, 430);
            this.BooksGridView.TabIndex = 0;
            this.BooksGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BooksGridView_CellMouseClick);
            // 
            // BookSearchGroupBox
            // 
            this.BookSearchGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.BookSearchGroupBox.Controls.Add(this.pictureBox1);
            this.BookSearchGroupBox.Controls.Add(this.label7);
            this.BookSearchGroupBox.Controls.Add(this.SearchButton);
            this.BookSearchGroupBox.Controls.Add(this.label5);
            this.BookSearchGroupBox.Controls.Add(this.BookSearctBox);
            this.BookSearchGroupBox.Location = new System.Drawing.Point(12, 140);
            this.BookSearchGroupBox.Name = "BookSearchGroupBox";
            this.BookSearchGroupBox.Size = new System.Drawing.Size(1040, 86);
            this.BookSearchGroupBox.TabIndex = 1;
            this.BookSearchGroupBox.TabStop = false;
            this.BookSearchGroupBox.Text = "Search Book";
            this.BookSearchGroupBox.Enter += new System.EventHandler(this.BookSearchGroupBox_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(23, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(666, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "* Please Enter Book\'s ISBN to Search";
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(566, 17);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(86, 41);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.SearchButton.MouseLeave += new System.EventHandler(this.SearchButton_MouseLeave);
            this.SearchButton.MouseHover += new System.EventHandler(this.SearchButton_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(42, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search By ISBN";
            // 
            // BookSearctBox
            // 
            this.BookSearctBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookSearctBox.Location = new System.Drawing.Point(196, 19);
            this.BookSearctBox.Multiline = true;
            this.BookSearctBox.Name = "BookSearctBox";
            this.BookSearctBox.Size = new System.Drawing.Size(347, 41);
            this.BookSearctBox.TabIndex = 1;
            this.BookSearctBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BookSearctBox_KeyUp);
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.Color.Transparent;
            this.updateBox.Controls.Add(this.label24);
            this.updateBox.Controls.Add(this.label25);
            this.updateBox.Controls.Add(this.label26);
            this.updateBox.Controls.Add(this.SelfTextBox);
            this.updateBox.Controls.Add(this.UpdateSaveButton);
            this.updateBox.Controls.Add(this.label23);
            this.updateBox.Controls.Add(this.label15);
            this.updateBox.Controls.Add(this.label20);
            this.updateBox.Controls.Add(this.EditionTextBox);
            this.updateBox.Controls.Add(this.label22);
            this.updateBox.Controls.Add(this.label21);
            this.updateBox.Controls.Add(this.label19);
            this.updateBox.Controls.Add(this.label18);
            this.updateBox.Controls.Add(this.label17);
            this.updateBox.Controls.Add(this.label16);
            this.updateBox.Controls.Add(this.label9);
            this.updateBox.Controls.Add(this.label8);
            this.updateBox.Controls.Add(this.label6);
            this.updateBox.Controls.Add(this.label10);
            this.updateBox.Controls.Add(this.LibraryTextBox);
            this.updateBox.Controls.Add(this.AmountTextBox);
            this.updateBox.Controls.Add(this.IsbnTextBox);
            this.updateBox.Controls.Add(this.PageTextBox);
            this.updateBox.Controls.Add(this.label14);
            this.updateBox.Controls.Add(this.label13);
            this.updateBox.Controls.Add(this.label12);
            this.updateBox.Controls.Add(this.label11);
            this.updateBox.Controls.Add(this.label4);
            this.updateBox.Controls.Add(this.label3);
            this.updateBox.Controls.Add(this.label2);
            this.updateBox.Controls.Add(this.label1);
            this.updateBox.Controls.Add(this.PublisherTextBox);
            this.updateBox.Controls.Add(this.AuthorTextBox);
            this.updateBox.Controls.Add(this.TitleTextBox);
            this.updateBox.Controls.Add(this.SubjectTextBox);
            this.updateBox.Location = new System.Drawing.Point(18, 140);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(1020, 345);
            this.updateBox.TabIndex = 11;
            this.updateBox.TabStop = false;
            this.updateBox.Text = "Update Book ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(759, 244);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 63;
            this.label24.Text = "* Invalid!";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(747, 244);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 62;
            this.label25.Text = "* Required!";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(419, 244);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 13);
            this.label26.TabIndex = 61;
            this.label26.Text = "Self No.";
            // 
            // SelfTextBox
            // 
            this.SelfTextBox.Location = new System.Drawing.Point(515, 241);
            this.SelfTextBox.Multiline = true;
            this.SelfTextBox.Name = "SelfTextBox";
            this.SelfTextBox.Size = new System.Drawing.Size(226, 27);
            this.SelfTextBox.TabIndex = 60;
            this.SelfTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelfTextBox_KeyUp);
            // 
            // UpdateSaveButton
            // 
            this.UpdateSaveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.UpdateSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateSaveButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateSaveButton.ForeColor = System.Drawing.Color.White;
            this.UpdateSaveButton.Location = new System.Drawing.Point(515, 287);
            this.UpdateSaveButton.Name = "UpdateSaveButton";
            this.UpdateSaveButton.Size = new System.Drawing.Size(226, 42);
            this.UpdateSaveButton.TabIndex = 59;
            this.UpdateSaveButton.Text = "Save";
            this.UpdateSaveButton.UseVisualStyleBackColor = false;
            this.UpdateSaveButton.Click += new System.EventHandler(this.UpdateSaveButton_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(344, 207);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 58;
            this.label23.Text = "* Invalid!";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(344, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "* Required!";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 210);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "Edition";
            // 
            // EditionTextBox
            // 
            this.EditionTextBox.Location = new System.Drawing.Point(112, 207);
            this.EditionTextBox.Multiline = true;
            this.EditionTextBox.Name = "EditionTextBox";
            this.EditionTextBox.Size = new System.Drawing.Size(226, 27);
            this.EditionTextBox.TabIndex = 55;
            this.EditionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditionTextBox_KeyUp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(747, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 53;
            this.label22.Text = "* Invalid!";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(747, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "* Invalid";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(747, 192);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "* Required!";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(747, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "* Required!";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(747, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "* Required!";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(747, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "* Required!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Library";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "ISBN No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Pages";
            // 
            // LibraryTextBox
            // 
            this.LibraryTextBox.Location = new System.Drawing.Point(515, 189);
            this.LibraryTextBox.Multiline = true;
            this.LibraryTextBox.Name = "LibraryTextBox";
            this.LibraryTextBox.Size = new System.Drawing.Size(226, 27);
            this.LibraryTextBox.TabIndex = 41;
            this.LibraryTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LibraryTextBox_KeyUp);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(515, 134);
            this.AmountTextBox.Multiline = true;
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(226, 27);
            this.AmountTextBox.TabIndex = 40;
            this.AmountTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AmountTextBox_KeyUp);
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(515, 76);
            this.IsbnTextBox.Multiline = true;
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(226, 27);
            this.IsbnTextBox.TabIndex = 39;
            this.IsbnTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IsbnTextBox_KeyUp);
            // 
            // PageTextBox
            // 
            this.PageTextBox.Location = new System.Drawing.Point(515, 20);
            this.PageTextBox.Multiline = true;
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.Size = new System.Drawing.Size(226, 27);
            this.PageTextBox.TabIndex = 38;
            this.PageTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PageTextBox_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(344, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "* Required!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(344, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "* Required!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(344, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "* Required!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(344, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "* Required!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Subject";
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(112, 149);
            this.PublisherTextBox.Multiline = true;
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(226, 27);
            this.PublisherTextBox.TabIndex = 28;
            this.PublisherTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PublisherTextBox_KeyUp);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(112, 107);
            this.AuthorTextBox.Multiline = true;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(226, 27);
            this.AuthorTextBox.TabIndex = 27;
            this.AuthorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AuthorTextBox_KeyUp);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(112, 62);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(226, 27);
            this.TitleTextBox.TabIndex = 26;
            this.TitleTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TitleTextBox_KeyUp);
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(112, 19);
            this.SubjectTextBox.Multiline = true;
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(226, 27);
            this.SubjectTextBox.TabIndex = 25;
            this.SubjectTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SubjectTextBox_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewBookToolStripMenuItem,
            this.editBookDetailsToolStripMenuItem,
            this.searchReservationToolStripMenuItem,
            this.issueBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(1073, 34);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(1073, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 34);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // insertNewBookToolStripMenuItem
            // 
      
            this.insertNewBookToolStripMenuItem.Name = "insertNewBookToolStripMenuItem";
            this.insertNewBookToolStripMenuItem.Size = new System.Drawing.Size(121, 30);
            this.insertNewBookToolStripMenuItem.Text = "Insert New Book";
            this.insertNewBookToolStripMenuItem.Click += new System.EventHandler(this.insertNewBookToolStripMenuItem_Click);
            // 
            // editBookDetailsToolStripMenuItem
            // 
            this.editBookDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBookDetailsToolStripMenuItem1,
            this.exitEditToolStripMenuItem});
            this.editBookDetailsToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.icon_edit;
            this.editBookDetailsToolStripMenuItem.Name = "editBookDetailsToolStripMenuItem";
            this.editBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
            this.editBookDetailsToolStripMenuItem.Text = "Edit";
            this.editBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.editBookDetailsToolStripMenuItem_Click);
            // 
            // editBookDetailsToolStripMenuItem1
            // 
            this.editBookDetailsToolStripMenuItem1.Name = "editBookDetailsToolStripMenuItem1";
            this.editBookDetailsToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.editBookDetailsToolStripMenuItem1.Text = "Edit Book Details";
            this.editBookDetailsToolStripMenuItem1.Click += new System.EventHandler(this.editBookDetailsToolStripMenuItem1_Click);
            // 
            // exitEditToolStripMenuItem
            // 
            this.exitEditToolStripMenuItem.Name = "exitEditToolStripMenuItem";
            this.exitEditToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitEditToolStripMenuItem.Text = "Exit Edit";
            this.exitEditToolStripMenuItem.Click += new System.EventHandler(this.exitEditToolStripMenuItem_Click);
            // 
            // searchReservationToolStripMenuItem
            // 
            this.searchReservationToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.search;
            this.searchReservationToolStripMenuItem.Name = "searchReservationToolStripMenuItem";
            this.searchReservationToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.searchReservationToolStripMenuItem.Text = "Search Reservation";
            this.searchReservationToolStripMenuItem.Click += new System.EventHandler(this.searchReservationToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources._1436478871_book_edit;
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(91, 30);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // BookDeleteButton
            // 
            this.BookDeleteButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.icon_delete;
            this.BookDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BookDeleteButton.Location = new System.Drawing.Point(307, 7);
            this.BookDeleteButton.Name = "BookDeleteButton";
            this.BookDeleteButton.Size = new System.Drawing.Size(46, 37);
            this.BookDeleteButton.TabIndex = 13;
            this.BookDeleteButton.UseVisualStyleBackColor = true;
            this.BookDeleteButton.Click += new System.EventHandler(this.BookDeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436386534_update1;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshButton.Location = new System.Drawing.Point(247, 6);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(41, 37);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LastPageButton
            // 
            this.LastPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436386527_resultset_last;
            this.LastPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LastPageButton.Location = new System.Drawing.Point(185, 6);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.Size = new System.Drawing.Size(41, 37);
            this.LastPageButton.TabIndex = 8;
            this.LastPageButton.UseVisualStyleBackColor = true;
            this.LastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436478826_resultset_next;
            this.NextPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextPageButton.Location = new System.Drawing.Point(132, 6);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(34, 37);
            this.NextPageButton.TabIndex = 7;
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436478790_resultset_previous;
            this.PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PreviousButton.Location = new System.Drawing.Point(75, 6);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(33, 37);
            this.PreviousButton.TabIndex = 6;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // FirstPageButton
            // 
            this.FirstPageButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources._1436386564_resultset_first;
            this.FirstPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FirstPageButton.Location = new System.Drawing.Point(12, 6);
            this.FirstPageButton.Name = "FirstPageButton";
            this.FirstPageButton.Size = new System.Drawing.Size(41, 37);
            this.FirstPageButton.TabIndex = 5;
            this.FirstPageButton.UseVisualStyleBackColor = true;
            this.FirstPageButton.Click += new System.EventHandler(this.FirstPageButton_Click);
            // 
            // BookSearchFormPanel
            // 
            this.BookSearchFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.BookSearchFormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BookSearchFormPanel.Controls.Add(this.bookdetailsButton);
            this.BookSearchFormPanel.Controls.Add(this.LastPageButton);
            this.BookSearchFormPanel.Controls.Add(this.BookDeleteButton);
            this.BookSearchFormPanel.Controls.Add(this.FirstPageButton);
            this.BookSearchFormPanel.Controls.Add(this.PreviousButton);
            this.BookSearchFormPanel.Controls.Add(this.NextPageButton);
            this.BookSearchFormPanel.Controls.Add(this.RefreshButton);
            this.BookSearchFormPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookSearchFormPanel.Location = new System.Drawing.Point(12, 676);
            this.BookSearchFormPanel.Name = "BookSearchFormPanel";
            this.BookSearchFormPanel.Size = new System.Drawing.Size(426, 51);
            this.BookSearchFormPanel.TabIndex = 14;
            // 
            // bookdetailsButton
            // 
            this.bookdetailsButton.Location = new System.Drawing.Point(359, 7);
            this.bookdetailsButton.Name = "bookdetailsButton";
            this.bookdetailsButton.Size = new System.Drawing.Size(56, 37);
            this.bookdetailsButton.TabIndex = 14;
            this.bookdetailsButton.Text = "Details";
            this.bookdetailsButton.UseVisualStyleBackColor = true;
            this.bookdetailsButton.Click += new System.EventHandler(this.bookdetailsButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.library_management_system_1_638;
            this.pictureBox2.Location = new System.Drawing.Point(12, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1051, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::LibraryManagementSystem.Properties.Resources.Close3a;
            this.pictureBox3.Location = new System.Drawing.Point(1036, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // BookSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.apple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 738);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BookSearchFormPanel);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.BookSearchGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BooksGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookSearchForm";
            this.Text = "BookSearchForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookSearchForm_FormClosed);
            this.Load += new System.EventHandler(this.BookSearchForm_Load);
            this.Resize += new System.EventHandler(this.BookSearchForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).EndInit();
            this.BookSearchGroupBox.ResumeLayout(false);
            this.BookSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.updateBox.ResumeLayout(false);
            this.updateBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BookSearchFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksGridView;
        private System.Windows.Forms.GroupBox BookSearchGroupBox;
        private System.Windows.Forms.TextBox BookSearctBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FirstPageButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button LastPageButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox updateBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox EditionTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LibraryTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.TextBox PageTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox SelfTextBox;
        private System.Windows.Forms.Button UpdateSaveButton;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitEditToolStripMenuItem;
        private System.Windows.Forms.Button BookDeleteButton;
        private System.Windows.Forms.ToolStripMenuItem searchReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BookSearchFormPanel;
        private System.Windows.Forms.Button bookdetailsButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}