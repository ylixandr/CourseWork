using CoureWork;
using CoureWork.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
				int accountId = db.Account.FirstOrDefault(x => x.IsLoged).Id;
                userNameLabel.Text = db.Account.FirstOrDefault(x => x.IsLoged).UserName.ToString();
				balanceLabel.Text = db.Wallet.First(x => x.AccountId == db.Account.FirstOrDefault(a => a.IsLoged).Id).Balance.ToString();
				cartBindingSource.DataSource = db.Cart.Where(x => x.AccountId == accountId).ToList();
			}
			
			
		}

		


		private void Dashboard_Load(object sender, EventArgs e)
        {
			
			this.cartTableAdapter.Fill(this.electronicStoreDataSet.Cart);

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

		private void orderButton_Click(object sender, EventArgs e)
		{
			
			int accountId = GetAccountId();

			try
			{
				using (ApplicationDbContext db = new ApplicationDbContext())
				{
					
					decimal accountWalletBalance = db.Wallet.FirstOrDefault(x => x.AccountId == accountId).Balance;
					var cartDetails = db.Cart
						.Where(c => c.AccountId == accountId)
						.Select(c => new { Price = c.ProductPrice })
						.ToList();

					decimal productsPrice = cartDetails.Sum(c => c.Price);

					
					if (accountWalletBalance < productsPrice)
					{
						MessageBox.Show("Пополните баланс", "Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
						WalletForm walletForm = new WalletForm();
						walletForm.Show();
						this.Hide();
					}
					else
					{
						db.Wallet.FirstOrDefault(x =>x.AccountId ==accountId).Balance -= productsPrice;
						MessageBox.Show("Вы успешно заказали товары", "Ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
						db.SaveChanges();
				
						ClearCart(); 
						balanceLabel.Text =db.Wallet.FirstOrDefault(x =>x.AccountId ==accountId).Balance.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			ClearCart();
		}

		private void ClearCart()
		{
			using (var context = new ApplicationDbContext())
			{
				try
				{
					int accountId = context.Account.FirstOrDefault(x => x.IsLoged).Id;
					var loggedAccount = context.Account.FirstOrDefault(a => a.IsLoged);




					var accountIdParam = new SqlParameter("@AccountId", accountId);
					context.Database.ExecuteSqlCommand("EXEC ClearCartByAccountId @AccountId", accountIdParam);
					cartBindingSource.DataSource = null;



					MessageBox.Show("Корзина очищена");
					orderButton.Enabled = false;


				}
				catch (Exception ex)
				{
					MessageBox.Show("Ошибка: " + ex.Message);
				}
			}
		}

		private int GetAccountId()
		{
			int id = 0;
			using (ApplicationDbContext context = new ApplicationDbContext())
			{
				id = context.Account.FirstOrDefault(x => x.IsLoged).Id;
			}
			return id;
		}

	}
}
