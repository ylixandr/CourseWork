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
using CoureWork;

namespace Login_and_Register_System
{
    public partial class LoginForm : Form
    {
		

		public LoginForm()
		{
			InitializeComponent();
			
		}
		SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings.Get("MyConnection"));
		SqlCommand cmd = new SqlCommand();
		SqlDataAdapter da = new SqlDataAdapter();
		private void label6_Click(object sender, EventArgs e)
		{
			new frmRegister().Show();
			this.Hide();
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtUsername.Focus();
		}

	

		private void registrationButton_Click_1(object sender, EventArgs e)
		{
			if (conn != null && conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();
			string login = ("SELECT * FROM csharp_user WHERE username =  '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "' ");
			cmd = new SqlCommand(login, conn);
			SqlDataReader dr = cmd.ExecuteReader();


			if (dr.Read() == true)
			{
				
				conn.Close();
				new Dashboard().Show();
				Dashboard.instance.lbl.Text = txtUsername.Text;
				this.Hide();

				
				
			}
			else
			{
				MessageBox.Show("Неккоректные данные. Введите еще раз", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Text = "";
				txtPassword.Text = "";
				txtUsername.Focus();
				if (conn != null && conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
			}
		}

		private void checkboxShowPass_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkboxShowPass.Checked)
			{
				txtPassword.PasswordChar = '\0';
			}
			else
			{
				txtPassword.PasswordChar = '*';

			}
		}
	}
}