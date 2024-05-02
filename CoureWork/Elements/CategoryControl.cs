using CoureWork.Elements;
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
			this.Hide();

		}

		private void phonesDesign2_Load(object sender, EventArgs e)
		{

		}
	}
}
