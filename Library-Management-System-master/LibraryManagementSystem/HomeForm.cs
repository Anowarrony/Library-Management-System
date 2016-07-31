using System;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();StartPosition=FormStartPosition.CenterScreen;
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookInsertForm = new BookAddForm("home");
            this.Hide();
            bookInsertForm.Show();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bookSearchForm = new BookSearchForm();
            bookSearchForm.Show();
        }

        private void studentDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deiDepartmentInsertForm = new DepartmentAddForm();

            deiDepartmentInsertForm.Show();
        }

        private void studentSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sessionAddAndSearchForm = new SessionAddAndSearchForm();

            sessionAddAndSearchForm.Show();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentInsertForm = new StudentInsertForm();

            studentInsertForm.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close3b;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close3a;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
