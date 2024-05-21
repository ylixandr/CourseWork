using CoureWork;
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

namespace Login_and_Register_System
{
    public partial class Dashboard : Form
    {
      
        public Dashboard()
        {
            InitializeComponent();
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                userNameLabel.Text = db.Account.FirstOrDefault(x => x.IsLoged).UserName.ToString();
				balanceLabel.Text = db.Wallet.First(x => x.AccountId == db.Account.FirstOrDefault(a => a.IsLoged).Id).Balance.ToString();

			}
		}

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

		private void homeButton_Click(object sender, EventArgs e)
		{
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();

		}

		private void walletButton_Click(object sender, EventArgs e)
		{
            WalletForm walletForm = new WalletForm();
            walletForm.Show();
            this.Hide();
		}
	}
}
