﻿namespace CoureWork
{
	partial class WalletForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.balanceLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.backButton = new CoureWork.RoundButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.CausesValidation = false;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(5, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(406, 64);
			this.label1.TabIndex = 0;
			this.label1.Text = "ПОПОЛНЕНИЕ БАЛАНСА";
			// 
			// label2
			// 
			this.label2.CausesValidation = false;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.DimGray;
			this.label2.Location = new System.Drawing.Point(25, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(355, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "Выберите удобный для вас способ оплаты";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.balanceLabel);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(-4, 98);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(422, 95);
			this.panel1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.CausesValidation = false;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(122, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 47);
			this.label4.TabIndex = 4;
			this.label4.Text = "Ед.";
			// 
			// balanceLabel
			// 
			this.balanceLabel.CausesValidation = false;
			this.balanceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.balanceLabel.Location = new System.Drawing.Point(15, 49);
			this.balanceLabel.Name = "balanceLabel";
			this.balanceLabel.Size = new System.Drawing.Size(111, 47);
			this.balanceLabel.TabIndex = 3;
			this.balanceLabel.Text = "ЧЧЧЧ";
			// 
			// label3
			// 
			this.label3.CausesValidation = false;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(25, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(339, 37);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ваш баланс";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Location = new System.Drawing.Point(12, 214);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(368, 78);
			this.panel2.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(322, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 46);
			this.label8.TabIndex = 6;
			this.label8.Text = ">";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label7
			// 
			this.label7.CausesValidation = false;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.DimGray;
			this.label7.Location = new System.Drawing.Point(89, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(220, 40);
			this.label7.TabIndex = 4;
			this.label7.Text = "Visa, Master Card, БелКарт";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.CausesValidation = false;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(91, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(218, 24);
			this.label6.TabIndex = 5;
			this.label6.Text = "БАНКОВСКОЙ КАРТОЙ";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 78);
			this.label5.TabIndex = 0;
			this.label5.Text = "💳";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Location = new System.Drawing.Point(12, 298);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(368, 84);
			this.panel3.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(315, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 46);
			this.label9.TabIndex = 6;
			this.label9.Text = ">";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// label10
			// 
			this.label10.CausesValidation = false;
			this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.ForeColor = System.Drawing.Color.DimGray;
			this.label10.Location = new System.Drawing.Point(84, 38);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(220, 40);
			this.label10.TabIndex = 4;
			this.label10.Text = "МТС, Velcom, A1";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.CausesValidation = false;
			this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label11.Location = new System.Drawing.Point(84, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(225, 24);
			this.label11.TabIndex = 5;
			this.label11.Text = "ПО НОМЕРУ ТЕЛЕФОНА";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(3, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 78);
			this.label12.TabIndex = 0;
			this.label12.Text = "📱";
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
			this.backButton.Location = new System.Drawing.Point(95, 412);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(186, 54);
			this.backButton.TabIndex = 8;
			this.backButton.Text = "НАЗАД";
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// WalletForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 487);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WalletForm";
			this.Text = "WalletForm";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label balanceLabel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private RoundButton backButton;
	}
}