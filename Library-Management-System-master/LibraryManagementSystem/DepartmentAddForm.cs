using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class DepartmentAddForm : Form
    {
        public DepartmentAddForm()
        {
            InitializeComponent(); BackColor = Color.CornflowerBlue;
        }

        private int _deleteId = 0;
        readonly SqlConnection _connection = new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;");
      
        private SqlCommand _cmd1;
        private SqlCommand _cmd2;
        private SqlDataAdapter _adp1;
        DataSet _ds;
        private const int PageSize = 4;
        private int _currentPageIndex = 1;
        private int _totalPage = 0; 
   
        private void DepartmentAddButton_Click(object sender, EventArgs e)
        {
            if (Department_Full_Name_Text_Box.Text == "")
            {
                label3.Show();
            }
            if (Department_Full_Name_Text_Box.Text != "")
            {
                try
                {



                    if (!CheckIsDepartmentFullNameExist())
                    {

                        if (Department_Sgort_Name_Text_Box.Text != "")
                        {
                            if (!CheckIsDepartmentShortNameExist())
                            {

                                label8.Hide();
                                label9.Hide();
                                var sqlCommand =
                                    new SqlCommand(
                                        "insert into Department values(@DepartmentShortName,@DepartmentFullName) ",
                                        _connection);

                                sqlCommand.Parameters.AddWithValue("@DepartmentShortName",
                                    Department_Sgort_Name_Text_Box.Text);
                                sqlCommand.Parameters.AddWithValue("@DepartmentFullName",
                                    Department_Full_Name_Text_Box.Text);
                                sqlCommand.ExecuteNonQuery();

                                _connection.Close();
                                MessageBox.Show(@"Inserted Successfully", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);


                            }
                            else
                            {
                                _connection.Close();
                                label9.Hide();
                                label8.Show();
                            }
                        }
                        else
                        {

                            label8.Hide();
                            label9.Hide();
                            var sqlCommand =
                                new SqlCommand(
                                    "insert into Department values(@DepartmentShortName,@DepartmentFullName) ",
                                    _connection);

                            sqlCommand.Parameters.AddWithValue("@DepartmentShortName",
                                Department_Sgort_Name_Text_Box.Text);
                            sqlCommand.Parameters.AddWithValue("@DepartmentFullName", Department_Full_Name_Text_Box.Text);
                            sqlCommand.ExecuteNonQuery();

                            _connection.Close();
                            MessageBox.Show(@"Inserted Successfully", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        }



                    }
                    else
                    {
                        _connection.Close();
                        label8.Hide();
                        label9.Show();
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    LoadGridData();
                }
            }
        }
      
      
   

        private void DepartmentAddButton_MouseHover(object sender, EventArgs e)
        {
            DepartmentAddButton.BackColor = Color.DarkCyan;
        }

        private void DepartmentAddButton_MouseLeave(object sender, EventArgs e)
        {
            DepartmentAddButton.BackColor = Color.YellowGreen;
        }
        private void CalculateTotalPages()
        {
            int rowCount = dataGridView1.Rows.Count-1;
            _totalPage = rowCount / PageSize;
   
            if (rowCount % PageSize > 0)
                _totalPage += 1;
        }

        private DataTable GetCurrentRecords(int page, SqlConnection con)
        {
            var dt = new DataTable();

            if (page == 1)
            {
                _cmd2 = new SqlCommand("Select TOP " + PageSize + " * from Department  ORDER BY DepartmentId", con);
            }
            else
            {
                int previouspageLimit = (page - 1) * PageSize;

                _cmd2 = new SqlCommand("Select TOP " + PageSize +
                    " * from Department " +
                    "WHERE DepartmentId NOT IN " +
                "(Select TOP " + previouspageLimit + " DepartmentId from Department ORDER BY DepartmentId) ", con); // +
       
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

        private void DepartmentInsertForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
  
            DepartmentAddButton.BackColor = Color.YellowGreen;
            label3.Hide();
            Height = 615;
            label8.Hide();
            label9.Hide();
            departmentAddBox.Hide();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            buttonToolTip.SetToolTip(Department_Sgort_Name_Text_Box, "You can leave it empty if department has no short name.");
            buttonToolTip.SetToolTip(Department_Full_Name_Text_Box, "You must fill this field.");
            buttonToolTip.SetToolTip(PreviousPageButton, "Previous");
            buttonToolTip.SetToolTip(NextPageButton, "Next");
            buttonToolTip.SetToolTip(FirstPageButton, "First Page.");
            buttonToolTip.SetToolTip(LastPageButton, "Last Page.");
            buttonToolTip.SetToolTip(RefreshButton, "Reload.");
           
 LoadGridData();
            exitToolStripMenuItem.Enabled = false;


        }

        private void Department_Full_Name_Text_Box_KeyUp(object sender, KeyEventArgs e)
        {
            if (Department_Full_Name_Text_Box.Text != "")
            {
                label3.Hide();
            }
            else
            {
                label3.Show();
            }

           
        }

     

       
        private bool CheckIsDepartmentShortNameExist()
        {

       
            var sqlCommand =
                            new SqlCommand(
                                "select count(*) from Department  where DepartmentShortName=@DepartmentShortName",
                                _connection);

            sqlCommand.Parameters.AddWithValue("@DepartmentShortName", Department_Sgort_Name_Text_Box.Text);


            _connection.Open();
            return  Convert.ToBoolean(sqlCommand.ExecuteScalar());

        }
        private bool CheckIsDepartmentFullNameExist()
        {
            _connection.Close();
       
            var sqlCommand =
                            new SqlCommand(
                                "select count(*) from Department  where DepartmentFullName=@DepartmentFullName",
                                _connection);

            sqlCommand.Parameters.AddWithValue("@DepartmentFullName", Department_Full_Name_Text_Box.Text);


            _connection.Open();
            return Convert.ToBoolean(sqlCommand.ExecuteScalar());

        }
        private void FirstPageButton_Click(object sender, EventArgs e)
        {
         
         
            this._currentPageIndex = 1;
            this.dataGridView1.DataSource = GetCurrentRecords(this._currentPageIndex, _connection);
   
       
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (this._currentPageIndex < this._totalPage)
            {
                this._currentPageIndex++;
                this.dataGridView1.DataSource = GetCurrentRecords(this._currentPageIndex, _connection);
            }
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (this._currentPageIndex > 1)
            {
                this._currentPageIndex--;
                this.dataGridView1.DataSource = GetCurrentRecords(this._currentPageIndex, _connection);
            } 
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {

            this._currentPageIndex = _totalPage;
            this.dataGridView1.DataSource = GetCurrentRecords(this._currentPageIndex, _connection); 
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadGridData();

        }

        private void LoadGridData()
        {
            _cmd1 = new SqlCommand("Select * from Department order by DepartmentId", _connection);
            _ds = new DataSet();
            _adp1 = new SqlDataAdapter(_cmd1);
            _adp1.Fill(_ds, "Department");
            dataGridView1.DataSource = _ds;
            dataGridView1.DataMember = "Department";


            this.CalculateTotalPages();
            this.dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var value = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);

                _deleteId = value;
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
       
       
        }

        private void DepartmentDeleteButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (_deleteId > 1)
                {
                    var dialogResult = MessageBox.Show(@"Are you sure to delete this department parmanently?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _connection.Open();

                        var sqlCommand = new SqlCommand("delete from Department where  DepartmentId=@DeleteId", _connection);

                        sqlCommand.Parameters.AddWithValue("@DeleteId", _deleteId);

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show(@"Successfully deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  


                    }
                    else
                    {

                    
                        _deleteId = 0;
                    }

                }
                else
                {
                    MessageBox.Show(@"Please Select a row to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(@"You cann't delete this department as this department is related to other table as well.","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            finally
            {
                LoadGridData();
            }
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addNewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewDepartmentToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = true;
            dataGridView1.Hide();
            departmentAddBox.Show();
            Height =430;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewDepartmentToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = false;
            departmentAddBox.Hide();
            dataGridView1.Show();
            Height = 615;
        }

        private void DepartmentInsertForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 40;
            departmentAddBox.Width = this.Width - 40;
        }

        private void DepartmentAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var objHomeForm=new HomeForm();
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
