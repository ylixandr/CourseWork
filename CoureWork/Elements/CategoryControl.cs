using CoureWork.Categories;
using CoureWork.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoureWork
{
	public partial class CategoryControl : UserControl
	{
		
		public CategoryControl()
		{
			InitializeComponent();
			
			
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void HomeControl_Load(object sender, EventArgs e)
		{

		}

		private void phoneButton_Click(object sender, EventArgs e)
		{
			PhonesForm phonesForm = new PhonesForm();
			phonesForm.Show();
			ParentForm.Hide();

		}

		private void phonesDesign2_Load(object sender, EventArgs e)
		{

		}

		private void laptopButton_Click(object sender, EventArgs e)
		{
			LaptopsForm laptopsForm = new LaptopsForm();
			laptopsForm.Show();
			ParentForm.Hide();
		}

		private void watchButton_Click(object sender, EventArgs e)
		{
			SmartwatchForm smartwatchForm = new SmartwatchForm();
			smartwatchForm.Show();
			ParentForm.Hide();
		}

		private void tvButton_Click(object sender, EventArgs e)
		{
			TVForm tVForm = new TVForm();
			tVForm.Show();
			ParentForm.Hide();
		}
	}
}
