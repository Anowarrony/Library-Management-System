
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class BookIssueDetailDialog : Form
    {
        private const string ConnectionString = @"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;";
       
        private string studentId;
        public BookIssueDetailDialog(string  id)
        {
            InitializeComponent();
            studentId = id;
        }

        private void BookIssueDetailDialog_Load(object sender, System.EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var command = new SqlCommand("Select  s.StudentId,s.Name,d.DepartmentShortName,b.Isbn,b.Title,br.DayOfBorrowed,br.DayOfReturn,d.DepartmentFullName from Borrow br join Student s on br.StudentId=s.Id join Book b on br.BookId=b.BookId join Department d on br.DepartmentId=d.DepartmentId where s.StudentId=@studentId", connection);
                    command.Parameters.AddWithValue("@studentId",studentId);
                    connection.Open();
                    var reader = command.ExecuteReader();
            
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
                      //  var dleft = 0;

                        if (daysLeft < 0)
                        {

                       availableIcon.Image = Resources.close;
                        }
                        else
                        {
                            availableIcon.Image = Resources.check_blue;
                        }

                        studentIdDisplayLabel.Text = objBookIssueDetails.BookBrowwerId;

                        studentNameDisplayLabel.Text = objBookIssueDetails.Name;

                        Studentdepartmentdisplaylabel.Text = objBookIssueDetails.Department;

                        bookTitleDisplayLabel.Text = objBookIssueDetails.Title;

                        bookIsbnDisplaylabel.Text = objBookIssueDetails.Isbn;
                        issueDataDisplayLabel.Text = modifiedIssueDate;
                        returnDisplayLabel.Text = modifiedReturnDate;
                        dayaLeftDisplayLabel.Text = daysLeft.ToString();

                    }

                }
            }
            catch (Exception)
            {
                
                throw;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.CloseIconb;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.CloseIcona;
        }
    }
}
