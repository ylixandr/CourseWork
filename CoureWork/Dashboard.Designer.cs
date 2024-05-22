namespace Login_and_Register_System
{
    partial class Dashboard
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.walletButton = new System.Windows.Forms.Button();
			this.homeButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.balanceLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.userNameLabel = new System.Windows.Forms.Label();
			this.dataGridViewCart = new System.Windows.Forms.DataGridView();
			this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.electronicStoreDataSet = new CoureWork.ElectronicStoreDataSet();
			this.cartTableAdapter = new CoureWork.ElectronicStoreDataSetTableAdapters.CartTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClearButton = new CoureWork.RoundButton();
			this.orderButton = new CoureWork.RoundButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.electronicStoreDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.label1.Location = new System.Drawing.Point(89, 108);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.walletButton);
			this.panel1.Controls.Add(this.homeButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(248, 747);
			this.panel1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(33, 271);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "👝";
			// 
			// walletButton
			// 
			this.walletButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.walletButton.FlatAppearance.BorderSize = 0;
			this.walletButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.walletButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.walletButton.Image = ((System.Drawing.Image)(resources.GetObject("walletButton.Image")));
			this.walletButton.Location = new System.Drawing.Point(0, 252);
			this.walletButton.Margin = new System.Windows.Forms.Padding(4);
			this.walletButton.Name = "walletButton";
			this.walletButton.Size = new System.Drawing.Size(248, 64);
			this.walletButton.TabIndex = 4;
			this.walletButton.Text = "Кошелек";
			this.walletButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.walletButton.UseVisualStyleBackColor = true;
			this.walletButton.Click += new System.EventHandler(this.walletButton_Click);
			// 
			// homeButton
			// 
			this.homeButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.homeButton.FlatAppearance.BorderSize = 0;
			this.homeButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
			this.homeButton.Location = new System.Drawing.Point(0, 180);
			this.homeButton.Margin = new System.Windows.Forms.Padding(4);
			this.homeButton.Name = "homeButton";
			this.homeButton.Size = new System.Drawing.Size(248, 64);
			this.homeButton.TabIndex = 3;
			this.homeButton.Text = "Домой";
			this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.homeButton.UseVisualStyleBackColor = true;
			this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.balanceLabel);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.userNameLabel);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(248, 177);
			this.panel2.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.label4.Location = new System.Drawing.Point(13, 111);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Имя";
			// 
			// balanceLabel
			// 
			this.balanceLabel.AutoSize = true;
			this.balanceLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.balanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.balanceLabel.Location = new System.Drawing.Point(94, 147);
			this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.balanceLabel.Name = "balanceLabel";
			this.balanceLabel.Size = new System.Drawing.Size(73, 17);
			this.balanceLabel.TabIndex = 2;
			this.balanceLabel.Text = "Balance";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.label2.Location = new System.Drawing.Point(13, 147);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Balance";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(81, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(84, 78);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// userNameLabel
			// 
			this.userNameLabel.AutoSize = true;
			this.userNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
			this.userNameLabel.Location = new System.Drawing.Point(94, 111);
			this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.userNameLabel.Name = "userNameLabel";
			this.userNameLabel.Size = new System.Drawing.Size(100, 17);
			this.userNameLabel.TabIndex = 0;
			this.userNameLabel.Text = "Some user ";
			this.userNameLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// dataGridViewCart
			// 
			this.dataGridViewCart.AutoGenerateColumns = false;
			this.dataGridViewCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accountIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn});
			this.dataGridViewCart.DataSource = this.cartBindingSource;
			this.dataGridViewCart.Location = new System.Drawing.Point(245, 3);
			this.dataGridViewCart.Name = "dataGridViewCart";
			this.dataGridViewCart.RowHeadersWidth = 52;
			this.dataGridViewCart.RowTemplate.Height = 24;
			this.dataGridViewCart.Size = new System.Drawing.Size(1331, 686);
			this.dataGridViewCart.TabIndex = 3;
			// 
			// cartBindingSource
			// 
			this.cartBindingSource.DataMember = "Cart";
			this.cartBindingSource.DataSource = this.electronicStoreDataSet;
			// 
			// electronicStoreDataSet
			// 
			this.electronicStoreDataSet.DataSetName = "ElectronicStoreDataSet";
			this.electronicStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cartTableAdapter
			// 
			this.cartTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 125;
			// 
			// accountIdDataGridViewTextBoxColumn
			// 
			this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
			this.accountIdDataGridViewTextBoxColumn.HeaderText = "AccountId";
			this.accountIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
			this.accountIdDataGridViewTextBoxColumn.Width = 80;
			// 
			// productIdDataGridViewTextBoxColumn
			// 
			this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
			this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
			this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
			this.productIdDataGridViewTextBoxColumn.Width = 125;
			// 
			// categoryIdDataGridViewTextBoxColumn
			// 
			this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
			this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
			this.categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
			this.categoryIdDataGridViewTextBoxColumn.Width = 125;
			// 
			// purchaseDateDataGridViewTextBoxColumn
			// 
			this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
			this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
			this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
			this.purchaseDateDataGridViewTextBoxColumn.Width = 125;
			// 
			// productPriceDataGridViewTextBoxColumn
			// 
			this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
			this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
			this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
			this.productPriceDataGridViewTextBoxColumn.Width = 125;
			// 
			// productTypeDataGridViewTextBoxColumn
			// 
			this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
			this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
			this.productTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
			this.productTypeDataGridViewTextBoxColumn.Width = 125;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
			this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// ClearButton
			// 
			this.ClearButton.BackColor = System.Drawing.Color.Gainsboro;
			this.ClearButton.BackColor2 = System.Drawing.Color.Silver;
			this.ClearButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.ClearButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.ClearButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.ClearButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.ClearButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.ClearButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.ClearButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.ClearButton.ButtonRoundRadius = 30;
			this.ClearButton.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearButton.Location = new System.Drawing.Point(1284, 695);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(190, 51);
			this.ClearButton.TabIndex = 5;
			this.ClearButton.Text = "Очистка корзины";
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// orderButton
			// 
			this.orderButton.BackColor = System.Drawing.Color.Lime;
			this.orderButton.BackColor2 = System.Drawing.Color.Chartreuse;
			this.orderButton.ButtonBorderColor = System.Drawing.Color.Black;
			this.orderButton.ButtonHighlightColor = System.Drawing.Color.Orange;
			this.orderButton.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
			this.orderButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
			this.orderButton.ButtonPressedColor = System.Drawing.Color.Red;
			this.orderButton.ButtonPressedColor2 = System.Drawing.Color.Maroon;
			this.orderButton.ButtonPressedForeColor = System.Drawing.Color.White;
			this.orderButton.ButtonRoundRadius = 30;
			this.orderButton.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orderButton.Location = new System.Drawing.Point(255, 695);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(182, 51);
			this.orderButton.TabIndex = 4;
			this.orderButton.Text = "Заказать все";
			this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1786, 747);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.orderButton);
			this.Controls.Add(this.dataGridViewCart);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.electronicStoreDataSet)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button homeButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button walletButton;
		private System.Windows.Forms.Label balanceLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridViewCart;
		private CoureWork.ElectronicStoreDataSet electronicStoreDataSet;
		private System.Windows.Forms.BindingSource cartBindingSource;
		private CoureWork.ElectronicStoreDataSetTableAdapters.CartTableAdapter cartTableAdapter;
		private CoureWork.RoundButton orderButton;
		private CoureWork.RoundButton ClearButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
	}
}