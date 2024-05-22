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

namespace CoureWork.Categories
{
	public partial class SmartwatchForm : Form
	{

		int categorySwartwatch = 3;
		string productType = "Smartwatch";
		public SmartwatchForm()
		{
			InitializeComponent();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
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




		private void AddingToCart(int accountId, int productId, int categoryId, decimal productPrice, string productType, string productName)
		{
			DateTime purchaseDate = DateTime.Now;

			using (var context = new ApplicationDbContext())
			{
				
				int id = context.Account.FirstOrDefault(x => x.IsLoged).Id;
				

					// Проверка наличия телефона на складе
					int stock = context.Smartwatch.FirstOrDefault(s => s.Id == productId).Stock;
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

						

						// Обновление количества телефонов на складе
						context.Smartwatch.FirstOrDefault(x => x.Id == productId).Stock -= 1;

						context.SaveChanges();

						MessageBox.Show("Вы успешно добавили продукт в корзину.");
					}
					else
					{
						MessageBox.Show("Товар отсутствует на складе.");
					}
				
			}
		}

		private void roundButton9_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 5, categorySwartwatch, Convert.ToDecimal(priceLabelSamsung.Text), productType, samsungGalaxyNameLabel.Text);

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

		private void roundButton1_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 1, categorySwartwatch, Convert.ToDecimal(priceLabelRedmiWatch3.Text), productType, redmiWatch3NameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButton2_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 2, categorySwartwatch, Convert.ToDecimal(priceLabelHuaweiWatch4.Text), productType, huaweiWatch4Label.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButton3_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 3, categorySwartwatch, Convert.ToDecimal(priceLabelHuaweiWatchD.Text), productType, DhuaweiWatchDLabel.Text);

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
				AddingToCart(GetAccountId(), 4, categorySwartwatch, Convert.ToDecimal(priceLabelHuaweiWatchGT3.Text), productType, huaweiWatchGT3Label.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButton8_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 6, categorySwartwatch, Convert.ToDecimal(priceLabelXiamiRedmi.Text), productType, xiamiRedmiNameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButton7_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 7, categorySwartwatch, Convert.ToDecimal(priceLabelXInfinix.Text), productType, infinixNameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButton6_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 8, categorySwartwatch, Convert.ToDecimal(priceLabelHuaweiWatchFit.Text), productType, HuaweiWatchFittNameLabel.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
	}
}
