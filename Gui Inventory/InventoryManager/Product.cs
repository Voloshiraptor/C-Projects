using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Product
    {
        //Product Properties
        public BindingList<Part> AssociatedParts { get; set; }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part)
        {
            
        }
        //Product functions
        public bool removeAssociatedPart(Part part)
        {
            return false;
        }

        public Part lookupAssociatedPart(int id)
        {
            return null;
        }
    }
}
