﻿using System;
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
		PhonesForm phonesForm = new PhonesForm();
		public MainForm()
		{
			InitializeComponent();
			leftPanel.BackColor = Color.FromArgb(83,66,194);
			eShopLabel.BackColor = Color.FromArgb(83, 66, 194);
			eShopLabel.ForeColor = Color.White;
			homeButton.BackColor = Color.FromArgb(83, 66, 194);
			categoryButton.BackColor = Color.FromArgb(83, 66, 194);
			walletButton.BackColor = Color.FromArgb(83, 66, 194);
			cartButton.BackColor = Color.FromArgb(83, 66, 194);
			homeButton.ForeColor = Color.White;
			homeButton.BackColor2 = Color.FromArgb(83, 66, 194);
			categoryButton.BackColor2 = Color.FromArgb(83, 66, 194);
			walletButton.BackColor2 = Color.FromArgb(83, 66, 194);
			cartButton.BackColor2 = Color.FromArgb(83, 66, 194);
			userButton.BackColor2 = Color.FromArgb(83, 66, 194);
			userButton.BackColor = Color.FromArgb(83, 66, 194);


			






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

		private void homeButton_Click(object sender, EventArgs e)
		{
			HomeButton();
		
		}

		private void HomeButton()
		{
			categoryControl.Visible = false;


			
		}

		private void CategoryButton()
		{
			categoryControl.Visible = true;
			
				
		}


	}
}
