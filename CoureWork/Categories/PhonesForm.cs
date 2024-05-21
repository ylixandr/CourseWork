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
	public partial class PhonesForm : Form
	{
		
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
	}
}
