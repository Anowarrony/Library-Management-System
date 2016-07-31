using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class BookDetailsForm : Form
    {
  
        public BookDetailsForm(int bookId)
        {
            InitializeComponent();
            bookIdLabel=new Label
            {
                Text = bookId.ToString()
            };
        }
        public BookDetailsForm()
        {
            InitializeComponent();
           
        }
        
        private  void LoadData(int id)
        {
            using (
                var connection =
                    new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;"))
            {
               
                var sqlCommand =
                    new SqlCommand(
                        "select Title,Author,Publisher,Edition,Subject,Library,Isbn,Pages,ShelfNo, Total, Available from BookDetails_View where BookId=@BookId",
                        connection);
                sqlCommand.Parameters.AddWithValue("@BookId", id);

                connection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                reader.Read();

                titleDisplayLabelFromDb.Text = reader[0].ToString();
                authorDisplayLable.Text = reader[1].ToString();
                publisherDisplayLabel.Text = reader[2].ToString();
                editionDisplayLabel.Text = reader[3].ToString();
                subjectDisplayLabel.Text = reader[4].ToString();
                libraryDisplayLabel.Text = reader[5].ToString();
                isbnDisplayLabel.Text = reader[6].ToString();
                pageDisplayLabel.Text = reader[7].ToString();
                selfNoDisplayLabel.Text = reader[8].ToString();
                totalDisplayLabell.Text = reader[9].ToString();
                var availableBookNumber = Convert.ToInt32(reader[10]);
                availableDisplayLabel.Text = availableBookNumber.ToString();
                availableIcon.Image = availableBookNumber > 0 ? Resources.check_blue : Resources.close;
            }
        }

      
       
        private void BookDetailsForm_Load(object sender, EventArgs e)
        {

            LoadData(Convert.ToInt32(bookIdLabel.Text));
         
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.CloseIconb;
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.CloseIcona;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
          
        }
    }
}
