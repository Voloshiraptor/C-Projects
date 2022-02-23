using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
   public class Inventory
    {
        public BindingList<Product> Products = new BindingList<Product>();
        public BindingList<Part> AllParts = new BindingList<Part>();

      

        public void addProduct(Product product)
        {
            Products.Add(product);
        }

        public bool removeProduct(int product)
        {
            var productOld = Products.SingleOrDefault(p => p.ProductID == product);

            if (Products.Contains(productOld))
            {
                Products.Remove(productOld);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Product lookupProduct(int productID)
        {
            foreach (Product product in getAllProducts())
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public void updateProduct(int id,Product product)
        {
            var productOld = Products.SingleOrDefault(p => p.ProductID == id);
            int index = Products.IndexOf(productOld);
            Products[index] = product;
        }

        public void addPart(Part part)
        {
           AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            if(AllParts.Contains(part))
            {
                AllParts.Remove(part);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Part lookupPart(int partID)
        {
            foreach (Part part in getAllParts())
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public void updatePart(int partID,Part part)
        {
            var partOld = AllParts.SingleOrDefault(p => p.PartID == partID);
            int index = AllParts.IndexOf(partOld);
            AllParts[index] = part;
        }

        public BindingList<Part> getAllParts()
        {
            return AllParts;
        }

        public BindingList<Product> getAllProducts()
        {
            return Products;
        }
    }
}
