namespace CoureWork
{
	partial class PhoneWallet
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.placeholderTextBox2 = new CoureWork.Elements.PlaceholderTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.balanceBox = new CoureWork.Elements.PlaceholderTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addBalance = new CoureWork.RoundButton();
			this.backButton = new CoureWork.RoundButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(10, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(356, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "ПО НОМЕРУ ТЕЛЕФОНА";
			// 
			// placeholderTextBox2
			// 
			this.placeholderTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.placeholderTextBox2.Location = new System.Drawing.Point(40, 210);
			this.placeholderTextBox2.MinimumSize = new System.Drawing.Size(4, 30);
			this.placeholderTextBox2.Name = "placeholderTextBox2";
			this.placeholderTextBox2.PlaceholderText = "+375(00)000-00-00";
			this.placeholderTextBox2.Size = new System.Drawing.Size(298, 34);
			this.placeholderTextBox2.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(35, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 26);
			this.label3.TabIndex = 6;
			this.label3.Text = "Номер телефона";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "МТС",
            "Velcome",
            "A1"});
			this.comboBox1.Location = new System.Drawing.Point(40, 125);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(298, 33);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(35, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(233, 26);
			this.label2.TabIndex = 8;
			this.label2.Text = "Мобильный оператор";
			// 
			// balanceBox
			// 
			this.balanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.balanceBox.Location = new System.Drawing.Point(40, 292);
			this.balanceBox.MinimumSize = new System.Drawing.Size(4, 30);
			this.balanceBox.Name = "balanceBox";
			this.balanceBox.PlaceholderText = "";
			this.balanceBox.Size = new System.Drawing.Size(298, 34);
			this.balanceBox.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(35, 263);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 26);
			this.label4.TabIndex = 10;
			this.label4.Text = "Сумма пополнения";
			// 
			// addBalance
			// 
			this.addBalance.BackColor = System.Drawing.Color.SkyBlue;
			this.addBalance.BackColor2 = System.Drawing.Color.SteelBlue;
			this.addBalance.ButtonBorderColor = System.Drawing.Color.Black;
			this.addBalance.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.addBalance.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.addBalance.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.addBalance.ButtonPressedColor = System.Drawing.Color.Red;
			this.addBalance.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.addBalance.ButtonPressedForeColor = System.Drawing.Color.White;
			this.addBalance.ButtonRoundRadius = 30;
			this.addBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addBalance.Location = new System.Drawing.Point(100, 357);
			this.addBalance.Name = "addBalance";
			this.addBalance.Size = new System.Drawing.Size(168, 44);
			this.addBalance.TabIndex = 11;
			this.addBalance.Text = "ПОПОЛНИТЬ";
			this.addBalance.Click += new System.EventHandler(this.addBalance_Click);
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.Color.SkyBlue;
			this.backButton.BackColor2 = System.Drawing.Color.SteelBlue;
			this.backButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.backButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.backButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.backButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.backButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.backButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.backButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.backButton.ButtonRoundRadius = 30;
			this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.backButton.Location = new System.Drawing.Point(16, 357);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(39, 44);
			this.backButton.TabIndex = 12;
			this.backButton.Text = "<";
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// PhoneWallet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 421);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.addBalance);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.balanceBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.placeholderTextBox2);
			this.Controls.Add(this.label1);
			this.Name = "PhoneWallet";
			this.Text = "PhoneWallet";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Elements.PlaceholderTextBox placeholderTextBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private Elements.PlaceholderTextBox balanceBox;
		private System.Windows.Forms.Label label4;
		private RoundButton addBalance;
		private RoundButton backButton;
	}
}