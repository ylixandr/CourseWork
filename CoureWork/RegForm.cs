using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Login_and_Register_System
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

		SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings.Get("MyConnection"));
		SqlCommand cmd = new SqlCommand();
		SqlDataAdapter da = new SqlDataAdapter();
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtComPassword.Text = "";
			txtUsername.Focus();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void registrationButton_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
			{
				MessageBox.Show("Неправильно введены данные", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtPassword.Text == txtComPassword.Text)
			{
				try
				{
					conn.Open();
					MessageBox.Show("Соединение открыто");
					string register = "INSERT INTO csharp_user (username,password) VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
					cmd = new SqlCommand(register, conn);
					cmd.ExecuteNonQuery();
					conn.Close();
					txtUsername.Text = "";
					txtPassword.Text = "";
					txtComPassword.Text = "";
					MessageBox.Show("Аккаунт успешно создан", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Пароли не совпадают, Попробуйте еще раз", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtComPassword.Text = "";
				txtPassword.Text = "";
				txtPassword.Focus();

			}
		}

		private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
		{
			if (checkboxShowPass.Checked)
			{
				txtPassword.PasswordChar = '\0';
				txtComPassword.PasswordChar = '\0';

			}
			else
			{
				txtPassword.PasswordChar = '*';
				txtComPassword.PasswordChar = '*';
			}
		}

		private void label6_Click_1(object sender, EventArgs e)
		{

			new LoginForm().Show();
			this.Hide();
		}

		private void clearButton_Click_1(object sender, EventArgs e)
		{
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtComPassword.Text = "";
			txtUsername.Focus();
		}
	}
}