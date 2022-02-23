
namespace InventoryManager
{
    partial class IMS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchParts = new System.Windows.Forms.Button();
            this.searchBoxParts = new System.Windows.Forms.TextBox();
            this.searchProducts = new System.Windows.Forms.Button();
            this.searchBoxProducts = new System.Windows.Forms.TextBox();
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.deletePart = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.programLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // searchParts
            // 
            this.searchParts.Location = new System.Drawing.Point(276, 79);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(94, 29);
            this.searchParts.TabIndex = 0;
            this.searchParts.Text = "Search";
            this.searchParts.UseVisualStyleBackColor = true;
            this.searchParts.Click += new System.EventHandler(this.searchParts_Click);
            // 
            // searchBoxParts
            // 
            this.searchBoxParts.Location = new System.Drawing.Point(376, 79);
            this.searchBoxParts.Name = "searchBoxParts";
            this.searchBoxParts.Size = new System.Drawing.Size(170, 27);
            this.searchBoxParts.TabIndex = 1;
            // 
            // searchProducts
            // 
            this.searchProducts.Location = new System.Drawing.Point(1161, 79);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(94, 29);
            this.searchProducts.TabIndex = 5;
            this.searchProducts.Text = "Search";
            this.searchProducts.UseVisualStyleBackColor = true;
            this.searchProducts.Click += new System.EventHandler(this.searchProducts_Click);
            // 
            // searchBoxProducts
            // 
            this.searchBoxProducts.Location = new System.Drawing.Point(1261, 81);
            this.searchBoxProducts.Name = "searchBoxProducts";
            this.searchBoxProducts.Size = new System.Drawing.Size(169, 27);
            this.searchBoxProducts.TabIndex = 6;
            // 
            // dataGridParts
            // 
            this.dataGridParts.AllowUserToAddRows = false;
            this.dataGridParts.AllowUserToDeleteRows = false;
            this.dataGridParts.AllowUserToResizeColumns = false;
            this.dataGridParts.AllowUserToResizeRows = false;
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Location = new System.Drawing.Point(23, 114);
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.ReadOnly = true;
            this.dataGridParts.RowHeadersWidth = 51;
            this.dataGridParts.RowTemplate.Height = 29;
            this.dataGridParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParts.Size = new System.Drawing.Size(798, 362);
            this.dataGridParts.TabIndex = 7;
            this.dataGridParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.AllowUserToResizeColumns = false;
            this.dataGridProducts.AllowUserToResizeRows = false;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Enabled = false;
            this.dataGridProducts.Location = new System.Drawing.Point(954, 114);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.RowHeadersWidth = 51;
            this.dataGridProducts.RowTemplate.Height = 29;
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.Size = new System.Drawing.Size(812, 362);
            this.dataGridProducts.TabIndex = 8;
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(452, 499);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(94, 29);
            this.deletePart.TabIndex = 9;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(1382, 499);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(94, 29);
            this.deleteProduct.TabIndex = 10;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(352, 499);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(94, 29);
            this.modifyPart.TabIndex = 11;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(252, 499);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(94, 29);
            this.addPart.TabIndex = 12;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(1282, 499);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(94, 29);
            this.modifyProduct.TabIndex = 13;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(1182, 499);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(94, 29);
            this.addProduct.TabIndex = 14;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1282, 749);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 29);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partLabel.Location = new System.Drawing.Point(23, 86);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(53, 25);
            this.partLabel.TabIndex = 16;
            this.partLabel.Text = "Parts";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productLabel.Location = new System.Drawing.Point(954, 79);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(86, 25);
            this.productLabel.TabIndex = 17;
            this.productLabel.Text = "Products";
            // 
            // programLabel
            // 
            this.programLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programLabel.AutoSize = true;
            this.programLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.programLabel.Location = new System.Drawing.Point(757, 9);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(283, 28);
            this.programLabel.TabIndex = 18;
            this.programLabel.Text = "Invenotry Management System";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1788, 889);
            this.Controls.Add(this.programLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.partLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.dataGridParts);
            this.Controls.Add(this.searchBoxProducts);
            this.Controls.Add(this.searchProducts);
            this.Controls.Add(this.searchBoxParts);
            this.Controls.Add(this.searchParts);
            this.Name = "IMS";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.IMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchParts;
        private System.Windows.Forms.TextBox searchBoxParts;
        private System.Windows.Forms.Button searchProducts;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

