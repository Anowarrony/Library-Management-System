using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent(); BackColor = Color.CornflowerBlue;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private const string Connection = @"data source=.\SQLEXPRESS;DATABASE=Library ;Integrated Security=true;";

        private void userNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                label3.Show();
            }
            else
            {
                label3.Hide();
            }
        }

        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                label4.Show();
            }
            else
            {
                label4.Hide();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                label3.Show();
            }

            if (passwordTextBox.Text == "")
            {
                label4.Show();
            }
            if (userNameTextBox.Text != "")
            {
                label3.Hide();
            }

            if (passwordTextBox.Text != "")
            {
                label4.Hide();
            }


            if (userNameTextBox.Text == "" || passwordTextBox.Text == "") return;
        
            if (CheckIsLogin())
            {
                UpdateLoginTime();
             
                this.Hide();
                var home = new HomeForm();
                home.Show();
           
            }
            else
            {
                label5.Show();
                errorProvider1.SetError(pictureBox1, "Invalid");
           
            }
        }

        private void UpdateLoginTime()
        {
          
      
            using (  var connection = new SqlConnection(Connection))
            {

                var sqlCommand =
                          new SqlCommand(
                              "update Login set LastLoginTime=@currentTime where Username=@username",
                              connection);

                sqlCommand.Parameters.AddWithValue("@currentTime", DateTime.Now);

                sqlCommand.Parameters.AddWithValue("@username", userNameTextBox.Text);

                connection.Open();
                sqlCommand.ExecuteNonQuery(); 
            
            }

          
   
        }

        bool CheckIsLogin()
        {
            var connection = new SqlConnection(Connection);
      
            using (connection)
            {
                var sqlCommand =
                            new SqlCommand(
                                "select count(*) from Login  where Username=@username and Password=@password",
                                connection);

                sqlCommand.Parameters.AddWithValue("@username", userNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@password", passwordTextBox.Text);

              connection.Open();

              return Convert.ToBoolean(sqlCommand.ExecuteScalar());
             
            }
          

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
        
         
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.Close3b;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.Close3a;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

      

      
    }
}
