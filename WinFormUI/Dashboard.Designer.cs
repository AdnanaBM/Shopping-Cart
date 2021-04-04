namespace WinFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.databaseSectionGroup = new System.Windows.Forms.GroupBox();
            this.removeItem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.totalBoxPerProduct = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.amountOfProduct = new System.Windows.Forms.NumericUpDown();
            this.productsDropdown = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateSection = new System.Windows.Forms.GroupBox();
            this.applyDiscountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.shippingValue = new System.Windows.Forms.TextBox();
            this.subTotalvalue = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.shippingLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.databaseSectionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfProduct)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.calculateSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseSectionGroup
            // 
            this.databaseSectionGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("databaseSectionGroup.BackgroundImage")));
            this.databaseSectionGroup.Controls.Add(this.removeItem);
            this.databaseSectionGroup.Controls.Add(this.listView1);
            this.databaseSectionGroup.Controls.Add(this.addNewItemButton);
            this.databaseSectionGroup.Controls.Add(this.totalBoxPerProduct);
            this.databaseSectionGroup.Controls.Add(this.priceBox);
            this.databaseSectionGroup.Controls.Add(this.amountOfProduct);
            this.databaseSectionGroup.Controls.Add(this.productsDropdown);
            this.databaseSectionGroup.Controls.Add(this.menuStrip1);
            this.databaseSectionGroup.Location = new System.Drawing.Point(12, 183);
            this.databaseSectionGroup.Name = "databaseSectionGroup";
            this.databaseSectionGroup.Size = new System.Drawing.Size(623, 238);
            this.databaseSectionGroup.TabIndex = 0;
            this.databaseSectionGroup.TabStop = false;
            this.databaseSectionGroup.Text = "Shopping Cart";
            this.databaseSectionGroup.Enter += new System.EventHandler(this.databaseSectionGroup_Enter);
            // 
            // removeItem
            // 
            this.removeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItem.Location = new System.Drawing.Point(503, 201);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(111, 31);
            this.removeItem.TabIndex = 21;
            this.removeItem.Text = "Remove item";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 136);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 80;
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemButton.Location = new System.Drawing.Point(503, 164);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(111, 31);
            this.addNewItemButton.TabIndex = 19;
            this.addNewItemButton.Text = "Add new item";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            // 
            // totalBoxPerProduct
            // 
            this.totalBoxPerProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBoxPerProduct.Location = new System.Drawing.Point(486, 67);
            this.totalBoxPerProduct.Name = "totalBoxPerProduct";
            this.totalBoxPerProduct.ReadOnly = true;
            this.totalBoxPerProduct.Size = new System.Drawing.Size(120, 22);
            this.totalBoxPerProduct.TabIndex = 18;
            this.totalBoxPerProduct.Text = "29.99";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(216, 67);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(99, 22);
            this.priceBox.TabIndex = 17;
            this.priceBox.Text = "29.99";
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // amountOfProduct
            // 
            this.amountOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOfProduct.Location = new System.Drawing.Point(412, 67);
            this.amountOfProduct.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amountOfProduct.Name = "amountOfProduct";
            this.amountOfProduct.Size = new System.Drawing.Size(45, 22);
            this.amountOfProduct.TabIndex = 16;
            this.amountOfProduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productsDropdown
            // 
            this.productsDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsDropdown.FormattingEnabled = true;
            this.productsDropdown.Location = new System.Drawing.Point(3, 67);
            this.productsDropdown.Name = "productsDropdown";
            this.productsDropdown.Size = new System.Drawing.Size(174, 23);
            this.productsDropdown.TabIndex = 0;
            this.productsDropdown.SelectedIndexChanged += new System.EventHandler(this.productsDropdown_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.totalToolStripMenuItem2,
            this.totalToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(3, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "productMenu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 29);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 29);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 29);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(12, 29);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Padding = new System.Windows.Forms.Padding(95, 0, 70, 0);
            this.toolStripMenuItem5.Size = new System.Drawing.Size(234, 29);
            this.toolStripMenuItem5.Text = "Prince";
            // 
            // totalToolStripMenuItem2
            // 
            this.totalToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalToolStripMenuItem2.Name = "totalToolStripMenuItem2";
            this.totalToolStripMenuItem2.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.totalToolStripMenuItem2.Size = new System.Drawing.Size(112, 29);
            this.totalToolStripMenuItem2.Text = "Amount";
            // 
            // totalToolStripMenuItem3
            // 
            this.totalToolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalToolStripMenuItem3.Name = "totalToolStripMenuItem3";
            this.totalToolStripMenuItem3.Padding = new System.Windows.Forms.Padding(0);
            this.totalToolStripMenuItem3.Size = new System.Drawing.Size(56, 29);
            this.totalToolStripMenuItem3.Text = "Total";
            // 
            // calculateSection
            // 
            this.calculateSection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calculateSection.BackgroundImage")));
            this.calculateSection.Controls.Add(this.applyDiscountButton);
            this.calculateSection.Controls.Add(this.label1);
            this.calculateSection.Controls.Add(this.discountBox);
            this.calculateSection.Controls.Add(this.shippingValue);
            this.calculateSection.Controls.Add(this.subTotalvalue);
            this.calculateSection.Controls.Add(this.totalButton);
            this.calculateSection.Controls.Add(this.totalLabel);
            this.calculateSection.Controls.Add(this.totalText);
            this.calculateSection.Controls.Add(this.orderButton);
            this.calculateSection.Controls.Add(this.shippingLabel);
            this.calculateSection.Controls.Add(this.subTotalLabel);
            this.calculateSection.Location = new System.Drawing.Point(12, 421);
            this.calculateSection.Name = "calculateSection";
            this.calculateSection.Size = new System.Drawing.Size(623, 173);
            this.calculateSection.TabIndex = 7;
            this.calculateSection.TabStop = false;
            this.calculateSection.Text = "Total Amount";
            // 
            // applyDiscountButton
            // 
            this.applyDiscountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyDiscountButton.Location = new System.Drawing.Point(321, 131);
            this.applyDiscountButton.Name = "applyDiscountButton";
            this.applyDiscountButton.Size = new System.Drawing.Size(147, 35);
            this.applyDiscountButton.TabIndex = 22;
            this.applyDiscountButton.Text = "Apply discount";
            this.applyDiscountButton.UseVisualStyleBackColor = true;
            this.applyDiscountButton.Click += new System.EventHandler(this.applyDiscountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Discount";
            // 
            // discountBox
            // 
            this.discountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBox.Location = new System.Drawing.Point(145, 101);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(51, 22);
            this.discountBox.TabIndex = 20;
            this.discountBox.TextChanged += new System.EventHandler(this.discountBox_TextChanged);
            // 
            // shippingValue
            // 
            this.shippingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingValue.Location = new System.Drawing.Point(146, 66);
            this.shippingValue.Name = "shippingValue";
            this.shippingValue.ReadOnly = true;
            this.shippingValue.Size = new System.Drawing.Size(50, 22);
            this.shippingValue.TabIndex = 19;
            this.shippingValue.Text = "10";
            // 
            // subTotalvalue
            // 
            this.subTotalvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalvalue.Location = new System.Drawing.Point(146, 30);
            this.subTotalvalue.Name = "subTotalvalue";
            this.subTotalvalue.ReadOnly = true;
            this.subTotalvalue.Size = new System.Drawing.Size(50, 22);
            this.subTotalvalue.TabIndex = 18;
            this.subTotalvalue.Text = "0";
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(474, 133);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(72, 33);
            this.totalButton.TabIndex = 10;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(30, 139);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 25);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total";
            // 
            // totalText
            // 
            this.totalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.Location = new System.Drawing.Point(146, 138);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(99, 26);
            this.totalText.TabIndex = 9;
            this.totalText.TextChanged += new System.EventHandler(this.resultsText_TextChanged);
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(552, 131);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(71, 35);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // shippingLabel
            // 
            this.shippingLabel.AutoSize = true;
            this.shippingLabel.Location = new System.Drawing.Point(16, 62);
            this.shippingLabel.Name = "shippingLabel";
            this.shippingLabel.Size = new System.Drawing.Size(96, 25);
            this.shippingLabel.TabIndex = 5;
            this.shippingLabel.Text = "Shipping";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(16, 27);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(98, 25);
            this.subTotalLabel.TabIndex = 3;
            this.subTotalLabel.Text = "Sub-total";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 590);
            this.Controls.Add(this.calculateSection);
            this.Controls.Add(this.databaseSectionGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Be You Store";
            this.databaseSectionGroup.ResumeLayout(false);
            this.databaseSectionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfProduct)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.calculateSection.ResumeLayout(false);
            this.calculateSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox databaseSectionGroup;
        private System.Windows.Forms.ComboBox productsDropdown;
        private System.Windows.Forms.GroupBox calculateSection;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label shippingLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown amountOfProduct;
        private System.Windows.Forms.TextBox totalBoxPerProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem3;
        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox subTotalvalue;
        private System.Windows.Forms.TextBox shippingValue;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button applyDiscountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discountBox;
    }
}

