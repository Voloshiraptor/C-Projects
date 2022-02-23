using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
   public abstract class Part
    {
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public Part(String name, decimal price, int stock, int min, int max)
        {
            Random rnd = new Random();
            partID = rnd.Next();
            this.name = name;
            this.price = price;
            this.inStock = stock;
            this.min = min;
            this.max = max;

        }
        public int PartID { get => partID; set => partID = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public int InStock { get => inStock; set => inStock = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
    }

}
