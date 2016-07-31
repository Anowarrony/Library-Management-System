using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class BookAddForm : Form
    {
        public BookAddForm()
        {
            InitializeComponent();
       
        }
        public BookAddForm(string form)
        {
          
            InitializeComponent();
            FormDefineLabel.Text = form;
        }
  
        private void Book_Info_Save_Button_Click(object sender, EventArgs e)
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
                PublisherTextBox.Text == "" || EditionTextBox.Text == "" || PageTextBox.Text == "" || IsbnTextBox.Text == ""||  
                AmountTextBox.Text == "" || LibraryTextBox.Text == "" || SelfTextBox.Text == "") return;
            if (!numRegex.IsMatch(PageTextBox.Text) || !numRegex.IsMatch(AmountTextBox.Text) || !numRegex.IsMatch(EditionTextBox.Text) || !numRegex.IsMatch(SelfTextBox.Text)) return;
            try
            {
                var bookKAddClass = new BooKAddClass
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
                if (!CheckIsIsbnExist())
                     {
                         var connection = new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;");

                         using (connection)
                         {
                             var sqlCommand =
               new SqlCommand(
                   "insert into Book values(@Subject,@Title,@Author,@Publisher,@Edition,@Pages,@Isbn,@TotalNumber,@Library,@SelfNumber) ",
                   connection);

                             sqlCommand.Parameters.AddWithValue("@Subject", bookKAddClass.Subject);
                             sqlCommand.Parameters.AddWithValue("@Title", bookKAddClass.Title);
                             sqlCommand.Parameters.AddWithValue("@Author", bookKAddClass.Author);
                             sqlCommand.Parameters.AddWithValue("@Publisher", bookKAddClass.Publisher);

                             sqlCommand.Parameters.AddWithValue("@Edition", bookKAddClass.Edition);
                             sqlCommand.Parameters.AddWithValue("@Pages", bookKAddClass.Pages);
                             sqlCommand.Parameters.AddWithValue("@Isbn", bookKAddClass.Isbn);
                             sqlCommand.Parameters.AddWithValue("@TotalNumber", bookKAddClass.TotalNumber);
                             sqlCommand.Parameters.AddWithValue("@Library", bookKAddClass.Library);
                             sqlCommand.Parameters.AddWithValue("@SelfNumber", bookKAddClass.SelfNumber);
                            connection.Open();
                             sqlCommand.ExecuteNonQuery();

                     
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
                             MessageBox.Show(@"Book records inserted successfully", "", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                         }
           
            }
                else
                {
                    MessageBox.Show(@"Book's Record for ISBN " + IsbnTextBox.Text + @"  already exist", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }
            catch (Exception)
            {

                MessageBox.Show(@"Something may be wrong.Please make sure that all data fields are valid.Specially make  sure that all integer fields have valid value!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
        }
        protected bool CheckIsIsbnExist()
        {
            
       var     connection = new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;");
       
            using (connection)
            {
               
                var sqlCommand =
                                new SqlCommand(
                                    "select count(*) from Book  where Isbn=@Isbn",
                                    connection);

                sqlCommand.Parameters.AddWithValue("@Isbn", IsbnTextBox.Text);


                connection.Open();
                return Convert.ToBoolean(sqlCommand.ExecuteScalar());
 
            }
        
        }

        private void BookInsertForm_Load(object sender, EventArgs e)
        {
            FormDefineLabel.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
            label18.Hide();
            label19.Hide();
            label20.Hide();
            label21.Hide();
            label22.Hide();
            label23.Hide();
            label24.Hide();
            this.MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.CornflowerBlue;
        }

        private void SubjectTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SubjectTextBox.Text=="")
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

        private void EditionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var numRegex = new Regex("[0-9]");
            if (EditionTextBox.Text=="")
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

        private void SelfTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SelfTextBox.Text != "")
            {
            }
            else
            {
                label20.Show();
                label24.Hide();
            }
            if (SelfTextBox.Text == "") return;
            var numRegex = new Regex("[0-9]");
            if (!numRegex.IsMatch(SelfTextBox.Text))
            {
                label20.Hide();
                label24.Show();
            }
            if (!numRegex.IsMatch(SelfTextBox.Text)) return;
            label20.Hide();
            label24.Hide();
        }

      

     

        private void Book_Info_Save_Button_MouseHover(object sender, EventArgs e)
        {
            Book_Info_Save_Button.BackColor = Color.CornflowerBlue;
        }

        private void Book_Info_Save_Button_MouseLeave(object sender, EventArgs e)
        {
            Book_Info_Save_Button.BackColor = Color.LightSeaGreen;
        }

        private void BookInsertForm_Resize(object sender, EventArgs e)
        {
            BookAddGroupBox.Width = this.Width - 50;
        }

        private void BookAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (FormDefineLabel.Text)
            {
                case "home":
                {
                    var objHomeForm=new HomeForm();
                    this.Hide();
                    objHomeForm.Show();
                  //  this.Close();
                }
                    break;
                default:
                {
                    var objBookSearchForm = new BookSearchForm();
                    this.Hide();
                    objBookSearchForm.Show();
                  //  this.Close();
                }
                    break;
            }
        }

        private void BookAddGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Close3b;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Close3a;
        }
    }
}
