﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoureWork.Categories
{
	public partial class TVForm : Form
	{
		public TVForm()
		{
			InitializeComponent();
		}

		private void backButton_Click(object sender, EventArgs e)
		{

		}

		private void backButton_Click_1(object sender, EventArgs e)
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
	}
}