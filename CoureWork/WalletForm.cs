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
	public partial class WalletForm : Form
	{
		public WalletForm()
		{
			InitializeComponent();
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				int id = db.Account.First(x =>x.IsLoged).Id;
				balanceLabel.Text = db.Wallet.First(x => x.AccountId == id).Balance.ToString();
			}
		}

		

		private void backButton_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
		}

		private void label8_Click(object sender, EventArgs e)
		{
			CardWallet cardWallet = new CardWallet();
			cardWallet.Show();
			this.Hide();
		}

		private void label9_Click(object sender, EventArgs e)
		{
			PhoneWallet phoneWallet = new PhoneWallet();
			phoneWallet.Show();
			this.Hide();
		}
	}
}
