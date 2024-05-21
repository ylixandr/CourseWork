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
	public partial class CardWallet : Form
	{
		public CardWallet()
		{
			InitializeComponent();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			WalletForm walletForm = new WalletForm();
			walletForm.Show();
			this.Hide();
		}

		private void addBalance_Click(object sender, EventArgs e)
		{
			if (cardBox.Text != "")
			{
				if(balanceBox.Text!="")
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
				MessageBox.Show("Неправильно введены данные","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
				balanceBox.Text = "";
				cardBox.Text = "";
				cardBox.Focus();
				
			}
		}

		private void placeholderTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string s = cardBox.Text;
				if (s.Length == 16)
				{
					double sAsD = double.Parse(s);
					cardBox.Text = string.Format("{0:#### #### #### ####}", sAsD).ToString();
				}
				if (cardBox.Text.Length > 1)
					cardBox.SelectionStart = cardBox.Text.Length;
				cardBox.SelectionLength = 0;
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка попрубйте позже", "Попытка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cardBox.Text = "";
				balanceBox.Text = "";
			}


		}

		private bool CheckingFormat(string str, int countOfSymbols) => str.Length == countOfSymbols;
	
	}
}
