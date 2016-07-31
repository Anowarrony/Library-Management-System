using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class BookSearchForm : Form
    {
        public BookSearchForm()
        {
            InitializeComponent();
            BackColor = Color.CornflowerBlue;
        }
        readonly SqlConnection _connection = new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;");
        readonly List<int> _emptyList = new List<int>();
        private SqlCommand _cmd1;
        private SqlCommand _cmd2;
        private SqlDataAdapter _adp1;
        DataSet _ds;
        private const int PageSize = 10;
        private int _currentPageIndex = 1;
        private int _totalPage = 0;
        List<int> _bookDeleIdList = new List<int>();
        private int _selectedId;
        private int _currentWindowHeight;
        readonly List<int> emptyList = new List<int>();
        private void BookSearchForm_Load(object sender, EventArgs e)
        {
            exitEditToolStripMenuItem.Enabled = false;
            updateBox.Hide();            
            LoadBookGridView();
            label7.Hide();
         _currentWindowHeight = Screen.FromControl(this).Bounds.Height;
         BooksGridView.Height = _currentWindowHeight - 600;
            Height = _currentWindowHeight-250;
        
            BookSearchFormPanel.Location = new Point(12, _currentWindowHeight-360);
       var buttonToolTip = new ToolTip
       {
           UseFading = true,
           UseAnimation = true,
           IsBalloon = true,
           ShowAlways = true,
           AutoPopDelay = 6000,
           InitialDelay = 100,
           ReshowDelay = 500
       };
    
       label7.Hide();
       label11.Hide();
       label12.Hide();
       label13.Hide();
       label14.Hide();
       label15.Hide();
       label16.Hide();
       label17.Hide();
       label18.Hide();
       label19.Hide();
       label25.Hide();
       label21.Hide();
       label22.Hide();
       label23.Hide(); 
       label24.Hide();
       label25.Hide();


       buttonToolTip.SetToolTip(FirstPageButton, "First Page");
       buttonToolTip.SetToolTip(NextPageButton, "Next Page");
       buttonToolTip.SetToolTip(PreviousButton, "Previous Page");
       buttonToolTip.SetToolTip(LastPageButton, "Last Page");
       buttonToolTip.SetToolTip(RefreshButton, "Reload");
       buttonToolTip.SetToolTip(BookDeleteButton, "Delete by selecting row/rows.To delete multiple items simply select row as many as your wish.");
  
        }
        private void CalculateTotalPages()
        {
            int rowCount = BooksGridView.Rows.Count - 1;
            _totalPage = rowCount / PageSize;

            if (rowCount % PageSize > 0)
                _totalPage += 1;
        }
        private DataTable GetCurrentRecords(int page, SqlConnection con,int? searchId)
        {
            var dt = new DataTable();

            if (page == 1)
            {

                _cmd2 = new SqlCommand("Select TOP " + PageSize + "  BookId,Title,Author,Publisher,Edition,Isbn,Pages,ShelfNo, Total, Available from BookDetails_View  ORDER BY BookId", con);
            
            }
            if (searchId==2)
            {              
                _cmd2 = new SqlCommand("select BookId,Title,Author,Publisher,Edition,Isbn,Pages,ShelfNo, Total, Available from BookDetails_View where Isbn=@bookIsbn", _connection);
                _cmd2.Parameters.AddWithValue("@bookIsbn", BookSearctBox.Text);
           
            }
            else
            {
                int previouspageLimit = (page - 1) * PageSize;

                _cmd2 = new SqlCommand("Select TOP " + PageSize +
                    " * from BookDetails_View " +
                    "where BookId NOT IN " +
                "(Select TOP " + previouspageLimit + " BookId from BookDetails_View ORDER BY BookId) ", con); 
             
            }
            try
            {

                this._adp1.SelectCommand = _cmd2;
                this._adp1.Fill(dt);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }


        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            this._currentPageIndex = 1;
            this.BooksGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection,0);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (this._currentPageIndex > 1)
            {
                this._currentPageIndex--;
                this.BooksGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection,0);
            } 
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (this._currentPageIndex < this._totalPage)
            {
                this._currentPageIndex++;
                this.BooksGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection,0);
            }
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            this._currentPageIndex = _totalPage;
            this.BooksGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection,0); 
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
         LoadBookGridView();
        }

        private void BookSearctBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (BookSearctBox.Text!="")
            {
                label7.Hide();
                this.BooksGridView.DataSource = GetCurrentRecords(1, _connection, 2);
                BooksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                _cmd1 = new SqlCommand("select b.BookId,Title,Author,Publisher,Edition,Isbn,Pages,ShelfNo,NumberOfBooks as Total,NumberOfBooks-COUNT(br.BookId) as Available from Borrow br join Book b on br.BookId=b.BookId where Isbn=@bookIsbn group by br.BookId,Isbn,Title,NumberOfBooks,Author,Edition,Pages,ShelfNo,b.BookId,Publisher ", _connection);
                _cmd1.Parameters.AddWithValue("@bookIsbn", BookSearctBox.Text);          
                _ds = new DataSet();
                _adp1 = new SqlDataAdapter(_cmd1);
                _adp1.Fill(_ds, "Book");
                BooksGridView.DataSource = _ds;
                BooksGridView.DataMember = "Book";
                this.CalculateTotalPages();
                this.BooksGridView.ReadOnly = true;
       
                if (BooksGridView.Rows.Count>1)
                {
                    this.BooksGridView.DataSource = GetCurrentRecords(1, _connection, 2);
                }
                else
              
                {
                    LoadBookGridView();
                 
                    var objDialogWindow = new DialogWindow(@"Nothing found for ISBN  '" + BookSearctBox.Text + @"'", "Warning Dialog", DialogWindow.DialogBoxIconType.Error);
                    objDialogWindow.ShowDialog();
                }
            }
            else
            {
                label7.Show();
            }
            
        }

        private void SearchButton_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
        
        }
        private void GetUpdatableData()
        {
            var command = new SqlCommand("select Subject,Title,Author,Publisher,Edition,Pages,Isbn,NumberOfBooks,Library,ShelfNo from Book where BookId=@id", _connection);
            command.Parameters.AddWithValue("@id", _selectedId);
            _connection.Open();
            var reader = command.ExecuteReader();
            reader.Read();
            SubjectTextBox.Text = reader[0].ToString();
            TitleTextBox.Text = reader[1].ToString();
            AuthorTextBox.Text = reader[2].ToString();
            PublisherTextBox.Text = reader[3].ToString();
            EditionTextBox.Text = reader[4].ToString();
            PageTextBox.Text = reader[5].ToString();
            IsbnTextBox.Text = reader[6].ToString();
            AmountTextBox.Text = reader[7].ToString();
            LibraryTextBox.Text = reader[8].ToString();
            SelfTextBox.Text = reader[9].ToString();
            _connection.Close();

        }


        private void UpdateSaveButton_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {


                var numRegex = new Regex("[0-9]");

                if (SubjectTextBox.Text == "")
                {
                    label11.Show();
                }
                if (TitleTextBox.Text == "")
                {
                    label12.Show();
                }
                if (AuthorTextBox.Text == "")
                {
                    label13.Show();
                }
                if (PublisherTextBox.Text == "")
                {
                    label14.Show();
                }
                if (EditionTextBox.Text == "")
                {
                    label15.Show();
                }

                if (PageTextBox.Text == "")
                {
                    label21.Hide();
                    label16.Show();
                }
                if (PageTextBox.Text != "")
                {
                    if (!numRegex.IsMatch(PageTextBox.Text))
                    {
                        label16.Hide();
                        label21.Show();
                    }
                    if (numRegex.IsMatch(PageTextBox.Text))
                    {
                        label16.Hide();
                        label16.Hide();
                    }

                }
                if (IsbnTextBox.Text == "")
                {
                    label17.Show();
                }

                if (AmountTextBox.Text == "")
                {
                    label22.Hide();
                    label18.Show();
                }
                if (AmountTextBox.Text != "")
                {
                    if (!numRegex.IsMatch(AmountTextBox.Text))
                    {
                        label18.Hide();
                        label22.Show();
                    }
                    if (numRegex.IsMatch(AmountTextBox.Text))
                    {
                        label18.Hide();
                        label22.Hide();
                    }

                }
                if (LibraryTextBox.Text == "")
                {
                    label19.Show();
                }
                if (SelfTextBox.Text == "")
                {
                    label20.Show();
                }

                if (SubjectTextBox.Text == "" || TitleTextBox.Text == "" || AuthorTextBox.Text == "" ||
                    PublisherTextBox.Text == "" || EditionTextBox.Text == "" || PageTextBox.Text == "" ||
                    IsbnTextBox.Text == "" ||
                    AmountTextBox.Text == "" || LibraryTextBox.Text == "" || SelfTextBox.Text == "") return;
                if (!numRegex.IsMatch(PageTextBox.Text) || !numRegex.IsMatch(AmountTextBox.Text) ||
                    !numRegex.IsMatch(EditionTextBox.Text) || !numRegex.IsMatch(SelfTextBox.Text)) return;

                try
                {
                    var bookKUpdateClass = new BookUpdateClass()
                    {
                        Subject = SubjectTextBox.Text,
                        Title = TitleTextBox.Text,
                        Author = AuthorTextBox.Text,
                        Publisher = PublisherTextBox.Text,
                        Edition = Convert.ToInt32(EditionTextBox.Text),
                        Pages = Convert.ToInt32(PageTextBox.Text),
                        TotalNumber = Convert.ToInt32(AmountTextBox.Text),
                        Library = LibraryTextBox.Text,
                        SelfNumber = Convert.ToInt32(SelfTextBox.Text),
                        Isbn = IsbnTextBox.Text
                    };

                    _connection.Open();

                    var sqlCommand =
                        new SqlCommand(
                            "update  Book set Subject=@Subject,Title=@Title,Author=@Author,Publisher=@Publisher,Edition=@Edition,Pages=@Pages,Isbn=@Isbn,NumberOfBooks=@TotalNumber,Library=@Library,ShelfNo=@SelfNumber where BookId=@Id",
                            _connection);

                    sqlCommand.Parameters.AddWithValue("@Subject", bookKUpdateClass.Subject);
                    sqlCommand.Parameters.AddWithValue("@Title", bookKUpdateClass.Title);
                    sqlCommand.Parameters.AddWithValue("@Author", bookKUpdateClass.Author);
                    sqlCommand.Parameters.AddWithValue("@Publisher", bookKUpdateClass.Publisher);


                    sqlCommand.Parameters.AddWithValue("@Edition", bookKUpdateClass.Edition);
                    sqlCommand.Parameters.AddWithValue("@Pages", bookKUpdateClass.Pages);
                    sqlCommand.Parameters.AddWithValue("@Isbn", bookKUpdateClass.Isbn);
                    sqlCommand.Parameters.AddWithValue("@TotalNumber", bookKUpdateClass.TotalNumber);
                    sqlCommand.Parameters.AddWithValue("@Library", bookKUpdateClass.Library);
                    sqlCommand.Parameters.AddWithValue("@SelfNumber", bookKUpdateClass.SelfNumber);
                    sqlCommand.Parameters.AddWithValue("@Id", _selectedId);
                    sqlCommand.ExecuteNonQuery();

                    _connection.Close();
                    SubjectTextBox.Text = "";
                    TitleTextBox.Text = "";
                    AuthorTextBox.Text = "";
                    PublisherTextBox.Text = "";
                    EditionTextBox.Text = "";
                    PageTextBox.Text = "";
                    AmountTextBox.Text = "";
                    LibraryTextBox.Text = "";
                    SelfTextBox.Text = "";
                    IsbnTextBox.Text = "";
                    MessageBox.Show(@"Updated successfully", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);     
                    updateBox.Hide();
                    BooksGridView.Show();
                    LoadBookGridView();
                    UpdateSaveButton.Hide();
                  
                    BookSearchFormPanel.Show();
                    _selectedId = 0;
                    editBookDetailsToolStripMenuItem1.Enabled = true;
                    exitEditToolStripMenuItem.Enabled = false;
                    Height = Screen.FromControl(this).Bounds.Height - 250;
                }
                catch (Exception)
                {

                    MessageBox.Show(
                        @"Something may be wrong.Please make sure that all data fields are valid.Specially make  sure that all integer fields have valid value!",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Unable to update.Something wrong ", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void BooksGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var value = Convert.ToInt32(BooksGridView[0, e.RowIndex].Value);
                _selectedId = value;
                if (!_bookDeleIdList.Contains(value))
                {
                    _bookDeleIdList.Add(value);
                }


            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

      
        private void SelfTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SelfTextBox.Text != "")
            {
            }
            else
            {
                label25.Show();
                label24.Hide();
            }
            if (SelfTextBox.Text == "") return;
            var numRegex = new Regex("[0-9]");
            if (!numRegex.IsMatch(SelfTextBox.Text))
            {
                label25.Hide();
                label24.Show();
            }
            if (!numRegex.IsMatch(SelfTextBox.Text)) return;
            label25.Hide();
            label24.Hide();
        }

        private void AmountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var numRegex = new Regex("[0-9]");
            if (AmountTextBox.Text == "")
            {
                label22.Hide();
                label18.Show();
            }
            if (AmountTextBox.Text == "") return;
            if (numRegex.IsMatch(AmountTextBox.Text))
            {
            }
            else
            {
                label18.Hide();
                label22.Show();
            }
            if (!numRegex.IsMatch(AmountTextBox.Text)) return;
            label18.Hide();
            label22.Hide();
        }

        private void PageTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var numRegex = new Regex("[0-9]");
            if (PageTextBox.Text == "")
            {
                label21.Hide();
                label16.Show();
            }
            if (PageTextBox.Text == "") return;
            if (!numRegex.IsMatch(PageTextBox.Text))
            {
                label16.Hide();
                label21.Show();
            }
            if (!numRegex.IsMatch(PageTextBox.Text)) return;
            label16.Hide();
            label16.Hide();
        }

        private void EditionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var numRegex = new Regex("[0-9]");
            if (EditionTextBox.Text == "")
            {
                label23.Hide();
                label15.Show();
            }
            if (EditionTextBox.Text == "") return;
            if (!numRegex.IsMatch(EditionTextBox.Text))
            {
                label15.Hide();
                label23.Show();
            }
            if (!numRegex.IsMatch(EditionTextBox.Text)) return;
            label15.Hide();
            label23.Hide();
        }

        private void SubjectTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SubjectTextBox.Text == "")
            {
                label11.Show();
            }
            else
            {
                label11.Hide();
            }
        }

        private void TitleTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (TitleTextBox.Text == "")
            {
                label12.Show();
            }
            else
            {
                label12.Hide();
            }
        }

        private void AuthorTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                label13.Show();
            }
            else
            {
                label13.Hide();
            }
        }

        private void PublisherTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (PublisherTextBox.Text == "")
            {
                label14.Show();
            }
            else
            {
                label14.Hide();
            }

        }

        private void IsbnTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsbnTextBox.Text == "")
            {
                label17.Show();
            }
            else
            {
                label17.Hide();
            }
        }

        private void LibraryTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (LibraryTextBox.Text == "")
            {
                label19.Show();
            }
            else
            {
                label19.Hide();
            }
        }

        private void editBookDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                BooksGridView.Hide();
                BookSearchFormPanel.Hide();
                BookSearchGroupBox.Hide();
                this.Height = Screen.FromControl(this).Bounds.Height - 450;
                GetUpdatableData();
                updateBox.Show();

                _bookDeleIdList = _emptyList;

                editBookDetailsToolStripMenuItem1.Enabled = false;
                exitEditToolStripMenuItem.Enabled = true;
           

            }
            else
            {
             
               var objDialogWindow = new DialogWindow("Please select a row to update/Edit", "Warning Dialog", DialogWindow.DialogBoxIconType.Exclamation);
               objDialogWindow.ShowDialog();
            }
           
        }

        private void exitEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Height = Screen.FromControl(this).Bounds.Height - 250;
            updateBox.Hide();
            BookSearchGroupBox.Show();
            BooksGridView.Show();
            BookSearchFormPanel.Show();
            exitEditToolStripMenuItem.Enabled = false;
            editBookDetailsToolStripMenuItem1.Enabled = true;
            _selectedId = 0;
        }

        private void insertNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bookInsertForm=new BookAddForm();
           
            bookInsertForm.Show();
    
        }

        private void BookDeleteButton_Click(object sender, EventArgs e)
        {
            var deleId = _bookDeleIdList.Count;

            if (deleId > 0)
            {
                var dialogResult = MessageBox.Show(@"Are you sure to delete?  " + deleId + @"  items will be deleted parmanently", @"Delete Confirm Box",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var id in _bookDeleIdList)
                    {
                        var command = new SqlCommand("delete  from Book where BookId=@id", _connection);
                        command.Parameters.AddWithValue("@id", id);
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();

                    }
                    this.BooksGridView.DataSource = GetCurrentRecords(1, _connection, 0);
                    var emptyList = new List<int>();
                    _bookDeleIdList = emptyList;
                    LoadBookGridView();
                }
                else
                {
                
                    _bookDeleIdList = emptyList;
                    _selectedId = 0;
                    LoadBookGridView();
                }
            }
            else
            {
            
                var objDialogWindow = new DialogWindow("Please select row/rows to delete.Use Ctrl to select multiple rows", "Warning Dialog", DialogWindow.DialogBoxIconType.Error);
                objDialogWindow.ShowDialog();
            }
        }
        private void LoadBookGridView()
        {
            BooksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;          
           _cmd1 = new SqlCommand("select BookId,Title,Author,Publisher,Edition,Isbn,Pages,ShelfNo, Total, Available from BookDetails_View", _connection);          
            _ds = new DataSet();
            _adp1 = new SqlDataAdapter(_cmd1);
            _adp1.Fill(_ds, "BookDetails_View");
            BooksGridView.DataSource = _ds;
            BooksGridView.DataMember = "BookDetails_View";
            this.CalculateTotalPages();
            this.BooksGridView.ReadOnly = true;
            this.BooksGridView.DataSource = GetCurrentRecords(1, _connection, 0);
        }

        private void searchReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bookReservationDetailsForm=new BookIssueDetailsForm();      
            bookReservationDetailsForm.Show();
       
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBookIssueForm();
        }

        private void editBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BookSearchForm_Resize(object sender, EventArgs e)
        {
            BooksGridView.Width=this.Width-40;
            BookSearchGroupBox.Width = this.Width - 40;
            updateBox.Width = this.Width - 40;
         
        }

      

        private void LoadBookIssueForm()
        {
            if (_selectedId > 0)
            {
                var selectedbookIsbnNo = "";
                using (var connection = new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;")
        )
                {
                    var command = new SqlCommand("select Isbn from Book where BookId=@id", connection);
                    command.Parameters.AddWithValue("@id", _selectedId);
                    connection.Open();
                    var reader = command.ExecuteReader();
                    reader.Read();
                    selectedbookIsbnNo = reader.GetString(0);

                }
                this.Hide();
                var objBookIssueForm = new BookIssueForm(selectedbookIsbnNo);            
                objBookIssueForm.Show();
            }
            else
            {
               
                var objDialogWindow = new DialogWindow("Please select book ISBN or a row to issue book", "Warning Dialog", DialogWindow.DialogBoxIconType.Exclamation);
                objDialogWindow.ShowDialog();
            }
        }

        private void BookSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var objHomeForm = new HomeForm();
        objHomeForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bookdetailsButton_Click(object sender, EventArgs e)
        {
            if (_selectedId>0)
            {
                var objBookDetailsForm = new BookDetailsForm(_selectedId);
                objBookDetailsForm.ShowDialog();
            }
            else
            {
                var objDialogWindow = new DialogWindow("Please select book ISBN or a row to issue book", "Warning Dialog", DialogWindow.DialogBoxIconType.Exclamation);
                objDialogWindow.ShowDialog();
            }
     
        
        }

        private void BookSearchGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Close3b;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Close3a;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
