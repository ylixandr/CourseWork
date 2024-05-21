using CoureWork.Context;
using Login_and_Register_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoureWork
{
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			InitializeComponent();
			leftPanel.BackColor = Color.FromArgb(83,66,194);
			eShopLabel.BackColor = Color.FromArgb(83, 66, 194);
			eShopLabel.ForeColor = Color.White;
			
			categoryButton.BackColor = Color.FromArgb(83, 66, 194);
			walletButton.BackColor = Color.FromArgb(83, 66, 194);
			cartButton.BackColor = Color.FromArgb(83, 66, 194);
			
			categoryButton.BackColor2 = Color.FromArgb(83, 66, 194);
			walletButton.BackColor2 = Color.FromArgb(83, 66, 194);
			cartButton.BackColor2 = Color.FromArgb(83, 66, 194);
			userButton.BackColor2 = Color.FromArgb(83, 66, 194);
			userButton.BackColor = Color.FromArgb(83, 66, 194);
			using(ApplicationDbContext db = new ApplicationDbContext())
			{
				var accountId = db.Account.First(x => x.IsLoged).Id;
				balanceLabel.Text = db.Wallet.First(x => x.AccountId == accountId).Balance.ToString();
			}


			






		}


		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void instPicture_Click(object sender, EventArgs e)
		{
			string instagramUrl = "https://metanit.com/sharp/windowsforms/3.2.php";
			string url = "https://instagram.com";
			// Открываем URL в веб-браузере по умолчанию
			
			Process.Start(new ProcessStartInfo
			{
				FileName = instagramUrl,
				UseShellExecute = true
			});
		}

		private void myLine1_Click(object sender, EventArgs e)
		{

		}

		

		private void vkPicture_Click(object sender, EventArgs e)
		{
			string url = "https://vk.com/id268824318";
			Process.Start(new ProcessStartInfo
			{
				FileName = url,
				UseShellExecute = true
			});
		}

		private void instPicture_Click_1(object sender, EventArgs e)
		{
			
			string url = "https://www.instagram.com/ylixandr";
			// Открываем URL в веб-браузере по умолчанию

			Process.Start(new ProcessStartInfo
			{
				FileName = url,
				UseShellExecute = true
			});
		}

		private void categoryButton_Click(object sender, EventArgs e)
		{
			CategoryButton();
			
			
		}

		

		

		private void CategoryButton()
		{
			if(categoryControl.Visible)
			{
				categoryControl.Visible = false;
			}
			else
			{
				categoryControl.Visible = true;
			}
			
			
				
		}

		private void userButton_Click(object sender, EventArgs e)
		{
			frmRegister frmRegister = new frmRegister();
			frmRegister.Show();
			this.Hide();
			
			
			
		}

		public void UpdateUserName(string userName)
		{
			balanceLabel.Text = userName;
		}

		private void walletButton_Click(object sender, EventArgs e)
		{
			WalletForm walletForm = new WalletForm();
			walletForm.Show();
			this.Hide();
		}

		private void cartButton_Click(object sender, EventArgs e)
		{
			Dashboard dashboard = new Dashboard();
			dashboard.Show();
			this.Hide();
		}
	}
}
