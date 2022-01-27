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
        public addPart()
        {
            InitializeComponent();
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
    }
}
