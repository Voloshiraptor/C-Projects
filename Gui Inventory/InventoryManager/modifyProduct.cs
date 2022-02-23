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

    public partial class modifyProduct : Form
    {
        Inventory inventoryForm1;
        BindingList<Part> associatedTempPart = new BindingList<Part>();
        int productID;
        public modifyProduct()
        {
            InitializeComponent();
        }
        public modifyProduct(Inventory inventory, int productId)
        {
            InitializeComponent();
            this.inventoryForm1 = inventory;
            this.productID = productId;
            dataGridParts.DataSource = inventoryForm1.AllParts;
            //Need to load associated parts list for product being modified.
            var productModify = inventoryForm1.Products.FirstOrDefault(p => p.ProductID == productID);
            associatedTempPart = productModify.AssociatedParts;
            dataGridAssociated.DataSource = associatedTempPart;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add button event on click for adding an associated part to a product
        private void addButton_Click(object sender, EventArgs e)
        {
            //get index of selected row in data table
            int selectedIndex = dataGridParts.CurrentCell.RowIndex;
            //get partID of part in selected row
            int partID = (int)dataGridParts.Rows[selectedIndex].Cells[0].Value;
            //store part from this row in temp variable
            var part = inventoryForm1.AllParts.FirstOrDefault(p => p.PartID == partID);

            //put part into associated parts list
            if (part != null && associatedTempPart.Contains(part) != true)
            {
                associatedTempPart.Add(part);
            }
        }

        //Delete button event on click for removing an associated part from a product
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //get index of selected row in data table
            int selectedIndex = dataGridAssociated.CurrentCell.RowIndex;
            //get partID of part in selected row
            int partID = (int)dataGridAssociated.Rows[selectedIndex].Cells[0].Value;
            //store part from this row in temp variable
            var part = associatedTempPart.FirstOrDefault(p => p.PartID == partID);
            associatedTempPart.Remove(part);

        }

        //Save button event on click for saving the products modified information
        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = inventoryForm1.Products.Count + 1;
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

            if (this.textName != null || this.textInventory != null || this.textPrice != null || textMax != null || textMin != null)
            {

                Product newProduct = new Product(associatedTempPart, id, name, price, stock, min, max);
                inventoryForm1.updateProduct(productID,newProduct);
                this.Close();

            }
            else
            {
                MessageBox.Show("Please fill out all the boxes");
                return;
            }

        }

        //Search button event on click for searching for a product
        private void searchButton_Click(object sender, EventArgs e)
        {
            //check if textbox has something inside
            if (searchBox.Text.Length > 0)
            {
                Product product;
                int productId = int.Parse(searchBox.Text);
                product = inventoryForm1.lookupProduct(productId);
                if (product == null)
                {
                    MessageBox.Show("Part could not be found", "Search Result");
                }
                else
                {
                    MessageBox.Show("Part found", "Search Result");
                }
            }
        }
    }
}
