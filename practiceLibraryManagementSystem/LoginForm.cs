using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace practiceLibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblIncorrect.Visible = false;
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPass.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else if (textBoxPassword.Text != "Password")
            {
                textBoxPassword.UseSystemPasswordChar= true;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.White;
            }           
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            //placeholder
            if(textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.White;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Silver;
            }
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=practiceLibraryManagementSystem;Integrated Security=True;");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (textBoxUsername.Text == "Username" || textBoxPassword.Text == "Password")
            {
                lblIncorrect.Text = "Username and password required.";
                lblIncorrect.Visible = true;
                return;
            }

            conn.Open();
           
            string query = "SELECT role from tbl_user WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            string role = (string)cmd.ExecuteScalar();

            try
            {
                if (role != null)
                {
                    if (role == "admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserForm userForm = new UserForm();
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    lblIncorrect.Text = "Incorrect username or password.";
                    lblIncorrect.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            lblIncorrect.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            lblIncorrect.Visible = false;
        }
    }
}
