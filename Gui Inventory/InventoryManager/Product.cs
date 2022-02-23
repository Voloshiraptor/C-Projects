using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Product
    {
        //Product Properties
        public BindingList<Part> AssociatedParts { get; set; }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(BindingList<Part> associatedParts, int id, string name, decimal price, int stock, int min, int max)
        {
            this.AssociatedParts = associatedParts;
            this.ProductID = id;
            this.Name = name;
            this.Price = price;
            this.InStock = stock;
            this.Min = min;
            this.Max = max;
        }
        //public Product( int id, string name, decimal price, int stock, int min, int max)
        //{
        //    this.ProductID = id;
        //    this.Name = name;
        //    this.Price = price;
        //    this.InStock = stock;
        //    this.Min = min;
        //    this.Max = max;
        //}

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        //Product functions
        public bool removeAssociatedPart(Part part)
        {
            if(AssociatedParts.Contains(part))
            {
                AssociatedParts.Remove(part);
                return true;
            }
            else
            { 
                return false; 
            }
            
        }

        public Part lookupAssociatedPart(int id)
        {
            return null;
        }
    }
}
