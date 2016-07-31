using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class SessionAddAndSearchForm : Form
    {
        public SessionAddAndSearchForm()
        {
            InitializeComponent(); BackColor = Color.CornflowerBlue;

            dataGridView1.Columns[0].Name = "SessionId";
            dataGridView1.Columns[0].HeaderText = @"Session ID";
            dataGridView1.Columns[0].DataPropertyName = "SessionId";
            dataGridView1.Columns[0].Width = 100;

            dataGridView1.Columns[1].Name = "SessionName";
            dataGridView1.Columns[1].HeaderText = @"                       Session";
            dataGridView1.Columns[1].DataPropertyName = "SessionName";
            dataGridView1.Columns[1].Width = 100;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SessionAddButton.BackColor = Color.DarkCyan;


            dataGridView1.ForeColor = Color.Black;

            var checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = @"                             Delete",
                Width = 30,
                Name = "checkBoxColumn"
            };
            dataGridView1.Columns.Insert(2, checkBoxColumn);
        }

        private int _deleteId = 0;

        private readonly SqlConnection _connection =
            new SqlConnection(@"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;");

        private void SessionAddAndSearchForm_Load(object sender, EventArgs e)
        {
            sessionAddBox.Hide();
            // TODO: This line of code loads data into the 'sessionDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.sessionDataSet.Session);
            label6.Hide();
            label7.Hide();
            label5.Hide();
            exitToolStripMenuItem.Enabled = false;
        }

   

    private void SessionAddButton_Click(object sender, EventArgs e)
        {
            if (SessionTextBox.Text == "")
            {
                label5.Show();
                label7.Hide();
          
            }
            if (SessionTextBox.Text == "") return;
            try
            {

                if (!CheckIsSessionExist())
                {
                    label6.Hide();

                    var sqlCommand = new SqlCommand("insert into Session values(@Session) ", _connection);

                    sqlCommand.Parameters.AddWithValue("@Session", SessionTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    _connection.Close();
                    SessionTextBox.Text = "";
                    MessageBox.Show(@"Inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.sessionTableAdapter.Fill(this.sessionDataSet.Session);

                }
                else
                {
                    _connection.Close();
                    label6.Show();
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);

            }
        }
        private bool CheckIsSessionExist()
        {

            var flag = false;
            var sqlCommand =
                            new SqlCommand(
                                "select count(*) from Session  where SessionName=@Session",
                                _connection);

            sqlCommand.Parameters.AddWithValue("@Session", SessionTextBox.Text);


            _connection.Open();
            return flag = Convert.ToBoolean(sqlCommand.ExecuteScalar());

        }

        private void SessionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SessionTextBox.Text == "")
            {
                label7.Hide();
                label5.Show();
              
            }
            if (SessionTextBox.Text == "") return;
            var r = new Regex(@"d+\-");

            var match = Regex.Match(SessionTextBox.Text, @"([0-9\-])$");
            if (!match.Success)
            {
                label5.Hide();
             
                label7.Show();
            }
            if (!match.Success) return;
            label5.Hide();
            label7.Hide();
          
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void SessionDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                List<DataGridViewRow> selectedRows = (from row in dataGridView1.Rows.Cast<DataGridViewRow>()
                                                      where Convert.ToBoolean(row.Cells["checkBoxColumn"].Value) == true
                                                      select row).ToList();
                if (selectedRows.Count > 0)
                {
                    if (
                MessageBox.Show(string.Format("Do you want to delete {0} row(s)?", selectedRows.Count), @"Confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            foreach (var row in selectedRows)
                            {



                                int deleteId = Convert.ToInt32(row.Cells["SessionId"].Value);

                                var command = new SqlCommand("delete  from Session where SessionId=@id", _connection);
                                command.Parameters.AddWithValue("@id", deleteId);
                                _connection.Open();
                                command.ExecuteNonQuery();
                                _connection.Close();

                            }

                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(@"Something went wrong.You cann't delete this session(s) as this session(s) is/are related to other table as well.","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                        finally
                        {
                            _connection.Close();
                            this.sessionTableAdapter.Fill(this.sessionDataSet.Session);
                        }

                    }
                    else
                    {
                        this.sessionTableAdapter.Fill(this.sessionDataSet.Session);
                    }
                }
                else
                {
                    MessageBox.Show(@"Please  check row/rows to delete", "", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
                }



            }
            catch (Exception)
            {


            }
        }



        private void addSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSessionToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = true;
            sessionAddBox.Show();
            dataGridView1.Hide();
            this.Height = 400;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            exitToolStripMenuItem.Enabled = false;
            addSessionToolStripMenuItem.Enabled = true;
            dataGridView1.Show(); sessionAddBox.Hide();
            this.Height = 585;
        }

        private void SessionAddAndSearchForm_AutoSizeChanged(object sender, EventArgs e)
        {
          
        }

        private void SessionAddAndSearchForm_Resize(object sender, EventArgs e)
        {
        
            dataGridView1.Width = this.Width - 40;
     
        }

        private void SessionAddAndSearchForm_FormClosed(object sender, FormClosedEventArgs e)
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
