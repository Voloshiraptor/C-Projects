using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public void addProduct(Product product)
        {
            
        }

        public bool removeProduct(int product)
        {
            return false;
        }

        public Product lookupProduct(int productID)
        {
            return null;
        }

        public void updateProduct(int id,Product product)
        {

        }

        public void addPart(Part part)
        {

        }

        public bool deletePart(Part part)
        {
            return false;
        }

        public Part lookupPart(int partID)
        {
            return null;
        }

        public Part updatePart(int partID,Part part)
        {
            return null;
        }
    }
}
