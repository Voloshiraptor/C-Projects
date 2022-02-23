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
    public partial class modifyPart : Form
    {
        Inventory inventoryForm1;
        int partId;
        public modifyPart()
        {
            InitializeComponent();
        }
        public modifyPart(Inventory inventory,int partID)
        {
            InitializeComponent();
            this.partId = partID;
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

        private void cancelModifyPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyPart_Load(object sender, EventArgs e)
        {

        }

        private void saveModifyPart_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            int stock = int.Parse(textInventory.Text);
            decimal price = decimal.Parse(textPrice.Text);
            int max = int.Parse(textMax.Text);
            int min = int.Parse(textMin.Text);

            if (this.textName != null || this.textInventory != null || this.textPrice != null || textMax != null || textMin != null || textMachineName != null)
            {
                if (radioInHouse.Checked)
                {
                    int machineId = int.Parse(textMachineName.Text);
                    InHouse partIn = new InHouse(name, price, stock, min, max, machineId);
                    inventoryForm1.updatePart(partId, partIn);
                    this.Close();
                }
                if (radioOutsourced.Checked)
                {
                    string companyName = textMachineName.Text;
                    Outsourced partOut = new Outsourced(name, price, stock, min, max, companyName);
                    inventoryForm1.updatePart(partId, partOut);
                    this.Close();
                }

            }
        }
    }
}
