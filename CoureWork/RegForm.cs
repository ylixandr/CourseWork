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
using CoureWork.Context;
using CoureWork;

namespace Login_and_Register_System
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
			using (ApplicationDbContext dbContext = new ApplicationDbContext())
			{
				try
				{
					var accs = dbContext.Account.ToList();
					foreach (var ac in accs)
					{
						ac.IsLoged = false;
					}
					dbContext.SaveChanges();
					MessageBox.Show("Niharagua");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		
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

				using (ApplicationDbContext db = new ApplicationDbContext())
				{
					try
					{
						db.Account.Add(new Account(txtUsername.Text, txtPassword.Text));
						db.SaveChanges();
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