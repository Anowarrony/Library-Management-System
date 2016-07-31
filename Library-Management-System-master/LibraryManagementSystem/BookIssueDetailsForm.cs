using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;


namespace LibraryManagementSystem
{
    public partial class BookIssueDetailsForm : Form
    {
        
        public BookIssueDetailsForm()
        {

            InitializeComponent();
          
        }
        public BookIssueDetailsForm(String formMsg)
        {

            InitializeComponent();
            lFormDefineLabel.Text = formMsg;
        }


        private const string Query = "Select  s.StudentId,s.Name,d.DepartmentShortName,b.Isbn,b.Title,br.DayOfBorrowed,br.DayOfReturn,d.DepartmentFullName from Borrow br join Student s on br.StudentId=s.Id join Book b on br.BookId=b.BookId join Department d on br.DepartmentId=d.DepartmentId";
        private const string ConnectionString = @"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;";
       
        private string _selectedId="";
        private void BookReservationDetailsForm_Load(object sender, EventArgs e)
        {
          
            lFormDefineLabel.Hide();
    BookissueUpdategroupBox.Hide();
            this.Height = 620;
            closeUpdateToolStripMenuItem.Enabled = this.Height != 555;
            var t=new ToolTip();
       t.SetToolTip(ReservationRefreshButton,"Reload");
       t.SetToolTip(ReservationSearchButton," Search");
            t.SetToolTip(ReservationFilterComboBox,"Filter Data");
            t.SetToolTip(ReservationSearchTextBox,"Enter a valid ID.You must enter full ID.");
            t.SetToolTip(ReservationUpdateButton,"Update a record by Selecting an ID");
            t.SetToolTip(ReservationDeleteId, "Delete a record by Selecting an ID");
   LoadGridData();

   CountLabel.Show(); BackColor = Color.CornflowerBlue;
   closeUpdateToolStripMenuItem.Enabled = false;
        }

        private void LoadGridData()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand(Query, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                BookReservationDetailsView.Items.Clear();
                while (reader.Read())
                {
                  
                    var objBookIssueDetails = new BookIssueDetails();
                    objBookIssueDetails.BookBrowwerId = reader[0].ToString();
                    objBookIssueDetails.Name = reader[1].ToString();
                    objBookIssueDetails.Department = reader[2].ToString() == "" ? reader[7].ToString() : reader[2].ToString();
                   
                    objBookIssueDetails.Isbn = reader[3].ToString();
                    objBookIssueDetails.Title = reader[4].ToString();
                    objBookIssueDetails.IssueDate = Convert.ToDateTime(reader[5]);
                    objBookIssueDetails.ReturnDate = Convert.ToDateTime(reader[6]);
                 
                    var modifiedIssueDate = string.Format("{0:dd-MM-yy}", objBookIssueDetails.IssueDate);
                    var modifiedReturnDate = string.Format("{0:dd-MM-yy}", objBookIssueDetails.ReturnDate);
                    var modifiedCurrentDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                    var daysLeft = (Convert.ToDateTime(objBookIssueDetails.ReturnDate) - Convert.ToDateTime(modifiedCurrentDate)).Days;                                     
                   var  reservationDetailsListView = new ListViewItem(objBookIssueDetails.BookBrowwerId);
                   
                    reservationDetailsListView.SubItems.Add(objBookIssueDetails.Name);
                    reservationDetailsListView.SubItems.Add(objBookIssueDetails.Department);
                    reservationDetailsListView.SubItems.Add(objBookIssueDetails.Title);
                    reservationDetailsListView.SubItems.Add(objBookIssueDetails.Isbn);                                     
                    reservationDetailsListView.SubItems.Add(modifiedIssueDate);
                    reservationDetailsListView.SubItems.Add(modifiedReturnDate);                                    
                    
                    if (daysLeft<0)
                    {
                       // reservationDetailsListView.UseItemStyleForSubItems = false;
        
                        reservationDetailsListView.SubItems.Add("Expired (" + +(-daysLeft) + " day(s)" + " )");

                        reservationDetailsListView.ForeColor = Color.White;
                        reservationDetailsListView.BackColor = Color.Tomato;
                        reservationDetailsListView.Font = new Font("Verdana", 10);
                    }
                    else
                    {
                       
                        reservationDetailsListView.Font = new Font("Verdana", 10);
                        reservationDetailsListView.SubItems.Add( daysLeft.ToString(CultureInfo.InvariantCulture));
                    }
               
                    BookReservationDetailsView.Items.Add(reservationDetailsListView);
                    CountLabel.Text = BookReservationDetailsView.Items.Count.ToString() + @" items";
                }

            }
        }

   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReservationSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
      
        }

        private void ReservationSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReservationSearchTextBox.Text!=string.Empty)
                {
               
                    using (
                 var connection =
                     new SqlConnection(ConnectionString) )
                    {
                        const string searchQuery = "Select  s.StudentId,s.Name,d.DepartmentShortName,b.Isbn,b.Title,br.DayOfBorrowed,br.DayOfReturn from Borrow br join Student s on br.StudentId=s.Id join Book b on br.BookId=b.BookId join Department d on br.DepartmentId=d.DepartmentId where s.StudentId=@searchTerm";

                           var command = new SqlCommand(searchQuery, connection);
             
                        command.Parameters.AddWithValue("@searchTerm", ReservationSearchTextBox.Text);
                        connection.Open();
                        var reader = command.ExecuteReader();
                        BookReservationDetailsView.Items.Clear();
                        reader.Read();
                        var bookReservationDetails = new BookIssueDetails
                        {
                            BookBrowwerId = reader[0].ToString(),
                            Name = reader[1].ToString(),
                            Department = reader[2].ToString(),
                            Isbn = reader[3].ToString(),
                            Title = reader[4].ToString(),
                            IssueDate = Convert.ToDateTime(reader[5]),
                            ReturnDate = Convert.ToDateTime(reader[6])
                        };
                        var modifiedIssueDate = string.Format("{0:dd-MM-yy}", bookReservationDetails.IssueDate);
                        var modifiedReturnDate = string.Format("{0:dd-MM-yy}", bookReservationDetails.ReturnDate);
                        var currentdate = DateTime.Now.ToShortDateString();
                   

                    var daysLeft =(int)( Convert.ToDateTime(string.Format("{0:MM/dd/yyyy}",bookReservationDetails.ReturnDate))- Convert.ToDateTime(currentdate)).TotalDays;              
                    var reservationDetailsListView = new ListViewItem(bookReservationDetails.BookBrowwerId);
                    reservationDetailsListView.SubItems.Add(bookReservationDetails.Name);
                    reservationDetailsListView.SubItems.Add(bookReservationDetails.Department);

                    reservationDetailsListView.SubItems.Add(bookReservationDetails.Title);
                    reservationDetailsListView.SubItems.Add(bookReservationDetails.Isbn);
                    reservationDetailsListView.SubItems.Add(modifiedIssueDate);
                    reservationDetailsListView.SubItems.Add(modifiedReturnDate);

                    if (daysLeft < 0)
                    {
                        reservationDetailsListView.SubItems.Add("Expired (" + +(-daysLeft) + " day(s)" + " )");
                    }
                    else
                    {
                        reservationDetailsListView.SubItems.Add(daysLeft.ToString(CultureInfo.InvariantCulture));
                    }
                    BookReservationDetailsView.Items.Add(reservationDetailsListView);
                    CountLabel.Hide();
                    }
                }
                else
                {                   
                    var objDialogWindow = new DialogWindow("Please enter a valid ID to search", "Warning Dialog", DialogWindow.DialogBoxIconType.Exclamation);
                    objDialogWindow.ShowDialog();
                }

            }
            catch (Exception ex)
            {
           
                var objDialogWindow = new DialogWindow(@"Nothing found for ID '" + " " + ReservationSearchTextBox.Text + @" '", "Warning Dialog", DialogWindow.DialogBoxIconType.Exclamation);
                objDialogWindow.ShowDialog();
            }

        }

        private void ReservationFilterComboBox_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ReservationFilterComboBox_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {


                    var command = new SqlCommand(Query, connection);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    BookReservationDetailsView.Items.Clear();
                    while (reader.Read())
                    {                  
                        var bookReservationDetails = new BookIssueDetails
                        {
                            BookBrowwerId = reader[0].ToString(),
                            Name = reader[1].ToString(),
                            Department = reader[2].ToString(),
                            Isbn = reader[3].ToString(),
                            Title = reader[4].ToString(),
                            IssueDate = Convert.ToDateTime(reader[5]),
                            ReturnDate = Convert.ToDateTime(reader[6])
                        };
                        var modifiedIssueDate = string.Format("{0:dd-MM-yy}", bookReservationDetails.IssueDate);
                        var modifiedReturnDate = string.Format("{0:dd-MM-yy}", bookReservationDetails.ReturnDate);
                        var modifiedCurrentDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                        var daysLeft = (Convert.ToDateTime(bookReservationDetails.ReturnDate) - Convert.ToDateTime(modifiedCurrentDate)).Days;


                        var reservationDetailsListView = new ListViewItem(bookReservationDetails.BookBrowwerId);
                        reservationDetailsListView.SubItems.Add(bookReservationDetails.Name);
                        reservationDetailsListView.SubItems.Add(bookReservationDetails.Department);
                        reservationDetailsListView.SubItems.Add(bookReservationDetails.Title);
                        reservationDetailsListView.SubItems.Add(bookReservationDetails.Isbn);
                        reservationDetailsListView.SubItems.Add(modifiedIssueDate);
                        reservationDetailsListView.SubItems.Add(modifiedReturnDate);
                  



                        if (ReservationFilterComboBox.Text == @"Expired")
                        {

                            if (daysLeft<0)
                            {

                                reservationDetailsListView.SubItems.Add("Expired ("+(-daysLeft)+" )");



                                BookReservationDetailsView.Items.Add(reservationDetailsListView);
                                
                                CountLabel.Text = BookReservationDetailsView.Items.Count+@" items";
                            CountLabel.Show();
                            } 
                        }
                        else
                        {
                            if (daysLeft>= 0)
                            {
                                reservationDetailsListView.SubItems.Add(daysLeft.ToString()) ;
                                BookReservationDetailsView.Items.Add(reservationDetailsListView);
                                CountLabel.Text = BookReservationDetailsView.Items.Count.ToString() + @" items";
                                CountLabel.Show();
                            } 
                        }

                   

                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ReservationRefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
         LoadGridData();
                CountLabel.Text = BookReservationDetailsView.Items.Count.ToString() + @" items";
                CountLabel.Show();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

 

        private void BookReservationDetailsView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
    
       
        }

        private void BookReservationDetailsView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
      
        }

        private void BookReservationDetailsView_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void BookReservationDetailsView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (BookReservationDetailsView.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = BookReservationDetailsView.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
               _selectedId= BookReservationDetailsView.Items[intselectedindex].Text;
                  
            } 
        }

        private void ReservationDeleteId_Click(object sender, EventArgs e)
        {
            if (_selectedId == "")
            {
              
                var objDialogWindow = new DialogWindow("Please select an ID to delete", "Warning Dialog", DialogWindow.DialogBoxIconType.Exclamation);
                objDialogWindow.ShowDialog();
            }
            if (_selectedId!=string.Empty)
            {
                var result = MessageBox.Show(@"Are you sure to delete ID " + _selectedId + @" parmanently", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    using (
                        var connection =
                            new SqlConnection(ConnectionString)
                        )
                    {


                        var command =
                            new SqlCommand(
                                "delete b from Borrow b join Student s on b.StudentId=s.Id where s.StudentId=@DeleteId ",
                                connection);
                        command.Parameters.AddWithValue("@DeleteId", _selectedId);

                        connection.Open();

                        command.ExecuteNonQuery();
                   LoadGridData();
                        _selectedId = "";
                        CountLabel.Text = BookReservationDetailsView.Items.Count + @" items";
                        CountLabel.Show();

                      
                    }
                }
                else
                {
                    _selectedId = "";
                }
                
            }
            
        }

        private void ReservationUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedId!="")
                {
                    BookReservationDetailsView.Hide();
                    BookIssuedetailsSearchPanel.Hide();
                    BookissueUpdategroupBox.Show();
                  PagingPanel.Hide();
                        closeUpdateToolStripMenuItem.Enabled = true;

                        this.Width = 1151;
                    this.Height = 415;
                    using (
                    var connection =
                        new SqlConnection(ConnectionString)
                    )
                    {


                        var command =
                            new SqlCommand(
                                "select Isbn,Title,br.DayOfBorrowed,br.DayOfReturn  from Borrow br join Book b on br.BookId=b.BookId join Student s on br.StudentId=s.Id where s.StudentId=@StudentId",
                                connection);
                        command.Parameters.AddWithValue("@StudentId", _selectedId);

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        IsbnUpdateTextBox.Text = reader[0].ToString();

                        IssueDatePicker.Text = reader[2].ToString();
                        ReturnDatePicker.Text = reader[3].ToString();



                    }
                }
                else
                {
                
                    var objDialogWindow = new DialogWindow("Please select an ID to Update", "Warning Dialog", DialogWindow.DialogBoxIconType.Exclamation);
                    objDialogWindow.ShowDialog(); 
                }
               

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
               
                 
        }

        private void ReservationEditBtn_Click(object sender, EventArgs e)
        {
                if (IsbnUpdateTextBox.Text!=string.Empty&&IssueDatePicker.Text!=string.Empty&&ReturnDatePicker.Text!=string.Empty)
                {

                    var modifiedIssueDate = Convert.ToDateTime(string.Format("{0:yyyy-MM-dd}", IssueDatePicker.Value));

                    var modifiedReturnDate = Convert.ToDateTime(string.Format("{0:yyyy-MM-dd}", ReturnDatePicker.Value));
               
                    using (
                  var connection =
                      new SqlConnection(ConnectionString)
                  )
                    {

                        try
                        {                                                   
                            var command =
                                new SqlCommand(
                                    "update BookIssueDetailsView set Isbn=@BookId,DayOfBorrowed=@IssueDate,DayOfReturn=@ReturnDay where StudentId=@Id",
                                    connection);
                            connection.Open();
                            command.Parameters.AddWithValue("@Id", _selectedId);
                            command.Parameters.AddWithValue("@BookId", IsbnUpdateTextBox.Text);
                            command.Parameters.AddWithValue("@IssueDate", modifiedIssueDate);
                            command.Parameters.AddWithValue("@ReturnDay", modifiedReturnDate);                          
                            command.ExecuteNonQuery();
                            LoadGridData();
                            CountLabel.Text = BookReservationDetailsView.Items.Count + @" items";
                            CountLabel.Show();
                            MessageBox.Show(@"Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                          
                        }                                           

                    }
                }
                else
                {
                    MessageBox.Show(@"Empty Field is not allowd!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
                }
     
        }

        private void closeUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1151;
            this.Height = 555;
       BookIssuedetailsSearchPanel.Show();
            BookReservationDetailsView.Show();
            PagingPanel.Show();BookissueUpdategroupBox.Hide();
            closeUpdateToolStripMenuItem.Enabled = false;
            _selectedId = "";
        }

        private void ReservationFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
        private void BookReservationDetailsForm_Resize(object sender, EventArgs e)
        {
            BookReservationDetailsView.Width = this.Width - 40;
            BookissueUpdategroupBox.Width = this.Width - 40;
            
        }

        private void BookIssueDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lFormDefineLabel.Text==@"home")
            {
                var objHomeForm=new HomeForm();
                this.Hide();
                objHomeForm.Show();
    
            }
            else
            {
                var objBookSearchForm = new BookSearchForm();
                this.Hide();
                objBookSearchForm.Show();
         
            }
     
     
        }

        private void BookIssuedetailsShowButton_Click(object sender, EventArgs e)
        {
            if (_selectedId != "")
            {
    
                var objBookIssueDetailDialog = new BookIssueDetailDialog(_selectedId);
                objBookIssueDetailDialog.Show();
            }
            else
            {

                var objDialogWindow = new DialogWindow("Please select an ID to see details", "Warning Dialog", DialogWindow.DialogBoxIconType.Exclamation);
                objDialogWindow.ShowDialog();
            }
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
