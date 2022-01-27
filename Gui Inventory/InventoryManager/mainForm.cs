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
        public IMS()
        {
            InitializeComponent();
        }

        private void IMS_Load(object sender, EventArgs e)
        {

        }

        private void addPart_Click(object sender, EventArgs e)
        {
            Form part = new addPart();
            part.ShowDialog();
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            Form partModify = new modifyPart();
            partModify.ShowDialog();
        }

        private void deletePart_Click(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            Form product = new addProduct();
            product.ShowDialog();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            Form productModify = new modifyProduct();
            productModify.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
