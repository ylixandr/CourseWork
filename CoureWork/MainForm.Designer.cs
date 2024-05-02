namespace CoureWork
{
	partial class MainForm
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.leftPanel = new System.Windows.Forms.Panel();
			this.userButton = new CoureWork.RoundButton();
			this.cartButton = new CoureWork.RoundButton();
			this.walletButton = new CoureWork.RoundButton();
			this.categoryButton = new CoureWork.RoundButton();
			this.eShopLabel = new System.Windows.Forms.Label();
			this.cartPicture = new System.Windows.Forms.PictureBox();
			this.userPicture = new System.Windows.Forms.PictureBox();
			this.userNameLabel = new System.Windows.Forms.Label();
			this.contactLabel = new System.Windows.Forms.Label();
			this.instPicture = new System.Windows.Forms.PictureBox();
			this.vkPicture = new System.Windows.Forms.PictureBox();
			this.telegPicture = new System.Windows.Forms.PictureBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.categoryControl = new CoureWork.CategoryControl();
			this.myLine3 = new CoureWork.Elements.MyLine();
			this.myLine2 = new CoureWork.Elements.MyLine();
			this.myLine1 = new CoureWork.Elements.MyLine();
			this.leftPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cartPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.instPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vkPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.telegPicture)).BeginInit();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.userButton);
			this.leftPanel.Controls.Add(this.cartButton);
			this.leftPanel.Controls.Add(this.walletButton);
			this.leftPanel.Controls.Add(this.categoryButton);
			this.leftPanel.Controls.Add(this.eShopLabel);
			this.leftPanel.Controls.Add(this.cartPicture);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(265, 768);
			this.leftPanel.TabIndex = 0;
			// 
			// userButton
			// 
			this.userButton.BackColor = System.Drawing.Color.Gainsboro;
			this.userButton.BackColor2 = System.Drawing.Color.Silver;
			this.userButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.userButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.userButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.userButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.userButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.userButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.userButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.userButton.ButtonRoundRadius = 30;
			this.userButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userButton.ForeColor = System.Drawing.Color.White;
			this.userButton.Location = new System.Drawing.Point(55, 473);
			this.userButton.Name = "userButton";
			this.userButton.Size = new System.Drawing.Size(170, 55);
			this.userButton.TabIndex = 1;
			this.userButton.Text = "Пользователь";
			this.userButton.Click += new System.EventHandler(this.userButton_Click);
			// 
			// cartButton
			// 
			this.cartButton.BackColor = System.Drawing.Color.Gainsboro;
			this.cartButton.BackColor2 = System.Drawing.Color.Silver;
			this.cartButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.cartButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.cartButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.cartButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.cartButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.cartButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.cartButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.cartButton.ButtonRoundRadius = 30;
			this.cartButton.ForeColor = System.Drawing.Color.White;
			this.cartButton.Location = new System.Drawing.Point(55, 385);
			this.cartButton.Name = "cartButton";
			this.cartButton.Size = new System.Drawing.Size(162, 56);
			this.cartButton.TabIndex = 1;
			this.cartButton.Text = "Корзина";
			// 
			// walletButton
			// 
			this.walletButton.BackColor = System.Drawing.Color.Gainsboro;
			this.walletButton.BackColor2 = System.Drawing.Color.Silver;
			this.walletButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.walletButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.walletButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.walletButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.walletButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.walletButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.walletButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.walletButton.ButtonRoundRadius = 30;
			this.walletButton.ForeColor = System.Drawing.Color.White;
			this.walletButton.Location = new System.Drawing.Point(55, 287);
			this.walletButton.Name = "walletButton";
			this.walletButton.Size = new System.Drawing.Size(162, 57);
			this.walletButton.TabIndex = 1;
			this.walletButton.Text = "Кошелек";
			// 
			// categoryButton
			// 
			this.categoryButton.BackColor = System.Drawing.Color.Gainsboro;
			this.categoryButton.BackColor2 = System.Drawing.Color.Silver;
			this.categoryButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.categoryButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.categoryButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.categoryButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.categoryButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.categoryButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.categoryButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.categoryButton.ButtonRoundRadius = 30;
			this.categoryButton.ForeColor = System.Drawing.Color.White;
			this.categoryButton.Location = new System.Drawing.Point(55, 194);
			this.categoryButton.Name = "categoryButton";
			this.categoryButton.Size = new System.Drawing.Size(162, 58);
			this.categoryButton.TabIndex = 1;
			this.categoryButton.Text = "Категории";
			this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
			// 
			// eShopLabel
			// 
			this.eShopLabel.BackColor = System.Drawing.Color.White;
			this.eShopLabel.ForeColor = System.Drawing.Color.Black;
			this.eShopLabel.Location = new System.Drawing.Point(84, 33);
			this.eShopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.eShopLabel.Name = "eShopLabel";
			this.eShopLabel.Size = new System.Drawing.Size(133, 42);
			this.eShopLabel.TabIndex = 1;
			this.eShopLabel.Text = "EShop";
			// 
			// cartPicture
			// 
			this.cartPicture.Image = ((System.Drawing.Image)(resources.GetObject("cartPicture.Image")));
			this.cartPicture.Location = new System.Drawing.Point(16, 33);
			this.cartPicture.Margin = new System.Windows.Forms.Padding(4);
			this.cartPicture.Name = "cartPicture";
			this.cartPicture.Size = new System.Drawing.Size(60, 42);
			this.cartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.cartPicture.TabIndex = 0;
			this.cartPicture.TabStop = false;
			// 
			// userPicture
			// 
			this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
			this.userPicture.Location = new System.Drawing.Point(759, 11);
			this.userPicture.Name = "userPicture";
			this.userPicture.Size = new System.Drawing.Size(55, 49);
			this.userPicture.TabIndex = 1;
			this.userPicture.TabStop = false;
			// 
			// userNameLabel
			// 
			this.userNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userNameLabel.Location = new System.Drawing.Point(860, 11);
			this.userNameLabel.Name = "userNameLabel";
			this.userNameLabel.Size = new System.Drawing.Size(132, 49);
			this.userNameLabel.TabIndex = 2;
			this.userNameLabel.Text = "ylixandr";
			// 
			// contactLabel
			// 
			this.contactLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.contactLabel.Location = new System.Drawing.Point(306, 719);
			this.contactLabel.Name = "contactLabel";
			this.contactLabel.Size = new System.Drawing.Size(146, 42);
			this.contactLabel.TabIndex = 6;
			this.contactLabel.Text = "Contact us:";
			this.contactLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// instPicture
			// 
			this.instPicture.Image = global::CoureWork.Properties.Resources.icons8_instagram_48;
			this.instPicture.Location = new System.Drawing.Point(458, 709);
			this.instPicture.Name = "instPicture";
			this.instPicture.Size = new System.Drawing.Size(77, 57);
			this.instPicture.TabIndex = 7;
			this.instPicture.TabStop = false;
			this.instPicture.Click += new System.EventHandler(this.instPicture_Click_1);
			// 
			// vkPicture
			// 
			this.vkPicture.Image = ((System.Drawing.Image)(resources.GetObject("vkPicture.Image")));
			this.vkPicture.Location = new System.Drawing.Point(599, 709);
			this.vkPicture.Name = "vkPicture";
			this.vkPicture.Size = new System.Drawing.Size(71, 52);
			this.vkPicture.TabIndex = 7;
			this.vkPicture.TabStop = false;
			this.vkPicture.Click += new System.EventHandler(this.vkPicture_Click);
			// 
			// telegPicture
			// 
			this.telegPicture.Image = ((System.Drawing.Image)(resources.GetObject("telegPicture.Image")));
			this.telegPicture.Location = new System.Drawing.Point(744, 709);
			this.telegPicture.Name = "telegPicture";
			this.telegPicture.Size = new System.Drawing.Size(70, 53);
			this.telegPicture.TabIndex = 7;
			this.telegPicture.TabStop = false;
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.categoryControl);
			this.mainPanel.Location = new System.Drawing.Point(272, 73);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(703, 618);
			this.mainPanel.TabIndex = 8;
			// 
			// categoryControl
			// 
			this.categoryControl.BackColor = System.Drawing.Color.White;
			this.categoryControl.Location = new System.Drawing.Point(0, 0);
			this.categoryControl.Name = "categoryControl";
			this.categoryControl.Size = new System.Drawing.Size(703, 618);
			this.categoryControl.TabIndex = 0;
			// 
			// myLine3
			// 
			this.myLine3.Location = new System.Drawing.Point(265, 697);
			this.myLine3.Name = "myLine3";
			this.myLine3.Size = new System.Drawing.Size(1039, 1);
			this.myLine3.TabIndex = 5;
			this.myLine3.Text = "myLine3";
			// 
			// myLine2
			// 
			this.myLine2.Location = new System.Drawing.Point(265, 66);
			this.myLine2.Name = "myLine2";
			this.myLine2.Size = new System.Drawing.Size(1039, 1);
			this.myLine2.TabIndex = 4;
			this.myLine2.Text = "myLine2";
			// 
			// myLine1
			// 
			this.myLine1.Location = new System.Drawing.Point(265, 66);
			this.myLine1.Name = "myLine1";
			this.myLine1.Size = new System.Drawing.Size(0, 0);
			this.myLine1.TabIndex = 3;
			this.myLine1.Text = "myLine1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 768);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.telegPicture);
			this.Controls.Add(this.vkPicture);
			this.Controls.Add(this.instPicture);
			this.Controls.Add(this.contactLabel);
			this.Controls.Add(this.myLine3);
			this.Controls.Add(this.myLine2);
			this.Controls.Add(this.myLine1);
			this.Controls.Add(this.userNameLabel);
			this.Controls.Add(this.userPicture);
			this.Controls.Add(this.leftPanel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.leftPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cartPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.instPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vkPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.telegPicture)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.PictureBox cartPicture;
		private System.Windows.Forms.Label eShopLabel;
		private RoundButton cartButton;
		private RoundButton walletButton;
		private RoundButton categoryButton;
		private System.Windows.Forms.PictureBox userPicture;
		private System.Windows.Forms.Label userNameLabel;
		private RoundButton userButton;
		private Elements.MyLine myLine1;
		private Elements.MyLine myLine3;
		private System.Windows.Forms.Label contactLabel;
		private System.Windows.Forms.PictureBox instPicture;
		private System.Windows.Forms.PictureBox vkPicture;
		private System.Windows.Forms.PictureBox telegPicture;
		private Elements.MyLine myLine2;
		private System.Windows.Forms.Panel mainPanel;
		private CategoryControl categoryControl;
	}
}

