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
using CoureWork.Context;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Remoting.Contexts;

namespace Login_and_Register_System
{
	public partial class LoginForm : Form
	{


		public LoginForm()
		{
			InitializeComponent();


		}

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
			string username = txtUsername.Text;
			string password = txtPassword.Text;

			try
			{
				using (ApplicationDbContext db = new ApplicationDbContext())
				{
					var user = db.Account.SingleOrDefault(a => a.UserName == username && a.Password == password);
					if (user != null)
					{
						// Успешный вход
						user.IsLoged = true;
						db.SaveChanges();

						MainForm main = new MainForm();
						main.Show();
						this.Hide();


					}
					else
					{
						MessageBox.Show("Неккоректные данные. Введите еще раз", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
						txtUsername.Text = "";
						txtPassword.Text = "";
						txtUsername.Focus();
					}
				}
				

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed {ex.Message}","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
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