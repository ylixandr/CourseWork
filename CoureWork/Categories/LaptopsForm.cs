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
	public partial class LaptopsForm : Form
	{

		int categoryLaptop = 4;
		string productType = "Laptop";
		public LaptopsForm()
		{
			InitializeComponent();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();

		}

		private void roundButton5_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
		}

		private void backButton_Click_1(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
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

		private void AddingToCart(int accountId, int productId, int categoryId, decimal productPrice, string productType, string productName)
		{
			DateTime purchaseDate = DateTime.Now;

			using (var context = new ApplicationDbContext())
			{
				// Проверка баланса пользователя
				int id = context.Account.FirstOrDefault(x => x.IsLoged).Id;
				

				
					// Проверка наличия телефона на складе
					int stock = context.Laptop.FirstOrDefault(s => s.Id == productId).Stock;
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
						context.Laptop.FirstOrDefault(x => x.Id == productId).Stock -= 1;

						context.SaveChanges();

						MessageBox.Show("Вы успешно добавили продукт в корзину.");
					}
					else
					{
						MessageBox.Show("Товар отсутствует на складе.");
					}
				}
				
			}
		

		private void roundButton1_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 1, categoryLaptop, Convert.ToDecimal(pricelabel0.Text), productType, label0.Text);

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
				AddingToCart(GetAccountId(), 2, categoryLaptop, Convert.ToDecimal(label2.Text), productType, label1.Text);

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
				AddingToCart(GetAccountId(), 3, categoryLaptop, Convert.ToDecimal(label4.Text), productType, label3.Text);

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
				AddingToCart(GetAccountId(), 7, categoryLaptop, Convert.ToDecimal(label6.Text), productType, label5.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void roundButton9_Click(object sender, EventArgs e)
		{
			try
			{
				AddingToCart(GetAccountId(), 8, categoryLaptop, Convert.ToDecimal(label14.Text), productType, label13.Text);

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
				AddingToCart(GetAccountId(), 9, categoryLaptop, Convert.ToDecimal(label12.Text), productType, label11.Text);

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
				AddingToCart(GetAccountId(), 10, categoryLaptop, Convert.ToDecimal(label10.Text), productType, label9.Text);

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
				AddingToCart(GetAccountId(), 11, categoryLaptop, Convert.ToDecimal(label8.Text), productType, label7.Text);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
	}
}
