using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class StudentInsertForm : Form
    {
        public StudentInsertForm(int id=0)
        {
            InitializeComponent();

            label12.Text = id.ToString(); BackColor = Color.CornflowerBlue;
        }

        readonly OpenFileDialog _op = new OpenFileDialog();
        private SqlCommand _cmd1;
        private SqlCommand _cmd2;
        private SqlDataAdapter _adp1;
        DataSet _ds;
        private const int PageSize = 4;
        private int _currentPageIndex = 1;
        private int _totalPage = 0;
        List<int> _bookDeleIdList = new List<int>();
        private int _updateId;
        readonly SqlConnection _connection = new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;");
        List<int> _studentDeleteIdList=new List<int>();
        private void StudentInsertForm_Load(object sender, EventArgs e)
        {
  
            // TODO: This line of code loads data into the 'libraryDataSet1.Student' table. You can move, or remove it, as needed.
           // this.studentTableAdapter.Fill(this.libraryDataSet1.Student);
            label7.Hide();
        
            // TODO: This line of code loads data into the 'sessionDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.sessionDataSet.Session);
           SessionComboBox.SelectedValue = 0; DepartmentComboBox.SelectedValue = 0;
           label4.Hide(); label5.Hide(); label6.Hide(); label16.Hide(); label15.Hide();
            this.Height = 650; label9.Hide(); label11.Hide();label12.Hide();
       StudentAddForm.Hide();
   label8.Hide();

            StudentGridView.ForeColor = Color.Black;
   LoadStudentGridView();


   using (var con = new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;"))
        
   {
                var cmd = new SqlCommand("select DepartmentShortName,DepartmentFullName from Department", con);
                        con.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            try
                            {
                              var  departmenShortName = reader.GetString(0);
                              var    departmenFullName = reader.GetString(1);
                                string departmenName = "";
                                departmenName = departmenShortName!="" ? departmenShortName : departmenFullName;
                            DepartmentComboBox.Items.Add(departmenName);
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message);

                            }
                           
                        } 
            }
            exitAddToolStripMenuItem.Enabled = false;
        }

       

        private void StudentAddButton_Click(object sender, EventArgs e)
        {
            if (StudentIdTextBox.Text == "")
            {
                label8.Show();
            }
            if (StudentIdTextBox.Text != "")
            {
                label8.Hide();
            }


            if (StudentNameTextBox.Text == "")
            {
                label16.Show();
            }
            if (StudentNameTextBox.Text != "")
            {
                label16.Hide();
            }


            if (LibraryCardNoTextBox.Text == "")
            {
                label15.Show();
            }
            if (LibraryCardNoTextBox.Text != "")
            {
                label15.Hide();
            }


            if (DepartmentComboBox.Text == "")
            {
                label5.Show();
            }
            if (DepartmentComboBox.Text != "")
            {
                label5.Hide();
            }

            if (SessionComboBox.Text == "")
            {
                label6.Show();
            }
            if (SessionComboBox.Text != "")
            {
                label6.Hide();
            }

            if (StudentIdTextBox.Text == "" || StudentNameTextBox.Text == "" || LibraryCardNoTextBox.Text == "" || SessionComboBox.Text == "" || DepartmentComboBox.Text == "")
        return;
            if (!CheckIsStudentIdExist())
            {

                try
                {
                    int departmentId;
                    using (
        var con = new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;")
        )
                    {
                        con.Open();
                        var command = new SqlCommand("select DepartmentId from Department where DepartmentShortName='" + DepartmentComboBox.SelectedItem + "'or DepartmentFullName='" + DepartmentComboBox.SelectedItem + "' ", con);
                        SqlDataReader sqlDatRreader = command.ExecuteReader();
                        sqlDatRreader.Read();
                        departmentId = sqlDatRreader.GetInt32(0);

                    }


                    var stream = new FileStream(_op.FileName, FileMode.Open, FileAccess.Read);
                    var reader = new StreamReader(stream);
                    var imgData = new Byte[stream.Length - 1];
                    stream.Read(imgData, 0, (int)stream.Length - 1);

                    label7.Hide();
                    var sqlCommand =
                        new SqlCommand(
                            "insert into Student values(@StudentId,@Name,@LibraryCardNo,@DepartmentId,@SessionId,@Image) ",
                            _connection);

                    sqlCommand.Parameters.AddWithValue("@StudentId", StudentIdTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@DepartmentId", departmentId);
                    sqlCommand.Parameters.AddWithValue("@SessionId", SessionComboBox.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@Name", StudentNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@LibraryCardNo", LibraryCardNoTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Image", imgData);




                    sqlCommand.ExecuteNonQuery();

                    _connection.Close();


                    if (Convert.ToInt32(label12.Text) == 3)
                    {

                        var sqlCommand1 =
                    new SqlCommand(
                        "select max(Id) from Student",
                        _connection);
                        _connection.Open();
                        var reader1 = sqlCommand1.ExecuteReader();
                        reader1.Read();
                        var id = reader1.GetInt32(0);


                        _connection.Close();
                        this.Hide();
                        var bookReservationPage = new BookIssueForm(id);
                        bookReservationPage.Closed += (s, args) => this.Close();
                        bookReservationPage.Show();
                    }
                    else
                    {
                        LoadStudentGridView();
                        MessageBox.Show(@"New student has been inserted successfully ", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Something is wrong.Please make sure that student image is uploaded and try again.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


              
            }
            else
            {
                label7.Show();
            }

        }
        private void LoadStudentGridView()
        {
            StudentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _cmd1 = new SqlCommand("Select Id,StudentId,Name,SessionName,DepartmentShortName,DepartmentFullName  from Student s join Department d on d.DepartmentId=s.DepartmentId join Session ses on ses.SessionId=s.SessionId order by Id", _connection);
            _ds = new DataSet();
            _adp1 = new SqlDataAdapter(_cmd1);
            _adp1.Fill(_ds, "Student");
            StudentGridView.DataSource = _ds;
            StudentGridView.DataMember = "Student";
            this.CalculateTotalPages();
            this.StudentGridView.ReadOnly = true;
            this.StudentGridView.DataSource = GetCurrentRecords(1, _connection);
        }

        private void CalculateTotalPages()
        {
            int rowCount = StudentGridView.Rows.Count - 1;
            _totalPage = rowCount / PageSize;

            if (rowCount % PageSize > 0)
                _totalPage += 1;
        }
        private DataTable GetCurrentRecords(int page, SqlConnection con, int searchId=0)
        {
            var dt = new DataTable();

            if (page == 1)
            {
                _cmd2 = new SqlCommand("Select TOP " + PageSize + "Id,StudentId,Name,SessionName,DepartmentShortName,DepartmentFullName  from Student s join Department d on d.DepartmentId=s.DepartmentId join Session ses on ses.SessionId=s.SessionId by Id", con);
            }
            if (searchId == 2)
            {

                var searchTerm = StudentSearctBox.Text;
                _cmd2 = new SqlCommand("Select Id,StudentId,Name,SessionName,DepartmentShortName,DepartmentFullName  from Student s join Department d on d.DepartmentId=s.DepartmentId join Session ses on ses.SessionId=s.SessionId where StudentId=@searchTerm", _connection);
                _cmd2.Parameters.AddWithValue("@searchTerm", StudentSearctBox.Text);

            }
            else
            {
                var previouspageLimit = (page - 1) * PageSize;

                _cmd2 = new SqlCommand("Select TOP " + PageSize + " Id,StudentId,Name,SessionName,DepartmentShortName,DepartmentFullName  from Student s join Department d on d.DepartmentId=s.DepartmentId join Session ses on ses.SessionId=s.SessionId  WHERE Id NOT IN "  +"(Select TOP " + previouspageLimit + "Id from Student ORDER BY Id) ", con);

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
        private bool CheckIsStudentIdExist()
        {
            _connection.Close();
        
            var sqlCommand =
                            new SqlCommand(
                                "select count(*) from Student  where StudentId=@Id",
                                _connection);

            sqlCommand.Parameters.AddWithValue("@Id", StudentIdTextBox.Text);


            _connection.Open();
            return  Convert.ToBoolean(sqlCommand.ExecuteScalar());
        }

        private void StudentIdTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (StudentIdTextBox.Text=="")
            {
                label8.Show();
            }
            else
            {
                label8.Hide();
            }
        }

        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            this._currentPageIndex = 1;
            this.StudentGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection, 0);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (this._currentPageIndex > 1)
            {
                this._currentPageIndex--;
                this.StudentGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection);
            } 
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (this._currentPageIndex < this._totalPage)
            {
                this._currentPageIndex++;
                this.StudentGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection);
            }
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            this._currentPageIndex = _totalPage;
            this.StudentGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection); 
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadStudentGridView();
        }

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StudentDeleteButton_Click(object sender, EventArgs e)
        {
            var count = _studentDeleteIdList.Count;
            if (count>0)
            {
                    var dialogResult = MessageBox.Show(@"Are you sure to delete "+ count +@" items?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var id in _studentDeleteIdList)
                    {
                               _connection.Open();

                    var sqlCommand = new SqlCommand("delete from Student where  Id=@DeleteId", _connection);

                    sqlCommand.Parameters.AddWithValue("@DeleteId", id);

                    sqlCommand.ExecuteNonQuery();
                    _connection.Close();
               
                    }
                    var emptyList = new List<int>();
                    _studentDeleteIdList = emptyList;
                 LoadStudentGridView();
                }
                else
                {
                   var emptyList=new List<int>();
                    _studentDeleteIdList = emptyList;
                   LoadStudentGridView();
                }
            }
             else
            {
                MessageBox.Show(@"Please select a row to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void StudentGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var value = Convert.ToInt32(StudentGridView[0, e.RowIndex].Value);
                if (!_studentDeleteIdList.Contains(value))
                {
                    _studentDeleteIdList.Add(value);
                }
            
             

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem.Enabled = false;
            exitAddToolStripMenuItem.Enabled = true;            

            this.Height = 600;
            StudentGridView.Hide();
            SearchButton.Hide();
            StudentSearctBox.Hide(); label10.Hide();
            StudentAddForm.Show();
       StudentDeleteButton.Hide();
label11.Hide();
            label12.Hide();
            FirstPageButton.Hide();
            NextPageButton.Hide();
            PreviousButton.Hide();
            LastPageButton.Hide();
            RefreshButton.Hide();
        }

        private void exitAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitAddToolStripMenuItem.Enabled = false;
            addToolStripMenuItem.Enabled = true;
         
            StudentAddForm.Hide();
            this.Height = 650;

            StudentGridView.Show();
            SearchButton.Show();
            StudentSearctBox.Show(); label10.Show();

            StudentDeleteButton.Show();
            label11.Hide();
            label12.Hide();
            FirstPageButton.Show();
            NextPageButton.Show();
            PreviousButton.Show();
            LastPageButton.Show();
        
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (StudentSearctBox.Text != "")
            {
                this._currentPageIndex = _totalPage;
                this.StudentGridView.DataSource = GetCurrentRecords(this._currentPageIndex, _connection, 2);
                label9.Hide();
            }
            else
            {
                label9.Show();
            }
        }

        private void DepartmentComboBox_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void DepartmentComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (DepartmentComboBox.Text == "")
            {
                label5.Show();
            }
            if (DepartmentComboBox.Text != "")
            {
                label5.Hide();
            }
        }

        private void SessionComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (SessionComboBox.Text == "")
            {
                label6.Show();
            }
            if (SessionComboBox.Text != "")
            {
                label6.Hide();
            }
        }

        private void STudentImageUploadButton_Click(object sender, EventArgs e)
        {
       
            if (_op.ShowDialog()== DialogResult.OK)
            {

                var img = Image.FromFile(_op.FileName);
           
            
                StuidentImageBox.Image = img;


            }
        }

        private void StudentInsertForm_Resize(object sender, EventArgs e)
        {
            StudentGridView.Width = this.Width - 40;
            StudentAddForm.Width = this.Width - 40;
        }

        private void StudentInsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var objHomeForm=new HomeForm();
            this.Hide();
            objHomeForm.Show();
        
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

