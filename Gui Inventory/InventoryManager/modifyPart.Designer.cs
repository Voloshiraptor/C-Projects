
namespace InventoryManager
{
    partial class modifyPart
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
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMachineName = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textInventory = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.cancelModifyPart = new System.Windows.Forms.Button();
            this.saveModifyPart = new System.Windows.Forms.Button();
            this.idCompanyLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(482, 339);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(74, 27);
            this.textMin.TabIndex = 5;
            // 
            // textMachineName
            // 
            this.textMachineName.Location = new System.Drawing.Point(341, 390);
            this.textMachineName.Name = "textMachineName";
            this.textMachineName.Size = new System.Drawing.Size(125, 27);
            this.textMachineName.TabIndex = 6;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(341, 339);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(74, 27);
            this.textMax.TabIndex = 4;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(341, 289);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(125, 27);
            this.textPrice.TabIndex = 3;
            // 
            // textInventory
            // 
            this.textInventory.Location = new System.Drawing.Point(341, 235);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(125, 27);
            this.textInventory.TabIndex = 2;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(341, 180);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 27);
            this.textName.TabIndex = 1;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(341, 124);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(125, 27);
            this.textID.TabIndex = 32;
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Location = new System.Drawing.Point(450, 27);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(106, 24);
            this.radioOutsourced.TabIndex = 10;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            this.radioOutsourced.CheckedChanged += new System.EventHandler(this.radioOutsourced_CheckedChanged);
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Location = new System.Drawing.Point(232, 27);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(90, 24);
            this.radioInHouse.TabIndex = 9;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.UseVisualStyleBackColor = true;
            this.radioInHouse.CheckedChanged += new System.EventHandler(this.radioInHouse_CheckedChanged);
            // 
            // cancelModifyPart
            // 
            this.cancelModifyPart.Location = new System.Drawing.Point(432, 513);
            this.cancelModifyPart.Name = "cancelModifyPart";
            this.cancelModifyPart.Size = new System.Drawing.Size(94, 29);
            this.cancelModifyPart.TabIndex = 8;
            this.cancelModifyPart.Text = "Cancel";
            this.cancelModifyPart.UseVisualStyleBackColor = true;
            this.cancelModifyPart.Click += new System.EventHandler(this.cancelModifyPart_Click);
            // 
            // saveModifyPart
            // 
            this.saveModifyPart.Location = new System.Drawing.Point(298, 513);
            this.saveModifyPart.Name = "saveModifyPart";
            this.saveModifyPart.Size = new System.Drawing.Size(94, 29);
            this.saveModifyPart.TabIndex = 7;
            this.saveModifyPart.Text = "Save";
            this.saveModifyPart.UseVisualStyleBackColor = true;
            // 
            // idCompanyLabel
            // 
            this.idCompanyLabel.AutoSize = true;
            this.idCompanyLabel.Location = new System.Drawing.Point(181, 393);
            this.idCompanyLabel.Name = "idCompanyLabel";
            this.idCompanyLabel.Size = new System.Drawing.Size(84, 20);
            this.idCompanyLabel.TabIndex = 27;
            this.idCompanyLabel.Text = "Machine ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price/Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Modify Part";
            // 
            // modifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 622);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textMachineName);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textInventory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.cancelModifyPart);
            this.Controls.Add(this.saveModifyPart);
            this.Controls.Add(this.idCompanyLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modifyPart";
            this.Text = "modifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMachineName;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textInventory;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.RadioButton radioOutsourced;
        private System.Windows.Forms.RadioButton radioInHouse;
        private System.Windows.Forms.Button cancelModifyPart;
        private System.Windows.Forms.Button saveModifyPart;
        private System.Windows.Forms.Label idCompanyLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}