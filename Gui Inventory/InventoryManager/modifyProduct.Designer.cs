
namespace InventoryManager
{
    partial class modifyProduct
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridAssociated = new System.Windows.Forms.DataGridView();
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textInventory = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssociated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1159, 825);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1045, 825);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1155, 757);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 29);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1155, 400);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 29);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridAssociated
            // 
            this.dataGridAssociated.AllowUserToAddRows = false;
            this.dataGridAssociated.AllowUserToDeleteRows = false;
            this.dataGridAssociated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssociated.Location = new System.Drawing.Point(534, 491);
            this.dataGridAssociated.Name = "dataGridAssociated";
            this.dataGridAssociated.ReadOnly = true;
            this.dataGridAssociated.RowHeadersWidth = 51;
            this.dataGridAssociated.RowTemplate.Height = 29;
            this.dataGridAssociated.Size = new System.Drawing.Size(715, 225);
            this.dataGridAssociated.TabIndex = 57;
            // 
            // dataGridParts
            // 
            this.dataGridParts.AllowUserToAddRows = false;
            this.dataGridParts.AllowUserToDeleteRows = false;
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Location = new System.Drawing.Point(534, 141);
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.ReadOnly = true;
            this.dataGridParts.RowHeadersWidth = 51;
            this.dataGridParts.RowTemplate.Height = 29;
            this.dataGridParts.Size = new System.Drawing.Size(715, 225);
            this.dataGridParts.TabIndex = 56;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(975, 26);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(258, 27);
            this.searchBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(844, 24);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 53;
            this.label1.Text = "Modify Product";
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(300, 521);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(74, 27);
            this.textMin.TabIndex = 4;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(159, 521);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(74, 27);
            this.textMax.TabIndex = 3;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(159, 471);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(125, 27);
            this.textPrice.TabIndex = 2;
            // 
            // textInventory
            // 
            this.textInventory.Location = new System.Drawing.Point(159, 417);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(125, 27);
            this.textInventory.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(159, 362);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 27);
            this.textName.TabIndex = 0;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(159, 306);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(125, 27);
            this.textID.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Price/Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "All Candidate Parts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(534, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Parts Associated with this Product";
            // 
            // modifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 862);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridAssociated);
            this.Controls.Add(this.dataGridParts);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textInventory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "modifyProduct";
            this.Text = "modifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssociated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridAssociated;
        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textInventory;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}