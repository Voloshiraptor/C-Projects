
namespace InventoryManager
{
    partial class addPart
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idCompanyLabel = new System.Windows.Forms.Label();
            this.saveAddPart = new System.Windows.Forms.Button();
            this.cancelAddPart = new System.Windows.Forms.Button();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInventory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.textMachineName = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price/Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Min";
            // 
            // idCompanyLabel
            // 
            this.idCompanyLabel.AutoSize = true;
            this.idCompanyLabel.Location = new System.Drawing.Point(170, 378);
            this.idCompanyLabel.Name = "idCompanyLabel";
            this.idCompanyLabel.Size = new System.Drawing.Size(84, 20);
            this.idCompanyLabel.TabIndex = 7;
            this.idCompanyLabel.Text = "Machine ID";
            // 
            // saveAddPart
            // 
            this.saveAddPart.Location = new System.Drawing.Point(288, 498);
            this.saveAddPart.Name = "saveAddPart";
            this.saveAddPart.Size = new System.Drawing.Size(94, 29);
            this.saveAddPart.TabIndex = 8;
            this.saveAddPart.Text = "Save";
            this.saveAddPart.UseVisualStyleBackColor = true;
            // 
            // cancelAddPart
            // 
            this.cancelAddPart.Location = new System.Drawing.Point(422, 498);
            this.cancelAddPart.Name = "cancelAddPart";
            this.cancelAddPart.Size = new System.Drawing.Size(94, 29);
            this.cancelAddPart.TabIndex = 9;
            this.cancelAddPart.Text = "Cancel";
            this.cancelAddPart.UseVisualStyleBackColor = true;
            this.cancelAddPart.Click += new System.EventHandler(this.cancelAddPart_Click);
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Location = new System.Drawing.Point(222, 12);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(90, 24);
            this.radioInHouse.TabIndex = 0;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.UseVisualStyleBackColor = true;
            this.radioInHouse.CheckedChanged += new System.EventHandler(this.radioInHouse_CheckedChanged);
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Location = new System.Drawing.Point(440, 12);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(106, 24);
            this.radioOutsourced.TabIndex = 1;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            this.radioOutsourced.CheckedChanged += new System.EventHandler(this.radioOutsourced_CheckedChanged);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(331, 109);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(125, 27);
            this.textID.TabIndex = 12;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(331, 165);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 27);
            this.textName.TabIndex = 2;
            // 
            // textInventory
            // 
            this.textInventory.Location = new System.Drawing.Point(331, 220);
            this.textInventory.Name = "textInventory";
            this.textInventory.Size = new System.Drawing.Size(125, 27);
            this.textInventory.TabIndex = 3;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(331, 274);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(125, 27);
            this.textPrice.TabIndex = 4;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(331, 324);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(74, 27);
            this.textMax.TabIndex = 5;
            // 
            // textMachineName
            // 
            this.textMachineName.Location = new System.Drawing.Point(331, 375);
            this.textMachineName.Name = "textMachineName";
            this.textMachineName.Size = new System.Drawing.Size(125, 27);
            this.textMachineName.TabIndex = 7;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(472, 324);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(74, 27);
            this.textMin.TabIndex = 6;
            // 
            // addPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 623);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textMachineName);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textInventory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.cancelAddPart);
            this.Controls.Add(this.saveAddPart);
            this.Controls.Add(this.idCompanyLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idCompanyLabel;
        private System.Windows.Forms.Button saveAddPart;
        private System.Windows.Forms.Button cancelAddPart;
        private System.Windows.Forms.RadioButton radioInHouse;
        private System.Windows.Forms.RadioButton radioOutsourced;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textInventory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.TextBox textMachineName;
        private System.Windows.Forms.TextBox textMin;
    }
}