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
    public partial class IMS : Form
    {
        Inventory inventory = new Inventory();

        
        public IMS()
        {
            InitializeComponent();
        }

        private void IMS_Load(object sender, EventArgs e)
        {
            
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            Form partAdd = new addPart(inventory);
            partAdd.ShowDialog();
            dataGridParts.DataSource = inventory.AllParts;
            dataGridProducts.DataSource = inventory.Products;
           


        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridParts.CurrentCell.RowIndex;
            int partID = (int)dataGridParts.Rows[selectedIndex].Cells[0].Value;
            Form partModify = new modifyPart(inventory,partID);
            partModify.ShowDialog();

        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridParts.CurrentCell.RowIndex;
            int partID = (int)dataGridParts.Rows[selectedIndex].Cells[0].Value;
            var part = inventory.AllParts.FirstOrDefault(p => p.PartID == partID);

            if (part != null)
            {
                inventory.deletePart(part);
            }

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            Form product = new addProduct(inventory);
            dataGridProducts.DataSource = inventory.Products;
            product.ShowDialog();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridProducts.CurrentCell.RowIndex;
            int productId = (int)dataGridProducts.Rows[selectedIndex].Cells[0].Value;
            Form productModify = new modifyProduct(inventory,productId);
            productModify.ShowDialog();
   
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Search button event to search for Part
        private void searchParts_Click(object sender, EventArgs e)
        {
            //check if textbox has something inside
            if(searchBoxParts.Text.Length > 0)
            {
                Part part;
                int partId = int.Parse(searchBoxParts.Text);
                part = inventory.lookupPart(partId);
                if(part == null)
                {
                    MessageBox.Show("Part could not be found", "Search Result");
                }
                else
                {
                    foreach(DataGridViewRow row in dataGridParts.Rows)
                    {
                        for(int i = 0; i < row.Cells.Count; i++)
                        {
                            if(row.Cells[i].Value != null && row.Cells[i].Value.Equals(partId))
                            {
                                int rowIndex = row.Index;
                                dataGridParts.Rows[rowIndex].Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                dataGridParts.DataSource = inventory.AllParts;
                dataGridProducts.DataSource = inventory.Products;
            }
        }

        //Search button event to search for Product
        private void searchProducts_Click(object sender, EventArgs e)
        {
            //check if textbox has something inside
            if (searchBoxProducts.Text.Length > 0)
            {
                Product product;
                int productId = int.Parse(searchBoxProducts.Text);
                product = inventory.lookupProduct(productId);
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

        //Delete button event for Products
        private void deleteProduct_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridProducts.CurrentCell.RowIndex;
            int productID = (int)dataGridProducts.Rows[selectedIndex].Cells[0].Value;
            var product = inventory.Products.FirstOrDefault(p => p.ProductID == productID);

            if (product != null)
            {
                inventory.removeProduct(productID);
            }


        }
    }
}
