using System;

using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class BookIssueForm : Form
    {
        public BookIssueForm(int id=0)
        {
          
         
       
            InitializeComponent();
            label12.Text = id.ToString(CultureInfo.InvariantCulture);
         
        }

        public BookIssueForm(string isbn)
        {
            InitializeComponent();
            BookIdTextBox.Text = isbn;
        }

        private const string Connection = @"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;";


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BookReservationPage_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            MinimizeBox = false;
         
    label12.Hide();
            ReturnDatePicker.MinDate = DateTime.Today.AddDays(1);
            BorrowDatePicker.MinDate = DateTime.Now;
            label6.Hide();
            label7.Hide();
            label11.Hide();
            label8.Hide();
            label9.Hide();
           label10.Hide();

           using (var connection = new SqlConnection(Connection))
            {
                var command = new SqlCommand("select DepartmentShortName,DepartmentFullName from Department", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        var departmenShortName = reader.GetString(0);
                        var departmenFullName = reader.GetString(1);
                        string departmenName = "";
                        departmenName = departmenShortName != "" ? departmenShortName : departmenFullName;
                        DepartmentComboBox.Items.Add(departmenName);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);

                    }

                }
            }
            try
            {

                if (Convert.ToInt32(label12.Text) > 0)
                {
                    var id = Convert.ToInt32(label12.Text);
                    using (var connection = new SqlConnection(Connection))
                    {
                        var command = new SqlCommand("select StudentId from Student where Id=@Id", connection);
                        command.Parameters.AddWithValue("@Id", id);
                        connection.Open();
                        var reader = command.ExecuteReader();
                        reader.Read();

                        StudentIdTextBox.Text = reader[0].ToString();

                        connection.Close();
                    }

                }
            }
            catch (Exception exception)
            {


            } BackColor = Color.CornflowerBlue;
        }

     

        private bool IsCurrentBookAvailable()
        {
            using (var con=new SqlConnection( @"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;"))
            {
                var command = new SqlCommand("select Available from BookDetails_View where Isbn=@BookIsbn", con);
                command.Parameters.AddWithValue("@BookIsbn", BookIdTextBox.Text);
                con.Open();
                var reader = command.ExecuteReader();
                reader.Read();
                var available = reader.GetInt32(0);
                if (available>0)
                {
                    return true;
                }
                return false;
            }
        }

        private bool CheckIsCurrentStudentHasAlreadyAnyResetvationOfBook()
        {
           

            using (var connection =
                    new SqlConnection(Connection)
                    )
            {

                var sqlCommand =
                    new SqlCommand(
                        "select count(*) from Borrow br join Student s on br.StudentId=s.Id   where s.StudentId=@StudentId ",
                        connection);


                sqlCommand.Parameters.AddWithValue("@StudentId",StudentIdTextBox.Text);


                connection.Open();
                return Convert.ToBoolean(sqlCommand.ExecuteScalar());


            }
        }

       

  

        protected bool CheckIsIsbnExist()
        {
         
            using (var connection =
            new SqlConnection(Connection)
)
            {

             
                var sqlCommand =
                                new SqlCommand(
                                    "select count(*) from Book  where Isbn=@Isbn",
                                    connection);

                sqlCommand.Parameters.AddWithValue("@Isbn", BookIdTextBox.Text);


                connection.Open();
                return Convert.ToBoolean(sqlCommand.ExecuteScalar()); 

            }
        
        }




        protected bool CheckIsStudentIsRegistered()
        {

            using (var connection =
                new SqlConnection(Connection)
                )
            {
                var sqlCommand =
                          new SqlCommand(
                              "select COUNT(*) from student s join Department d on s.DepartmentId=d.DepartmentId where s.StudentId=@Id AND D.DepartmentFullName=@departmentName OR S.StudentId=@Id AND D.DepartmentShortName=@departmentName",
                              connection);

                sqlCommand.Parameters.AddWithValue("@Id", StudentIdTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@departmentName", DepartmentComboBox.Text);

                connection.Open();
                return Convert.ToBoolean(sqlCommand.ExecuteScalar());

            }
          

        }
    

     
        private void BookReservationButton_Click_1(object sender, EventArgs e)
        {
            if (StudentIdTextBox.Text == "")
            {
                label6.Show();
            }
            if (StudentIdTextBox.Text != "")
            {
                label6.Hide();
            }

            if (BookIdTextBox.Text == "")
            {
                label8.Show();
            }
            if (BookIdTextBox.Text != "")
            {
                label8.Hide();
            }

            if (DepartmentComboBox.Text == "")
            {
                label7.Show();
            }
            if (DepartmentComboBox.Text != "")
            {
                label7.Hide();
            }



            if (BorrowDatePicker.Text == "")
            {
                label9.Show();
            }
            if (BorrowDatePicker.Text != "")
            {
                label9.Hide();
            }

            if (ReturnDatePicker.Text == "")
            {
                label10.Show();
            }
            if (ReturnDatePicker.Text != "")
            {
                label10.Hide();
            }

            if (StudentIdTextBox.Text == "" || DepartmentComboBox.Text == "" || BookIdTextBox.Text == "") return;


            if (CheckIsStudentIsRegistered())
            {


                if (CheckIsIsbnExist())
                {

                    if (!CheckIsCurrentStudentHasAlreadyAnyResetvationOfBook())
                    {

                        if (IsCurrentBookAvailable())
                        {


                            int studentId;
                            int bookId;
                            int departmentId;
                            using (var connection =
                     new SqlConnection(Connection)
                     )
                            {

                                var sqlCommand1 =
                                    new SqlCommand(
                                        "select BookId from Book where Isbn=@Isbn ",
                                        connection);
                                sqlCommand1.Parameters.AddWithValue("@Isbn", BookIdTextBox.Text);

                                var sqlCommand2 =
                                   new SqlCommand(
                                       "select DepartmentId from Department where DepartmentShortName=@Department or DepartmentFullName=@Department ",
                                       connection);
                                sqlCommand2.Parameters.AddWithValue("@Department", DepartmentComboBox.Text);

                                var sqlCommand3 =
                                 new SqlCommand(
                                     "select Id from Student where StudentId=@IStudentId ",
                                     connection);
                                sqlCommand3.Parameters.AddWithValue("@IStudentId", StudentIdTextBox.Text);


                                connection.Open();
                                var reader1 = sqlCommand1.ExecuteReader();
                                reader1.Read();
                                bookId = reader1.GetInt32(0);
                                connection.Close();
                                connection.Open();
                                var reader2 = sqlCommand2.ExecuteReader();
                                reader2.Read();
                                departmentId = reader2.GetInt32(0);

                                connection.Close();
                                connection.Open();
                                var reader3 = sqlCommand3.ExecuteReader();
                                reader3.Read();
                                studentId = reader3.GetInt32(0);



                            }

                            using (var connection =
                          new SqlConnection(Connection)
                          )
                            {

                                var sqlCommand =
                                    new SqlCommand(
                                        "insert into Borrow(StudentId,DayOfBorrowed,DayOfReturn,BookId,DepartmentId) values(@StudentId,@BorrowDate,@ReturnDate,@BookId,@DepartmentId) ",
                                        connection);
                                sqlCommand.Parameters.AddWithValue("@StudentId", studentId);
                                sqlCommand.Parameters.AddWithValue("@BorrowDate",
                              Convert.ToDateTime(BorrowDatePicker.Text));
                                sqlCommand.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(ReturnDatePicker.Text));
                                sqlCommand.Parameters.AddWithValue("@BookId", bookId);
                                sqlCommand.Parameters.AddWithValue("@DepartmentId", departmentId);

                                connection.Open();
                                sqlCommand.ExecuteNonQuery();
                                MessageBox.Show(@"Book Reservation has been completed successfully.", "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Sorry, this book of ISBN  '"+BookIdTextBox.Text+@"' is not available now.", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Information); 
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"There is already a Reservation for this Student.This time no more reservation is allowed.", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }




                }
                else
                {
                    MessageBox.Show(@"Book's ISBN not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);




                }



            }
            else
            {
                var result = MessageBox.Show(@"It seems that Id " + StudentIdTextBox.Text + @" not registered yet. Would you like to registered it now?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {



                    this.Hide();
                    var studentInsertForm = new StudentInsertForm(3);
                    studentInsertForm.Closed += (s, args) => this.Close();
                    studentInsertForm.Show();
                }


            }
        }

        private void BookIssueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
      
            var objBookSearchForm = new BookSearchForm();         
            objBookSearchForm.Show();
      

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Close3b;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Close3a;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
