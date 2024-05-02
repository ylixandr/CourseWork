namespace CoureWork
{
	partial class CategoryControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
			this.panel1 = new System.Windows.Forms.Panel();
			this.phonePanel = new System.Windows.Forms.Panel();
			this.phonePicture = new System.Windows.Forms.PictureBox();
			this.phoneButton = new CoureWork.RoundButton();
			this.laptopPanel = new System.Windows.Forms.Panel();
			this.laptopPicture = new System.Windows.Forms.PictureBox();
			this.laptopButton = new CoureWork.RoundButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.watchPanel = new System.Windows.Forms.Panel();
			this.watchPicture = new System.Windows.Forms.PictureBox();
			this.watchButton = new CoureWork.RoundButton();
			this.tvPanel = new System.Windows.Forms.Panel();
			this.tvPicture = new System.Windows.Forms.PictureBox();
			this.tvButton = new CoureWork.RoundButton();
			this.panelCategory = new System.Windows.Forms.Panel();
			this.phonePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.phonePicture)).BeginInit();
			this.laptopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.laptopPicture)).BeginInit();
			this.watchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.watchPicture)).BeginInit();
			this.tvPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tvPicture)).BeginInit();
			this.panelCategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(19, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 280);
			this.panel1.TabIndex = 0;
			// 
			// phonePanel
			// 
			this.phonePanel.Controls.Add(this.phonePicture);
			this.phonePanel.Controls.Add(this.phoneButton);
			this.phonePanel.Location = new System.Drawing.Point(19, 19);
			this.phonePanel.Name = "phonePanel";
			this.phonePanel.Size = new System.Drawing.Size(306, 286);
			this.phonePanel.TabIndex = 0;
			// 
			// phonePicture
			// 
			this.phonePicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.phonePicture.Image = ((System.Drawing.Image)(resources.GetObject("phonePicture.Image")));
			this.phonePicture.Location = new System.Drawing.Point(0, 0);
			this.phonePicture.Name = "phonePicture";
			this.phonePicture.Size = new System.Drawing.Size(306, 246);
			this.phonePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.phonePicture.TabIndex = 3;
			this.phonePicture.TabStop = false;
			// 
			// phoneButton
			// 
			this.phoneButton.BackColor = System.Drawing.Color.Gainsboro;
			this.phoneButton.BackColor2 = System.Drawing.Color.Silver;
			this.phoneButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.phoneButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.phoneButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.phoneButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.phoneButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.phoneButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.phoneButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.phoneButton.ButtonRoundRadius = 30;
			this.phoneButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.phoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.phoneButton.Location = new System.Drawing.Point(0, 246);
			this.phoneButton.Name = "phoneButton";
			this.phoneButton.Size = new System.Drawing.Size(306, 40);
			this.phoneButton.TabIndex = 2;
			this.phoneButton.Text = "Подробнее→";
			this.phoneButton.Click += new System.EventHandler(this.phoneButton_Click);
			// 
			// laptopPanel
			// 
			this.laptopPanel.Controls.Add(this.laptopPicture);
			this.laptopPanel.Controls.Add(this.laptopButton);
			this.laptopPanel.Location = new System.Drawing.Point(379, 19);
			this.laptopPanel.Name = "laptopPanel";
			this.laptopPanel.Size = new System.Drawing.Size(306, 286);
			this.laptopPanel.TabIndex = 1;
			// 
			// laptopPicture
			// 
			this.laptopPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laptopPicture.Image = ((System.Drawing.Image)(resources.GetObject("laptopPicture.Image")));
			this.laptopPicture.Location = new System.Drawing.Point(0, 0);
			this.laptopPicture.Name = "laptopPicture";
			this.laptopPicture.Size = new System.Drawing.Size(306, 246);
			this.laptopPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.laptopPicture.TabIndex = 3;
			this.laptopPicture.TabStop = false;
			// 
			// laptopButton
			// 
			this.laptopButton.BackColor = System.Drawing.Color.Gainsboro;
			this.laptopButton.BackColor2 = System.Drawing.Color.Silver;
			this.laptopButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.laptopButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.laptopButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.laptopButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.laptopButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.laptopButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.laptopButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.laptopButton.ButtonRoundRadius = 30;
			this.laptopButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.laptopButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laptopButton.Location = new System.Drawing.Point(0, 246);
			this.laptopButton.Name = "laptopButton";
			this.laptopButton.Size = new System.Drawing.Size(306, 40);
			this.laptopButton.TabIndex = 2;
			this.laptopButton.Text = "Подробнее→";
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(22, 329);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(240, 225);
			this.panel4.TabIndex = 1;
			// 
			// watchPanel
			// 
			this.watchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.watchPanel.Controls.Add(this.watchPicture);
			this.watchPanel.Controls.Add(this.watchButton);
			this.watchPanel.Location = new System.Drawing.Point(22, 326);
			this.watchPanel.Name = "watchPanel";
			this.watchPanel.Size = new System.Drawing.Size(306, 284);
			this.watchPanel.TabIndex = 1;
			// 
			// watchPicture
			// 
			this.watchPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.watchPicture.Image = ((System.Drawing.Image)(resources.GetObject("watchPicture.Image")));
			this.watchPicture.Location = new System.Drawing.Point(0, 0);
			this.watchPicture.Name = "watchPicture";
			this.watchPicture.Size = new System.Drawing.Size(302, 240);
			this.watchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.watchPicture.TabIndex = 4;
			this.watchPicture.TabStop = false;
			// 
			// watchButton
			// 
			this.watchButton.BackColor = System.Drawing.Color.Gainsboro;
			this.watchButton.BackColor2 = System.Drawing.Color.Silver;
			this.watchButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.watchButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.watchButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.watchButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.watchButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.watchButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.watchButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.watchButton.ButtonRoundRadius = 30;
			this.watchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.watchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.watchButton.Location = new System.Drawing.Point(0, 240);
			this.watchButton.Name = "watchButton";
			this.watchButton.Size = new System.Drawing.Size(302, 40);
			this.watchButton.TabIndex = 3;
			this.watchButton.Text = "Подробнее→";
			// 
			// tvPanel
			// 
			this.tvPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tvPanel.Controls.Add(this.tvPicture);
			this.tvPanel.Controls.Add(this.tvButton);
			this.tvPanel.Location = new System.Drawing.Point(379, 322);
			this.tvPanel.Name = "tvPanel";
			this.tvPanel.Size = new System.Drawing.Size(306, 286);
			this.tvPanel.TabIndex = 1;
			// 
			// tvPicture
			// 
			this.tvPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvPicture.Image = ((System.Drawing.Image)(resources.GetObject("tvPicture.Image")));
			this.tvPicture.Location = new System.Drawing.Point(0, 0);
			this.tvPicture.Name = "tvPicture";
			this.tvPicture.Size = new System.Drawing.Size(302, 242);
			this.tvPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tvPicture.TabIndex = 3;
			this.tvPicture.TabStop = false;
			// 
			// tvButton
			// 
			this.tvButton.BackColor = System.Drawing.Color.Gainsboro;
			this.tvButton.BackColor2 = System.Drawing.Color.Silver;
			this.tvButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.tvButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.tvButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.tvButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.tvButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.tvButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.tvButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.tvButton.ButtonRoundRadius = 30;
			this.tvButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tvButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tvButton.Location = new System.Drawing.Point(0, 242);
			this.tvButton.Name = "tvButton";
			this.tvButton.Size = new System.Drawing.Size(302, 40);
			this.tvButton.TabIndex = 2;
			this.tvButton.Text = "Подробнее→";
			// 
			// panelCategory
			// 
			this.panelCategory.Controls.Add(this.laptopPanel);
			this.panelCategory.Controls.Add(this.tvPanel);
			this.panelCategory.Controls.Add(this.phonePanel);
			this.panelCategory.Controls.Add(this.watchPanel);
			this.panelCategory.Controls.Add(this.panel1);
			this.panelCategory.Location = new System.Drawing.Point(3, 0);
			this.panelCategory.Name = "panelCategory";
			this.panelCategory.Size = new System.Drawing.Size(700, 618);
			this.panelCategory.TabIndex = 2;
			// 
			// CategoryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panelCategory);
			this.Controls.Add(this.panel4);
			this.Name = "CategoryControl";
			this.Size = new System.Drawing.Size(703, 618);
			this.Load += new System.EventHandler(this.HomeControl_Load);
			this.phonePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.phonePicture)).EndInit();
			this.laptopPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.laptopPicture)).EndInit();
			this.watchPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.watchPicture)).EndInit();
			this.tvPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tvPicture)).EndInit();
			this.panelCategory.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel phonePanel;
		private System.Windows.Forms.Panel laptopPanel;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel watchPanel;
		private System.Windows.Forms.Panel tvPanel;
		private System.Windows.Forms.PictureBox phonePicture;
		private RoundButton phoneButton;
		private System.Windows.Forms.PictureBox laptopPicture;
		private RoundButton laptopButton;
		private System.Windows.Forms.PictureBox watchPicture;
		private RoundButton watchButton;
		private System.Windows.Forms.PictureBox tvPicture;
		private RoundButton tvButton;
		
		private System.Windows.Forms.Panel panelCategory;
		
	}
}
