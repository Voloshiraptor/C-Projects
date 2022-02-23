using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class addPart : Form
    {
       
        Inventory inventoryForm1;
        
        public addPart()
        {
            InitializeComponent();
        }

        public addPart(Inventory inventory)
        {
            InitializeComponent();
            this.inventoryForm1 = inventory;
        }



        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInHouse.Checked)
            {
                idCompanyLabel.Text = "Machine ID";
            }

        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutsourced.Checked)
            {
                idCompanyLabel.Text = "Company Name";
            }
        }

        private void cancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAddPart_Click(object sender, EventArgs e)
        {

            //int partId = inventoryForm1.AllParts.Count + 1;
            string name = textName.Text;
            int stock = int.Parse(textInventory.Text);
            decimal price = decimal.Parse(textPrice.Text);
            int max = int.Parse(textMax.Text);
            int min = int.Parse(textMin.Text);

            if (int.Parse(textMax.Text) < int.Parse(textMin.Text) || int.Parse(textInventory.Text) > int.Parse(textMax.Text) && int.Parse(textInventory.Text) < int.Parse(textMin.Text))
            {
                MessageBox.Show("You can not have a maximum lower than your minimum or Inventory greater than maximum or minimum");
                return;

            }

            if (this.textName != null || this.textInventory != null || this.textPrice != null || textMax != null || textMin != null || textMachineName != null)
            {
                if (radioInHouse.Checked)
                {
                    int machineId = int.Parse(textMachineName.Text);
                    InHouse partIn = new InHouse(name,price,stock,min,max,machineId);
                    inventoryForm1.addPart(partIn);
                    this.Close();
                }
                if (radioOutsourced.Checked)
                {
                    string companyName = textMachineName.Text;
                    Outsourced partOut = new Outsourced(name,price,stock,min,max,companyName);
                    inventoryForm1.addPart(partOut);
                    this.Close();
                }

                
                
            }
            else
            {
                MessageBox.Show("Please fill out all the boxes");
                return;
            }
                
            
        }
    }
}
