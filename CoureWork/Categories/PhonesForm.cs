using CoureWork.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoureWork
{
	public partial class PhonesForm : Form
	{
		int phoneId = 1;
		string productType = "SmartPhone";
		public PhonesForm()
		{
			InitializeComponent();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void backButton_Click_1(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			Hide();
		}

		private void roundButton5_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			Hide();
		}

		private void backButton_Click_2(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			Hide();
		}
		private void roundButtonIphoneX_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 3, phoneId, Convert.ToDecimal(priceLabelIphone.Text), productType, iphoneNameLabel.Text);
				
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

		}

		private void roundButtonPocoM6_Click(object sender, EventArgs e)
		{

			try
			{
				AddingToCart(GetAccountId(), 7, phoneId, Convert.ToDecimal(priceLabelPocoM6.Text), productType, pocom6NameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
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

		private void roundButtonHuaweiP70_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 4, phoneId, Convert.ToDecimal(priceLabelHUAWEIP70.Text), productType, huaweip70NameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButtonSamsungA32_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 6, phoneId, Convert.ToDecimal(priceLabelSamsungA32.Text), productType, samsunga32NameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButton4_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 5, phoneId, Convert.ToDecimal(priceLabelXiami13PRo.Text), productType, xiamo13NameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButtonNote13_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 9, phoneId, Convert.ToDecimal(priceLabelIphoneRedmi13.Text), productType, note13NameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButtonIphone14_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 8, phoneId, Convert.ToDecimal(priceLabelIphone14.Text), productType, iphone14NameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButtonTexet_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 10, phoneId, Convert.ToDecimal(priceLabelTexet.Text), productType, texetNameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
		private void AddingToCart(int accountId, int productId, int categoryId, decimal productPrice, string productType, string productName)
		{
			DateTime purchaseDate = DateTime.Now;

			using (var context = new ApplicationDbContext())
			{
				// Проверка баланса пользователя
				int id = context.Account.FirstOrDefault(x => x.IsLoged).Id;
				

				
					// Проверка наличия телефона на складе
					int stock = context.Smartphone.FirstOrDefault(s => s.Id == productId).Stock;
					if (stock > 0)
					{
						// Вставка новой записи в корзину
						context.Database.ExecuteSqlCommand("AddToCart @AccountId, @ProductId, @CategoryId, @PurchaseDate, @ProductPrice, @ProductType, @ProductName",
							new SqlParameter("@AccountId", accountId),
							new SqlParameter("@ProductId", productId),
							new SqlParameter("@CategoryId", categoryId),
							new SqlParameter("@PurchaseDate", purchaseDate),
							new SqlParameter("@ProductPrice", productPrice),
							new SqlParameter("@ProductType", productType),
							new SqlParameter("@ProductName", productName));

						// Обновление баланса пользователя
						

						// Обновление количества телефонов на складе
						context.Smartphone.FirstOrDefault(x =>x.Id == productId).Stock -=1;

						context.SaveChanges();

						MessageBox.Show("Вы успешно добавили продукт в корзину.");
					}
					else
					{
						MessageBox.Show("Товар отсутствует на складе.");
					}
				
			}
		}




	}


}
