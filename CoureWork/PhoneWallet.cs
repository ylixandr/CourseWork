using CoureWork.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoureWork
{
	public partial class PhoneWallet : Form
	{
		public PhoneWallet()
		{
			InitializeComponent();
			
			if(comboBox1.Text == "")
			{
				placeholderTextBox2.Enabled = false;
			}
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			WalletForm walletForm = new WalletForm();
			walletForm.Show();
			this.Hide();
		}

		private void addBalance_Click(object sender, EventArgs e)
		{
			if (placeholderTextBox2.Text != "" )
			{
				if (balanceBox.Text != "")
				{
					using (ApplicationDbContext db = new ApplicationDbContext())
					{
						int id = db.Account.First(x => x.IsLoged).Id;
						db.Wallet.First(x => x.AccountId == id).Balance += Convert.ToDecimal(balanceBox.Text);
						db.SaveChanges();
						MessageBox.Show("Вы успешно пополнили баланс");
						MainForm mainForm = new MainForm();
						mainForm.Show();
						this.Hide();
					}
				}
				else
				{
					MessageBox.Show("Введите баланс", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					balanceBox.Text = "";
					balanceBox.Focus();

				}
			}
			else
			{
				MessageBox.Show("Неправильно введены данные", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				balanceBox.Text = "";
				placeholderTextBox2.Text = "";
				placeholderTextBox2.Focus();

			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "")
			{
				placeholderTextBox2.Enabled = false;
			}
			else placeholderTextBox2.Enabled = true;
		}
	}
}
