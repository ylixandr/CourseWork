namespace Login_and_Register_System
{
    partial class LoginForm
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
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.registrationButton = new System.Windows.Forms.Button();
			this.checkboxShowPass = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(78)))), ((int)(((byte)(165)))));
			this.label6.Location = new System.Drawing.Point(99, 398);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(168, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Создать аккаунт";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(67, 372);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Нету аккаунта?";
			// 
			// registrationButton
			// 
			this.registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.registrationButton.FlatAppearance.BorderSize = 0;
			this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registrationButton.ForeColor = System.Drawing.Color.White;
			this.registrationButton.Location = new System.Drawing.Point(38, 285);
			this.registrationButton.Name = "registrationButton";
			this.registrationButton.Size = new System.Drawing.Size(218, 28);
			this.registrationButton.TabIndex = 3;
			this.registrationButton.Text = "АВТОРИЗАЦИЯ";
			this.registrationButton.UseVisualStyleBackColor = false;
			this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click_1);
			// 
			// checkboxShowPass
			// 
			this.checkboxShowPass.AutoSize = true;
			this.checkboxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkboxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkboxShowPass.Location = new System.Drawing.Point(43, 223);
			this.checkboxShowPass.Name = "checkboxShowPass";
			this.checkboxShowPass.Size = new System.Drawing.Size(188, 27);
			this.checkboxShowPass.TabIndex = 2;
			this.checkboxShowPass.Text = "Показать пароль";
			this.checkboxShowPass.UseVisualStyleBackColor = true;
			this.checkboxShowPass.CheckedChanged += new System.EventHandler(this.checkboxShowPass_CheckedChanged_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Пароль";
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(38, 102);
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(218, 28);
			this.txtUsername.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Имя  пользователя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.label3.Location = new System.Drawing.Point(11, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(274, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Авторизация";
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(38, 177);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(218, 28);
			this.txtPassword.TabIndex = 1;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(289, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.registrationButton);
			this.Controls.Add(this.checkboxShowPass);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.CheckBox checkboxShowPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
    }
}